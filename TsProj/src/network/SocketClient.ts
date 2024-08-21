import ProtoKey from "../protobuf/key/ProtoKey";

/**
 * SocketClient 封装了 UTGEngine.Socket ，允许服务器端与客户端进行全双工（full-duplex）的实时通信，并且允许跨域通信。在建立连接后，服务器和 Client Agent 都能主动的向对方发送或接收文本和二进制数据。
 * SocketClient 以异步方式传输和接收数据。
 */
export class SocketClient {

	public static NETWORK_EVENT_CONNECTED = 0;
	public static NETWORK_EVENT_CLOSED = 1;
	public static NETWORK_EVENT_IO_ERROR = 2;
	public static NETWORK_EVENT_DATA = 3;
	public static NETWORK_EVENT_DATA_ERROR = 4;

	protected static LOADING_MAX_TIME = 10000;

	private static _serverUrl: string;
	private static _socket: Socket = null;
	private static _heartBeatCount = 0;
	private static _heartBeatTime = 30;
	private static _loadingCount: number = 0;

	private static _socketEvent: string = "__SOCKET_CLIENT_EVENT__";
	private static _eventDispatcher: EventDispatcher;

	private static _protoKeys = {};
	private static _needLoadingProto: { [pid: number]: number } = {};

	/**
	 * 服务端 WebSocket URL。 URL 类似 ws://yourdomain:port。
	 */
	public static set serverUrl(url: string) {
		SocketClient._serverUrl = url;
	}

	/**
	 * 添加需要显示Loading的协议，一般是实时网络通信的协议才需要
	 * @param reqId 请求包ID
	 * @param respId 回包ID
	 */
	public static addNeedLoadingProto(reqId: number, respId: number): void {
		SocketClient._needLoadingProto[reqId] = respId;
		SocketClient._needLoadingProto[respId] = reqId;
	}

	/**
	 * 连接到服务器
	 * @param reConnect 是否重连，true/false，true时将不清除
	 * @comment 连接成功派发 NETWORK_EVENT_CONNECTED 事件
	 * 			连接失败派发 NETWORK_EVENT_IO_ERROR 事件
	 * 			连接被关闭派发 NETWORK_EVENT_CLOSED 事件
	 * 			接收到数据派发 NETWORK_EVENT_DATA 事件
	 */
	public static connect(reConnect: boolean = false): void {
		if (!SocketClient._serverUrl) {
			throw new Error("[SocketClient] - connect -->serverUrl is invalid");
		}

		if (!SocketClient._eventDispatcher) {
			SocketClient._eventDispatcher = new EventDispatcher();
		}

		if (SocketClient._socket) {
			SocketClient.close(!reConnect);
		}

		SocketClient._socket = new Socket(SocketClient._serverUrl);
		SocketClient._socket.on(SOCKET_EVENT.ON_CONNECT, SocketClient, SocketClient._onSocketOpen);
		SocketClient._socket.on(SOCKET_EVENT.ON_ERROR, SocketClient, SocketClient._onSocketError);
		SocketClient._socket.on(SOCKET_EVENT.ON_CLOSE, SocketClient, SocketClient._onSocketClose);
		SocketClient._socket.on(SOCKET_EVENT.ON_MESSAGE, SocketClient, SocketClient._onReceiveMessage);
		SocketClient.trace("trying to connect to server..." + SocketClient._serverUrl);

		//打印用
		for (let m in ProtoKey.KEY) {
			if (typeof ProtoKey.KEY[m] == "number" || typeof ProtoKey.KEY[m] == "string") {
				SocketClient._protoKeys[ProtoKey.KEY[m]] = m;
			}
		}

		SocketClient._socket.connect(reConnect);
	}

	/**
	 * 注册指定类型的事件侦听器对象，以使侦听器能够接收事件通知。
	 * @param caller	事件侦听函数的执行域。
	 * @param listener	事件侦听函数。
	 * @param args		（可选）事件侦听函数的回调参数。
	 */
	public static on(caller: any, listener: Function, args?: any[]): void {
		this._eventDispatcher.on(SocketClient._socketEvent, caller, listener, args);
	}

	/**
	 * 删除侦听器。
	 * @param caller	事件侦听函数的执行域。
	 * @param listener	事件侦听函数。
	 */
	public static off(caller: any, listener: Function): void {
		this._eventDispatcher.off(SocketClient._socketEvent, caller, listener);
	}

	/**
	 * 删除指定事件类型的所有侦听器。
	 */
	public static offAll(): void {
		this._eventDispatcher.offAll(SocketClient._socketEvent);
	}

	/**
	 * 移除caller为target的所有事件监听
	 * @param	caller caller对象
	 */
	public static offAllCaller(caller: any): void {
		this._eventDispatcher.offAllCaller(caller);
	}

	/**
	 * 目前是否已连接。
	 */
	public static get connected(): boolean {
		return SocketClient._socket && SocketClient._socket.connected;
	}

	public static close(clearListeners: boolean = true) {
		SocketClient.trace("socket close...");
		if (clearListeners) {
			SocketClient.offAll();
		}

		UTGEngine.timer.clear(SocketClient, SocketClient._onTimer);
		if (SocketClient._socket) {
			SocketClient._socket.close();
		}
		SocketClient._socket = null;
	}

	/**
	 * 
	 * @param protoId 协议ID
	 * @param data 协议数据
	 * @returns 是否已发送数据 true/false
	 */
	public static send(protoId: number, data: any): boolean {
		let protoMethod = ProtoKey.KEY[protoId];
		//校验协议
		if (!protoMethod) {
			SocketClient.trace("can not find proto request - " + protoId);
			return false;
		}

		//校验数据格式
		let errMsg = protoMethod.verify(data);
		if (errMsg) {
			SocketClient.trace("send data is invalid - " + protoId + "  " + JSON.stringify(data));
			return false;
		}

		//检查网络
		if (!SocketClient.connected) {
			SocketClient.trace("socket does not connect --> " + protoId);
			return false;
		}

		//序列化并发送
		let sendData = protoMethod.create(data);
		let sendBuf = protoMethod.encode(sendData).finish() as Buffer;
		let protoNum = protoId;
		let outData = CS.System.Array.CreateInstance(puer.$typeof(CS.System.Byte), sendBuf.length + 2) as CS.System.Array$1<number>;
		outData.set_Item(0, (protoNum & 0xFF00) >> 8);
		outData.set_Item(1, protoNum & 0x00FF);
		for (let i = 0; i < sendBuf.length; i++) {
			outData.set_Item(i + 2, sendBuf[i]);
		}

		SocketClient._socket.send(outData);
		SocketClient.trace("Send data - " + protoId + "  " + SocketClient._protoKeys[protoId] + "  " + JSON.stringify(data));

		// 显示loading
		if (!SocketClient._needLoadingProto[protoId]) {
			return true;
		}

		SocketClient._loadingCount++;
		if (SocketClient._loadingCount <= 1) {
			UTGEngine.timer.once(500, SocketClient, SocketClient._showLoading);
		}

		UTGEngine.timer.clear(SocketClient, SocketClient._timeoutLoading);
		UTGEngine.timer.once(SocketClient.LOADING_MAX_TIME, SocketClient, SocketClient._timeoutLoading);
		return true;
	}

	/** internal */
	private static _onTimer(): void {
		SocketClient._heartBeatCount = SocketClient._heartBeatCount + 1;
		if (SocketClient._heartBeatCount >= SocketClient._heartBeatTime) {
			SocketClient._heartBeatCount = 0;
			SocketClient.send(ProtoKey.KEY["base.U_HEART"], {});
		}
	}

	/** internal */
	private static _showLoading(): void {
		// SocketClient._fnShowLoading && SocketClient._fnShowLoading();
	}

	/** internal */
	private static _timeoutLoading(): void {
		SocketClient._loadingCount = 0;
		SocketClient._hideLoading();
	}

	/** internal */
	private static _hideLoading(): void {
		if (SocketClient._loadingCount > 0) {
			SocketClient._loadingCount--;
		}

		if (SocketClient._loadingCount <= 0) {
			// SocketClient._fnShowLoading && SocketClient._fnHideLoading();
			UTGEngine.timer.clear(SocketClient, SocketClient._timeoutLoading);
			UTGEngine.timer.clear(SocketClient, SocketClient._showLoading);
		}
	}

	/** internal */
	private static _onSocketOpen(): void {
		SocketClient.trace("WebSocketOpen");
		SocketClient._eventDispatcher.event(SocketClient._socketEvent, { type: SocketClient.NETWORK_EVENT_CONNECTED });
	}

	/** internal */
	private static _onSocketClose(data: { code: number, data: string }): void {
		SocketClient.trace("WebSocketClose-->code: " + data.code.toString() + "  message: " + data.data);
		SocketClient._eventDispatcher.event(SocketClient._socketEvent, { type: SocketClient.NETWORK_EVENT_CLOSED });
		SocketClient.close(false);
	}

	/** internal */
	private static _onSocketError(data: { data: string }): void {
		SocketClient.trace("WebSocketError-->" + data.data);
		SocketClient._eventDispatcher.event(SocketClient._socketEvent, { type: SocketClient.NETWORK_EVENT_IO_ERROR });
	}

	/** internal */
	private static _onReceiveMessage(message: CS.System.Array$1<number>): void {
		//反序列化
		let msgLength = message.Length;
		if (msgLength < 2) {
			SocketClient.trace("Received data is too short : " + msgLength);
			return;
		}

		let protoId = message.get_Item(0) << 8 | message.get_Item(1);
		SocketClient.trace("received protoId - " + protoId);

		//读取协议号
		let protoMethod = ProtoKey.KEY[protoId];
		if (!protoMethod) {
			SocketClient.trace("can not find proto response - " + protoId);
			return;
		}

		if (SocketClient._needLoadingProto[protoId]) {
			SocketClient._hideLoading();
		}

		let recvData = {};
		if (msgLength >= 2) {
			let msgBuf = new Uint8Array(msgLength - 2);
			for (let i = 2; i < message.Length; i++) {
				msgBuf[i - 2] = message.get_Item(i);
			}

			//提取数据并反序列化
			recvData = protoMethod.decode(msgBuf);
			if (!recvData) {
				SocketClient.trace("Received data decode error - " + protoId + "  " + recvData);
				return;
			}
		}

		if (protoId === ProtoKey.KEY["base.G_LOGIN"] || protoId === ProtoKey.KEY["base.G_RELOGIN"]) {
			//开始心跳
			UTGEngine.timer.clear(SocketClient, SocketClient._onTimer);
			UTGEngine.timer.loop(1000, SocketClient, SocketClient._onTimer);
		}

		//通知上层应用处理
		SocketClient.trace("Receive data - " + protoId + "  " + SocketClient._protoKeys[protoId] + "  " + JSON.stringify(recvData));
		if (protoId !== ProtoKey.KEY["base.G_HEART"]) {
			SocketClient._eventDispatcher.event(SocketClient._socketEvent, { type: SocketClient.NETWORK_EVENT_DATA, errorCode: 0, protoId: protoId, data: recvData });
		}
	}

	/** internal */
	private static trace(msg: any): void {
		console.log("【SocketClient】" + msg);
	}
}