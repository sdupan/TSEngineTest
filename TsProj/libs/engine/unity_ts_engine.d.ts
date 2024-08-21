/**
 * 游戏平台类型
 */
declare enum GAME_PLATFORM_TYPE {
    NONE = 2,
    IOS = 1,
    ANDROID = 2,
    WINDOWS = 3
}
/**
 * 引擎事件类型
 */
declare enum UTG_ENGINE_EVENT_TYPE {
    APPLICATION_FOCUS = "__UTG_ENGINE_EVENT_TYPE_APPLICATION_FOCUS__",
    APPLICATION_PAUSE = "__UTG_ENGINE_EVENT_TYPE_APPLICATION_PAUSE__",
    GAME_DATA_MODEL_UPDATE = "__UTG_ENGINE_EVENT_TYPE_GAME_DATA_MODEL_UPDATE__"
}
/**
 * 引擎调试日志结构
 */
interface UTG_ENGINE_DEBUG_LOG {
    logType: CS.UnityEngine.LogType;
    condition: string;
    stackTrace: string;
}
/**
 * 玩家存储二进制数据结构
 */
interface PLAYER_STORAGE_QUEUE_ITEM_DATA {
    id: number;
    time: bigint;
    pid: number;
    data: CS.System.Array$1<number>;
}
/**
 * 玩家存储回调返回的数据的结构
 */
interface PLAYER_STORAGE_RESULT_DATA {
    id: number;
    opType: number;
    data?: any;
}
/**
 * 玩家存储回调
 */
type UTGPlayerStorageCallBack = (data: PLAYER_STORAGE_RESULT_DATA) => void;

/**
 * @internal
 * 使用全局类的时候，避免引用其他模块
 */
declare class IEngine {
    static UTGEngine: any;
    static Timer: typeof Timer;
    static Utils: typeof Utils;
    static Pool: typeof Pool;
    static timer: Timer;
    static logicTimer: Timer;
}

declare class UTGEngine {
    /**游戏系统定时器，不可被暂停*/
    static timer: Timer;
    static logicTimer: Timer;
    /** 当前引擎版本。*/
    static version: string;
    /**@internal*/
    static GAME_PLATFORM_TYPE: typeof GAME_PLATFORM_TYPE;
    /**@internal*/
    static EventDispatcher: typeof EventDispatcher;
    /**@internal*/
    static EventCenter: typeof EventCenter;
    /**@internal*/
    static Socket: typeof Socket;
    /**@internal*/
    static SOCKET_EVENT: typeof SOCKET_EVENT;
    /**@internal*/
    static Handler: typeof Handler;
    /**@internal*/
    static Utils: typeof Utils;
    /**@internal*/
    static iterator: typeof iterator;
    /**@internal*/
    static BitUtil: typeof UTGBitUtil;
    /**@internal*/
    static TimeUtil: typeof UTGTimeUtil;
    /**@internal*/
    static U3DTool: typeof UTG3DTool;
    /**@internal*/
    static MD5: typeof UTGMD5;
    /**@internal*/
    static Base64: typeof UTGBase64;
    /**@internal*/
    static OSUtil: typeof OSUtil;
    /**@internal*/
    static Ease: typeof UTGEase;
    /**@internal*/
    static Tween: typeof UTGTween;
    /**@internal*/
    static Bezier: typeof UTGBezier;
    /**@internal*/
    static LocalStorage: typeof UTGLocalStorage;
    /**@internal*/
    static PlayerStorage: typeof UTGPlayerStorage;
    /**@internal*/
    static BaseModel: typeof UTGBaseModel;
    /**@internal*/
    static GameDataModel: typeof UTGGameDataModel;
    /**@internal*/
    static DebugLogModel: typeof UTGDebugLogModel;
    /**@internal*/
    static ModelHelper: typeof UTGModelHelper;
    /**@internal*/
    static BaseView: typeof UTGBaseView;
    /**@internal*/
    static UIHelper: typeof UTGUIHelper;
    /**@internal*/
    static GameMain: typeof UTGGameMain;
    static init(): void;
}

/**
 * 游戏启动类
 */
declare class UTGGameMain {
    constructor();
    /**
     * 游戏退出
     * @description 可重写
     */
    protected _onJsOnApplicationQuit(): void;
    /**
     * 游戏前后台切换
     * @description 可重写
     */
    protected _onJsOnApplicationFocus(focus: boolean): void;
    /**
     * 游戏暂停与恢复
     * @description 可重写
     */
    protected _onJsOnApplicationPause(paused: boolean): void;
    /**
     * 游戏循环
     * @description 可重写
     */
    protected _onJsOnUpdate(): void;
    /**
     * 引擎初始化完毕，可加入其他初始化流程
     * @description 可重写
     */
    protected _onUTGEngineInited(): Promise<void>;
    /**
     * SDK初始化，重写该接口，加入SDK的初始化流程，比如
     * @description 可重写
     */
    protected _onSDKinit(): Promise<void>;
    /**
     * 游戏启动完毕
     * @description 可重写
     */
    protected _onGameStart(): void;
    /**@internal */
    protected startGame(): Promise<void>;
}

/**
 * 消息中心，游戏业务功能的事件分发通过此消息中心分发
 */
declare class EventCenter {
    /** 消息对象 */
    protected static _eventDispatcher: EventDispatcher;
    /**
     * 检查是否为特定事件类型注册了任何侦听器。
     * @param	eventName 事件的类型。
     * @return 如果指定类型的侦听器已注册，则值为 true；否则，值为 false。
     */
    static hasListener(eventName: string): boolean;
    /**
     * 注册指定类型的事件侦听器对象，以使侦听器能够接收事件通知。
     * @param eventName	事件的类型。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param args		（可选）事件侦听函数的回调参数。
     */
    static on(eventName: string, caller: any, listener: Function, args?: any[]): void;
    /**
     * 注册指定类型的事件侦听器对象，以使侦听器能够接收事件通知，此侦听事件响应一次后自动移除。
     * @param type		事件的类型。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param args		（可选）事件侦听函数的回调参数。
     */
    static once(eventName: string, caller: any, listener: Function, args?: any[]): void;
    /**
     * 删除侦听器。
     * @param eventName	事件的类型。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param onceOnly	（可选）如果值为 true ,则只移除通过 once 方法添加的侦听器。
     */
    static off(eventName: string, caller: any, listener: Function): void;
    /**
     * 删除指定事件类型的所有侦听器。
     * @param type	（可选）事件类型，如果值为 null，则移除本对象所有类型的侦听器。
     */
    static offAll(eventName?: string): void;
    /**
     * 移除caller为target的所有事件监听
     * @param	caller caller对象
     */
    static offAllCaller(caller: any): void;
    /**
     * 派发事件。
     * @param eventName	事件类型。
     * @param data	（可选）回调数据。注意：如果是需要传递多个参数 p1,p2,p3,...可以使用数组结构如：[p1,p2,p3,...] ；如果需要回调单个参数 p ，且 p 是一个数组，则需要使用结构如：[p]，其他的单个参数 p ，可以直接传入参数 p。
     * @return 此事件类型是否有侦听者，如果有侦听者则值为 true，否则值为 false。
     */
    static event(eventName: string, data?: any): void;
}

/**
 * EventDispatcher 类是可调度事件的所有类的基类。
 */
declare class EventDispatcher {
    /**@private */
    protected _events: {
        [type: string]: any;
    };
    /**
     * 检查 EventDispatcher 对象是否为特定事件类型注册了任何侦听器。
     * @param	type 事件的类型。
     * @return 如果指定类型的侦听器已注册，则值为 true；否则，值为 false。
     */
    hasListener(type: string): boolean;
    /**
     * 派发事件。
     * @param type	事件类型。
     * @param data	（可选）回调数据。<b>注意：</b>如果是需要传递多个参数 p1,p2,p3,...可以使用数组结构如：[p1,p2,p3,...] ；如果需要回调单个参数 p ，且 p 是一个数组，则需要使用结构如：[p]，其他的单个参数 p ，可以直接传入参数 p。
     * @return 此事件类型是否有侦听者，如果有侦听者则值为 true，否则值为 false。
     */
    event(type: string, data?: any): boolean;
    /**
     * 使用 EventDispatcher 对象注册指定类型的事件侦听器对象，以使侦听器能够接收事件通知。
     * @param type		事件的类型。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param args		（可选）事件侦听函数的回调参数。
     * @return 此 EventDispatcher 对象。
     */
    on(type: string, caller: any, listener: Function, args?: any[]): EventDispatcher;
    /**
     * 使用 EventDispatcher 对象注册指定类型的事件侦听器对象，以使侦听器能够接收事件通知，此侦听事件响应一次后自动移除。
     * @param type		事件的类型。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param args		（可选）事件侦听函数的回调参数。
     * @return 此 EventDispatcher 对象。
     */
    once(type: string, caller: any, listener: Function, args?: any[]): EventDispatcher;
    /**@internal */
    private _createListener;
    /**
     * 从 EventDispatcher 对象中删除侦听器。
     * @param type		事件的类型。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param onceOnly	（可选）如果值为 true ,则只移除通过 once 方法添加的侦听器。
     * @return 此 EventDispatcher 对象。
     */
    off(type: string, caller: any, listener: Function, onceOnly?: boolean): EventDispatcher;
    /**
     * 从 EventDispatcher 对象中删除指定事件类型的所有侦听器。
     * @param type	（可选）事件类型，如果值为 null，则移除本对象所有类型的侦听器。
     * @return 此 EventDispatcher 对象。
     */
    offAll(type?: string): EventDispatcher;
    /**
     * 移除caller为target的所有事件监听
     * @param	caller caller对象
     */
    offAllCaller(caller: any): EventDispatcher;
    /**@internal */
    private _recoverHandlers;
}

type Array$1Iterator<T> = {
    /**
     * 遍历Array$1对象
     * @param callbackfn
     */
    forEach(callbackfn: (v: T, index: number) => boolean | void): void;
    /**
     * 实现for迭代器接口
     */
    [Symbol.iterator](): {
        next(): {
            value: T;
            done: boolean;
        };
    };
};
type List$1Iterator<T> = {
    /**
     * 遍历List$1对象
     * @param callbackfn
     */
    forEach(callbackfn: (v: T, index: number) => boolean | void): void;
    /**
     * 实现for迭代器接口
     */
    [Symbol.iterator](): {
        next(): {
            value: T;
            done: boolean;
        };
    };
};
type Dictionary$2Iterator<TKey, TValue> = {
    /**
     * 遍历Dictionary$2对象
     * @param callbackfn
     */
    forEach(callbackfn: (v: TValue, k?: TKey) => boolean | void): void;
    /**
     * Key集合
     */
    getKeys(): TKey[];
    /**
     * Value集合
     */
    getValues(): TValue[];
    /**
     * 实现for迭代器接口
     */
    [Symbol.iterator](): {
        next(): {
            value: {
                key: TKey;
                value: TValue;
            };
            done: boolean;
        };
    };
};
type IEnumerator$1Iterator<T> = {
    /**
     * 遍历List$1对象
     * @param callbackfn
     */
    forEach(callbackfn: (v: T, index: number) => boolean | void): void;
    /**
     * 实现for迭代器接口
     */
    [Symbol.iterator](): {
        next(): {
            value: T;
            done: boolean;
        };
    };
};
type IEnumeratorType<T> = {
    GetEnumerator(): CS.System.Collections.IEnumerator;
} | {
    GetEnumerator(): CS.System.Collections.Generic.IEnumerator$1<T>;
};
/**
 * 迭代System.Array.Array$1对象
 * @example
 * ```
 * let obj: System.Array$1<number>;
 * let objIterator = iterator(obj);
 * let jsArray = [...objIterator];              //number[]
 * ```
 */
declare function iterator<T = any>(instance: CS.System.Array$1<T>): CS.System.Array$1<T> & Array$1Iterator<T>;
declare function iterator(instance: CS.System.Array): CS.System.Array & Array$1Iterator<any>;
/**
 * 迭代System.Collections.Generic.List$1对象
 * @example
 * ```
 * let obj: System.Collections.Generic.List$1<number>;
 * let objIterator = iterator(obj);
 * let jsArray = [...objIterator];              //number[]
 * ```
 */
declare function iterator<T = any>(instance: CS.System.Collections.Generic.List$1<T>): CS.System.Collections.Generic.List$1<T> & List$1Iterator<T>;
/**
 * 迭代System.Collections.Generic.Dictionary$2对象
 * @example
 * ```
 * let obj: System.Collections.Generic.Dictionary$2<number, string>;
 * let objIterator = iterator(obj);
 * let keys = objIterator.getKeys();            //number[]
 * let values = objIterator.getValues();        //string[]
 * let keyValuePairs = [...objIterator];        //Array<{ key: number, value: string }>
 * ```
 */
declare function iterator<TKey = any, TValue = any>(instance: CS.System.Collections.Generic.Dictionary$2<TKey, TValue>): CS.System.Collections.Generic.Dictionary$2<TKey, TValue> & Dictionary$2Iterator<TKey, TValue>;
declare function iterator<T extends CS.System.Object & IEnumeratorType<TF>, TF = any>(instance: T): T & IEnumerator$1Iterator<TF>;


/**
 * 数据模块基类
 */
declare class UTGBaseModel {
    /**@internal */
    protected static _eventDispatcher: EventDispatcher;
    /**
     * 初始化
     */
    static init(): void;
    /**
     * 清空数据
     */
    static clearModelData(): void;
    /**
     * 侦听模块变化事件。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     * @param args		（可选）事件侦听函数的回调参数。
     */
    static on(caller: any, listener: Function, args?: any[]): void;
    /**
     * 删除指定对象下的模块变化事件侦听器。
     * @param caller	事件侦听函数的执行域。
     * @param listener	事件侦听函数。
     */
    static off(caller: any, listener: Function): void;
    /**
     * 删除所有侦听。
     */
    static offAll(): void;
    /**
     * 删除指定对象下的所有模块变化事件侦听器。
     * @param caller	事件侦听函数的执行域。
     */
    static offAllCaller(caller: any): void;
    /**@internal */
    protected static notifyModelUpdate(data: any): void;
}

/**
 * 游戏系统调试日志
 */
declare class UTGDebugLogModel extends UTGBaseModel {
    protected static _logs: UTG_ENGINE_DEBUG_LOG[];
    protected static _newLogs: UTG_ENGINE_DEBUG_LOG[];
    /**
     * 初始化
     */
    static init(): void;
    /**
     * 停止日志收集
     */
    static clearModelData(): void;
    /**
     * 日志内容
     */
    static get logs(): UTG_ENGINE_DEBUG_LOG[];
    /**
     * 清除所有日志
     */
    static clearLogs(): void;
    /**@internal */
    protected static _logReceived(condition: string, stackTrace: string, type: CS.UnityEngine.LogType): void;
    /**@internal */
    protected static _timeLoop(): void;
}

/**
 * 数据模块类标签，在数据模块类的声明前加上该标签
 * @param order 初始化顺序
 * @returns ClassDecorator
 *
 * for example:
 *
 * @UTGGameDataModel(10001)
 * public class TestModelA extends UTGBaseModel {
 *     // TODO
 * }
 *
 * @UTGGameDataModel()
 * public class TestModelB extends UTGBaseModel {
 *     // TODO
 * }
 *
 * @UTGGameDataModel(9000)
 * public class TestModelC extends UTGBaseModel {
 *     // TODO
 * }
 *
 * 初始化顺序：TestModelC-->TestModelB-->TestModelA
 */
declare function UTGGameDataModel(order?: number): ClassDecorator;
/**
 * 数据模块工具
 */
declare class UTGModelHelper {
    /**
     * 初始化所有数据模块
     */
    static initAllModels(): void;
    /**
     * 清理所有数据模块
     */
    static clearAllModels(): void;
}

/**
 * WebSocket事件
 */
declare enum SOCKET_EVENT {
    ON_CONNECT = "__SOCKET_ON_CONNECT__",
    ON_CLOSE = "__SOCKET_ON_CLOSE__",
    ON_ERROR = "__SOCKET_ON_ERROR__",
    ON_SEND = "__SOCKET_ON_SEND__",
    ON_MESSAGE = "__SOCKET_ON_MESSAGE__"
}
/**
 * Socket 封装了 WebSocket ，允许服务器端与客户端进行全双工（full-duplex）的实时通信，并且允许跨域通信。在建立连接后，服务器和 Client Agent 都能主动的向对方发送或接收文本和二进制数据。
 * 要使用 Socket 类的方法，请先使用构造函数 new Socket 创建一个 Socket 对象。Socket 以异步方式传输和接收数据。
 */
declare class Socket extends EventDispatcher {
    /** 服务器地址 */
    private _serverUrl;
    /** WebSocket对象 */
    private _socket;
    /** WebSocket连接事件 */
    private _openDelegate;
    /** WebSocket错误事件 */
    private _errorDelegate;
    /** WebSocket关闭事件 */
    private _closedDelegate;
    /** WebSocket接收二进制数据事件 */
    private _binaryDelegate;
    /** 是否已连接 */
    private _connected;
    /**
     * 创建新的 Socket 对象
     * @param url 服务端 WebSocket URL。 URL 类似 ws://yourdomain:port。
     */
    constructor(url: string);
    /**
     * 连接到服务器
     * @param reConnect 是否重连，true/false，true时将不清除已添加的事件
     * @comment 连接成功派发 SOCKET_EVENT.ON_CONNECT 事件
     * 			连接失败派发 SOCKET_EVENT.ON_ERROR 事件
     * 			连接被关闭派发 SOCKET_EVENT.ON_CLOSE 事件
     * 			发送数据后派发 SOCKET_EVENT.ON_SEND 事件
     * 			接收到数据派发 SOCKET_EVENT.ON_MESSAGE 事件
     */
    connect(reConnect?: boolean): void;
    /**
     * 目前是否已连接。
     */
    get connected(): boolean;
    /**
     * 关闭连接
     * @param clearListeners 是否清除事件侦听
     */
    close(clearListeners?: boolean): void;
    /**
     * 发送数据
     * @param data 要发送的二进制数据
     * @returns true-已发送 false-发送失败，通常是未成功建立连接
     */
    send(data: CS.System.Array$1<number>): boolean;
    /** internal */
    private _onSocketOpen;
    /** internal */
    private _onSocketClose;
    /** internal */
    private _onSocketError;
    /** internal */
    private _onReceiveMessage;
}

/**
 * 本地存储(Key-Value)
 */
declare class UTGLocalStorage {
    /**@internal */
    protected static _dbFilePath: string;
    /**@internal */
    protected static _dbFileName: string;
    /**@internal */
    protected static _sqlite3DBHandle: any;
    /**
     * 初始化
     */
    static init(): void;
    /**
     * 关闭本地存储
     */
    static destroy(): void;
    /**
     * 保存数据
     * @param key       唯一key
     * @param value     数据
     */
    static setItem(key: string, value: number | string | object): void;
    /**
     * 获取数据
     * @param key 唯一key
     * @returns 获取到的数据，获取失败返回null
     */
    static getItem(key: string): any;
    /**
     * 删除数据
     * @param key 唯一key
     */
    static removeItem(key: string): void;
    /**
     * 清空所有数据
     */
    static clearItems(): void;
    /**@internal */
    protected static _openDB(): boolean;
    /**@internal */
    protected static _checkTables(): boolean;
}

/**
 * 玩家数据存储
 */
declare class UTGPlayerStorage {
    /**@internal */
    protected static _dbFilePath: string;
    /**@internal */
    protected static _dbFileName: string;
    /**@internal */
    protected static _dbFileExt: string;
    /**@internal */
    protected static _dbObj: CS.UnityTSGame.SQLHandler;
    /**@internal */
    protected static _autoId: number;
    /**@internal */
    protected static _opCallbacks: {
        [id: number]: {
            key: string;
            fnCallBack: UTGPlayerStorageCallBack;
        };
    };
    /**
     * 初始化
     * @param uniqueId 唯一ID，通常是玩家ID
     */
    static init(uniqueId: string): void;
    /**
     * 关闭玩家存储
     */
    static destroy(): void;
    /**
     * 设置数据
     * @param key       唯一key
     * @param value     数据内容
     * @param cb 设置结果回调
     */
    static setItem(key: string, value: number | string | object, cb?: UTGPlayerStorageCallBack): void;
    /**
     * 获取数据
     * @param key       唯一key
     * @param cb 获取结果回调
     */
    static getItem(key: string, cb?: UTGPlayerStorageCallBack): void;
    /**
     * 删除数据
     * @param key 唯一key
     * @param cb 删除结果回调
     */
    static removeItem(key: string, cb?: UTGPlayerStorageCallBack): void;
    /**
     * 清空数据
     * @param cb 清空结果回调
     */
    static clearItems(cb?: UTGPlayerStorageCallBack): void;
    /**
     * 保存协议数据
     * @param protos 保存的数据内容
     * @param temp 是否是缓存 true-保存到协议数据区 false-保存到缓存区
     * @param cb 执行结果回调
     */
    static batchAddProto(protos: {
        time: number;
        protoId: number;
        data: CS.System.Array$1<number>;
    }[], temp?: boolean, cb?: UTGPlayerStorageCallBack): void;
    /**
     * 获取协议数据区的所有协议数据(非缓存)
     * @param cb 获取结果回调
     */
    static getProtos(cb?: UTGPlayerStorageCallBack): void;
    /**
     * 删除协议数据区及缓存区的所有数据
     * @param cb 删除结果回调
     */
    static deleteAllProtos(cb?: UTGPlayerStorageCallBack): void;
    /**
     * 同步缓存区的数据到协议数据区
     * @param cb 执行结果回调
     */
    static syncTempProtos(cb?: UTGPlayerStorageCallBack): void;
    /**
     * 清空协议数据区所有数据，再将缓存区的数据同步到协议数据区
     * @param cb 执行结果回调
     */
    static clearProtosAndSyncTempProtos(cb?: UTGPlayerStorageCallBack): void;
    /**@internal */
    protected static _openDB(uniqueId: string): boolean;
    /**@internal */
    protected static _checkTables(): boolean;
    /**@internal */
    protected static _opEndAction(id: number, opType: number, data: CS.UnityTSGame.JSOPData): void;
}

declare class BaseTimer {
    static _mid: number;
}

/**
* @private
*/
declare class CallLater {
    static I: CallLater;
    /**@private */
    protected _pool: Array<any>;
    /**@private */
    protected _map: any;
    /**@private */
    protected _laters: Array<any>;
    constructor();
    /**
     * @internal
     * 帧循环处理函数。
     */
    protected _update(): void;
    /** @private */
    protected _getHandler(caller: any, method: Function): any;
    /**
     * 延迟执行。
     * @param	caller 执行域(this)。
     * @param	method 定时器回调函数。
     * @param	args 回调参数。
     */
    callLater(caller: any, method: Function, args?: any[]): void;
    /**
     * 立即执行 callLater 。
     * @param	caller 执行域(this)。
     * @param	method 定时器回调函数。
     */
    runCallLater(caller: any, method: Function): void;
}

/**
 * Timer 是时钟管理类。它是一个单例，不要手动实例化此类，应该通过 UTGEngine.timer 访问。
 */
declare class Timer {
    /**
     * @private
     */
    private static _pool;
    /**
     * 是否可暂停。
     */
    protected _canPause: boolean;
    /**
     * 时针缩放。
     */
    protected scale: number;
    /**
     * 当前帧开始的时间。
     */
    protected currTimer: number;
    /**
     * 当前的帧数。
     */
    protected currFrame: number;
    /**
     * @private
     */
    protected _delta: number;
    /**
     * @private
     */
    protected _lastTimer: number;
    /**
     * @private
     */
    protected _map: Array<any>;
    /**
     * @private
     */
    protected _handlers: Array<TimerHandler>;
    /**
     * @private
     */
    protected _temp: Array<TimerHandler>;
    /**
     * @private
     */
    protected _count: number;
    /**
     * 创建定时器实例
     * @param canPause 是否可暂停 true/false
     */
    constructor(canPause?: boolean);
    /**
     * 上一帧到现在已逝去的时间，单位：毫秒
     */
    get delta(): number;
    /**
     * @internal
     * 帧循环处理函数。
     */
    update(): void;
    /** @private */
    protected _clearHandlers(): void;
    /** @private */
    protected _recoverHandler(handler: TimerHandler): void;
    /** @internal */
    protected _create(useFrame: boolean, repeat: boolean, delay: number, caller: any, method: Function, args: any[], coverBefore: boolean): TimerHandler;
    /** @private */
    protected _indexHandler(handler: TimerHandler): void;
    /**
     * 定时执行一次。
     * @param delay 延迟时间(单位为毫秒)。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     * @param args 回调参数。
     * @param coverBefore 是否覆盖之前的延迟执行，默认为 true 。
     */
    once(delay: number, caller: any, method: Function, args?: any[], coverBefore?: boolean): void;
    /**
     * 定时重复执行。
     * @param delay 间隔时间(单位毫秒)。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     * @param args 回调参数。
     * @param coverBefore 是否覆盖之前的延迟执行，默认为 true 。
     * @param jumpFrame 时钟是否跳帧。基于时间的循环回调，单位时间间隔内，如能执行多次回调，出于性能考虑，引擎默认只执行一次，设置jumpFrame=true后，则回调会连续执行多次
     */
    loop(delay: number, caller: any, method: Function, args?: any[], coverBefore?: boolean, jumpFrame?: boolean): void;
    /**
     * 定时执行一次(基于帧率)。
     * @param delay 延迟几帧(单位为帧)。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     * @param args 回调参数。
     * @param coverBefore 是否覆盖之前的延迟执行，默认为 true 。
     */
    frameOnce(delay: number, caller: any, method: Function, args?: any[], coverBefore?: boolean): void;
    /**
     * 定时重复执行(基于帧率)。
     * @param delay 间隔几帧(单位为帧)。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     * @param args 回调参数。
     * @param coverBefore 是否覆盖之前的延迟执行，默认为 true 。
     */
    frameLoop(delay: number, caller: any, method: Function, args?: any[], coverBefore?: boolean): void;
    /**
     * 返回统计信息。
     */
    toString(): string;
    /**
     * 清理定时器。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     */
    clear(caller: any, method: Function): void;
    /**
     * 清理对象身上的所有定时器。
     * @param caller 执行域(this)。
     */
    clearAll(caller: any): void;
    /**
     * @private
     */
    protected _getHandler(caller: any, method: Function): TimerHandler;
    /**
     * 延迟执行。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     * @param args 回调参数。
     */
    callLater(caller: any, method: Function, args?: any[]): void;
    /**
     * 立即执行 callLater 。
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     */
    runCallLater(caller: any, method: Function): void;
    /**
     * 立即提前执行定时器，执行之后从队列中删除
     * @param caller 执行域(this)。
     * @param method 定时器回调函数。
     */
    runTimer(caller: any, method: Function): void;
    /**
     * 暂停时钟
     */
    pause(): void;
    /**
     * 恢复时钟
     */
    resume(): void;
}
/** @private */
declare class TimerHandler {
    userFrame: boolean;
    repeat: boolean;
    exeTime: number;
    delay: number;
    jumpFrame: boolean;
    key: number;
    caller: any;
    method: Function;
    args: Array<any>;
    clear(): void;
    run(withClear: boolean): void;
}


/**
* UTGEase 类定义了缓动函数，以便实现 UTGTween 动画的缓动效果。
*/
declare class UTGEase {
    /**@private */
    private static HALF_PI;
    /**@private */
    private static PI2;
    /**
     * 定义无加速持续运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static linearNone(t: number, b: number, c: number, d: number): number;
    /**
     * 定义无加速持续运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static linearIn(t: number, b: number, c: number, d: number): number;
    /**
     * 定义无加速持续运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static linearInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 定义无加速持续运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static linearOut(t: number, b: number, c: number, d: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * 它的运动是类似一个球落向地板又弹起后，几次逐渐减小的回弹运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static bounceIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * 它的运动是类似一个球落向地板又弹起后，几次逐渐减小的回弹运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static bounceInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * 它的运动是类似一个球落向地板又弹起后，几次逐渐减小的回弹运动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static bounceOut(t: number, b: number, c: number, d: number): number;
    /**
     * 开始时往后运动，然后反向朝目标移动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @param	s 指定过冲量，此处数值越大，过冲越大。
     * @return 指定时间的插补属性的值。
     */
    static backIn(t: number, b: number, c: number, d: number, s?: number): number;
    /**
     * 开始运动时是向后跟踪，再倒转方向并朝目标移动，稍微过冲目标，然后再次倒转方向，回来朝目标移动。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @param	s 指定过冲量，此处数值越大，过冲越大。
     * @return 指定时间的插补属性的值。
     */
    static backInOut(t: number, b: number, c: number, d: number, s?: number): number;
    /**
     * 开始运动时是朝目标移动，稍微过冲，再倒转方向回来朝着目标。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @param	s 指定过冲量，此处数值越大，过冲越大。
     * @return 指定时间的插补属性的值。
     */
    static backOut(t: number, b: number, c: number, d: number, s?: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * 其中的运动由按照指数方式衰减的正弦波来定义。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @param	a 指定正弦波的幅度。
     * @param	p 指定正弦波的周期。
     * @return 指定时间的插补属性的值。
     */
    static elasticIn(t: number, b: number, c: number, d: number, a?: number, p?: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * 其中的运动由按照指数方式衰减的正弦波来定义。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @param	a 指定正弦波的幅度。
     * @param	p 指定正弦波的周期。
     * @return 指定时间的插补属性的值。
     */
    static elasticInOut(t: number, b: number, c: number, d: number, a?: number, p?: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * 其中的运动由按照指数方式衰减的正弦波来定义。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @param	a 指定正弦波的幅度。
     * @param	p 指定正弦波的周期。
     * @return 指定时间的插补属性的值。
     */
    static elasticOut(t: number, b: number, c: number, d: number, a?: number, p?: number): number;
    /**
     * 以零速率开始运动，然后在执行时加快运动速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static strongIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static strongInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static strongOut(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * Sine 缓动方程中的运动加速度小于 Quad 方程中的运动加速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static sineInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以零速率开始运动，然后在执行时加快运动速度。
     * Sine 缓动方程中的运动加速度小于 Quad 方程中的运动加速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static sineIn(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * Sine 缓动方程中的运动加速度小于 Quad 方程中的运动加速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static sineOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以零速率开始运动，然后在执行时加快运动速度。
     * Quint 缓动方程的运动加速大于 Quart 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quintIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * Quint 缓动方程的运动加速大于 Quart 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quintInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * Quint 缓动方程的运动加速大于 Quart 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quintOut(t: number, b: number, c: number, d: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * Quart 缓动方程的运动加速大于 Cubic 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quartIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * Quart 缓动方程的运动加速大于 Cubic 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quartInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * Quart 缓动方程的运动加速大于 Cubic 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quartOut(t: number, b: number, c: number, d: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * Cubic 缓动方程的运动加速大于 Quad 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static cubicIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * Cubic 缓动方程的运动加速大于 Quad 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static cubicInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * Cubic 缓动方程的运动加速大于 Quad 缓动方程。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static cubicOut(t: number, b: number, c: number, d: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * Quad 缓动方程中的运动加速度等于 100% 缓动的时间轴补间的运动加速度，并且显著小于 Cubic 缓动方程中的运动加速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quadIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * Quad 缓动方程中的运动加速度等于 100% 缓动的时间轴补间的运动加速度，并且显著小于 Cubic 缓动方程中的运动加速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quadInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * Quad 缓动方程中的运动加速度等于 100% 缓动的时间轴补间的运动加速度，并且显著小于 Cubic 缓动方程中的运动加速度。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static quadOut(t: number, b: number, c: number, d: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * 其中每个时间间隔是剩余距离减去一个固定比例部分。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static expoIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * 其中每个时间间隔是剩余距离减去一个固定比例部分。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static expoInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * 其中每个时间间隔是剩余距离减去一个固定比例部分。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static expoOut(t: number, b: number, c: number, d: number): number;
    /**
     * 方法以零速率开始运动，然后在执行时加快运动速度。
     * 缓动方程的运动加速会产生突然的速率变化。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static circIn(t: number, b: number, c: number, d: number): number;
    /**
     * 开始运动时速率为零，先对运动进行加速，再减速直到速率为零。
     * 缓动方程的运动加速会产生突然的速率变化。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static circInOut(t: number, b: number, c: number, d: number): number;
    /**
     * 以较快速度开始运动，然后在执行时减慢运动速度，直至速率为零。
     * 缓动方程的运动加速会产生突然的速率变化。
     * @param	t 指定当前时间，介于 0 和持续时间之间（包括二者）。
     * @param	b 指定动画属性的初始值。
     * @param	c 指定动画属性的更改总计。
     * @param	d 指定运动的持续时间。
     * @return 指定时间的插补属性的值。
     */
    static circOut(t: number, b: number, c: number, d: number): number;
}

/**
 * UTGTween  是一个缓动类。使用此类能够实现对目标对象属性的渐变。
 */
declare class UTGTween {
    /**
     * @private
     */
    private static tweenMap;
    /**
     * @private
     */
    private _complete;
    /**
     * @private
     */
    private _target;
    /**
     * @private
     */
    private _ease;
    /**
     * @private
     */
    private _props;
    /**
     * @private
     */
    private _duration;
    /**
     * @private
     */
    private _delay;
    /**
     * @private
     */
    private _startTimer;
    /**
     * @private
     */
    private _usedTimer;
    /**
     * @private
     */
    private _usedPool;
    /**
     * @private
     */
    private _delayParam;
    /**
     * @private 唯一标识，TimeLintLite用到
     */
    gid: number;
    /**
     * 更新回调，缓动数值发生变化时，回调变化的值
     */
    update: Handler;
    /**
     * 重播次数，如果repeat=0，则表示无限循环播放
     */
    repeat: number;
    /**
     * 当前播放次数
     */
    private _count;
    constructor();
    /**
     * 缓动对象的props属性到目标值。
     * @param	target 目标对象(即将更改属性值的对象)。
     * @param	props 变化的属性列表，比如{x:100,y:20,ease:Ease.backOut,complete:Handler.create(this,onComplete),update:new Handler(this,onComplete)}。
     * @param	duration 花费的时间，单位毫秒。
     * @param	ease 缓动类型，默认为匀速运动。
     * @param	complete 结束回调函数。
     * @param	delay 延迟执行时间。
     * @param	coverBefore 是否覆盖之前的缓动。
     * @param	autoRecover 是否自动回收，默认为true，缓动结束之后自动回收到对象池。
     * @return	返回Tween对象。
     */
    static to(target: any, props: any, duration: number, ease?: Function | null, complete?: Handler | null, delay?: number, coverBefore?: boolean, autoRecover?: boolean): UTGTween;
    /**
     * 从props属性，缓动到当前状态。
     * @param	target 目标对象(即将更改属性值的对象)。
     * @param	props 变化的属性列表，比如{x:100,y:20,ease:Ease.backOut,complete:Handler.create(this,onComplete),update:new Handler(this,onComplete)}。
     * @param	duration 花费的时间，单位毫秒。
     * @param	ease 缓动类型，默认为匀速运动。
     * @param	complete 结束回调函数。
     * @param	delay 延迟执行时间。
     * @param	coverBefore 是否覆盖之前的缓动。
     * @param	autoRecover 是否自动回收，默认为true，缓动结束之后自动回收到对象池。
     * @return	返回Tween对象。
     */
    static from(target: any, props: any, duration: number, ease?: Function, complete?: Handler, delay?: number, coverBefore?: boolean, autoRecover?: boolean): UTGTween;
    /**
     * 缓动对象的props属性到目标值。
     * @param	target 目标对象(即将更改属性值的对象)。
     * @param	props 变化的属性列表，比如{x:100,y:20,ease:Ease.backOut,complete:Handler.create(this,onComplete),update:new Handler(this,onComplete)}。
     * @param	duration 花费的时间，单位毫秒。
     * @param	ease 缓动类型，默认为匀速运动。
     * @param	complete 结束回调函数。
     * @param	delay 延迟执行时间。
     * @param	coverBefore 是否覆盖之前的缓动。
     * @return	返回Tween对象。
     */
    to(target: any, props: any, duration: number, ease?: Function, complete?: Handler, delay?: number, coverBefore?: boolean): UTGTween;
    /**
     * 从props属性，缓动到当前状态。
     * @param	target 目标对象(即将更改属性值的对象)。
     * @param	props 变化的属性列表，比如{x:100,y:20,ease:Ease.backOut,complete:Handler.create(this,onComplete),update:new Handler(this,onComplete)}。
     * @param	duration 花费的时间，单位毫秒。
     * @param	ease 缓动类型，默认为匀速运动。
     * @param	complete 结束回调函数。
     * @param	delay 延迟执行时间。
     * @param	coverBefore 是否覆盖之前的缓动。
     * @return	返回Tween对象。
     */
    from(target: any, props: any, duration: number, ease?: Function | null, complete?: Handler | null, delay?: number, coverBefore?: boolean): UTGTween;
    /** @internal */
    protected _create(target: any, props: any, duration: number, ease?: Function, complete?: Handler, delay?: number, coverBefore?: boolean, isTo?: boolean, usePool?: boolean, runNow?: boolean): this;
    /** @internal */
    private firstStart;
    /** @internal */
    protected _initProps(target: any, props: any, isTo?: boolean): void;
    /** @internal */
    protected _beginLoop(): void;
    /**执行缓动**/
    protected _doEase(): void;
    /** @internal */
    protected _updateEase(time: number): void;
    /**设置当前执行比例**/
    set progress(v: number);
    /**
     * 立即结束缓动并到终点。
     */
    complete(): void;
    /**
     * 暂停缓动，可以通过resume或restart重新开始。
     */
    pause(): void;
    /**
     * 设置开始时间。
     * @param	startTime 开始时间。
     */
    setStartTime(startTime: number): void;
    /**
     * 清理指定目标对象上的所有缓动。
     * @param	target 目标对象。
     */
    static clearAll(target: any): void;
    /**
     * 清理某个缓动。
     * @param	tween 缓动对象。
     */
    static clear(tween: UTGTween): void;
    /**
     * 停止并清理当前缓动。
     */
    clear(): void;
    /**
     * @internal
     */
    protected _clear(): void;
    /** 回收到对象池。*/
    recover(): void;
    /**
     * @internal
     */
    private _remove;
    /**
     * 重新开始暂停的缓动。
     */
    restart(): void;
    /**
     * 恢复暂停的缓动。
     */
    resume(): void;
    /**
     * @internal
     */
    private static easeNone;
}

/**
 * 界面基类
 */
declare class UTGBaseView {
    /**@internal */
    protected _pkgName: string;
    /**@internal */
    protected _uiName: string;
    /**@internal */
    protected _view: CS.FairyGUI.GComponent;
    /**@internal */
    protected _fullScreen: boolean;
    /**
     *  构造方法
     * @param pkgName         UI包名
     * @param uiName          UI组件名
     * @param fullScreen      是否全屏
     */
    constructor(pkgName: string, uiName: string, fullScreen?: boolean);
    /**@internal */
    protected _loadPackage(): Promise<void>;
    protected _onUILoaded(): void;
    /**
     * 添加到舞台时触发
     * @param context 上下文
     */
    protected _onAddedToStage(context: CS.FairyGUI.EventContext): void;
    /**
     * 移除出舞台时触发，一般重写此方法，以注销该界面所有关联的事件侦听等
     * @param context 上下文
     */
    protected _onRemovedFromStage(context: CS.FairyGUI.EventContext): void;
    /**
     * 界面是否存在
     * @returns true/false
     */
    existView(): boolean;
    /**
     * 界面是否可见
     */
    get visible(): boolean;
    /**
     * 设置界面是否可见
     */
    set visible(b: boolean);
    /**
     * UI包名
     */
    get pkbName(): string;
    /**
     * UI组件名
     */
    get uiName(): string;
    /**
     * 销毁UI
     * @param cleanup 是否清理 true-销毁界面并卸载该界面所属的包 false-仅销毁界面
     */
    destroy(cleanup?: boolean): void;
}

declare class UTGUIHelper {
    /**@internal */
    protected static _staticUIPkgs: {
        [pkg: string]: boolean;
    };
    /**
     * iOS刘海屏顶部偏移
     */
    static screenTopOffsetY: number;
    /**
     * iOS刘海屏底部偏移
     */
    static screenBottomOffsetY: number;
    /**
     * 添加常驻UI包名，常驻UI包在调用UTGBaseView.destroy(true)时不会被卸载
     * @param pkgNames UI包名
     */
    static addStaticPkgs(pkgNames: string[]): void;
    /**
     * 是否是常驻UI包
     * @param name UI包名
     * @returns true/false
     */
    static isStaticPkg(name: string): boolean;
    /**
     * 删除常驻UI包名
     * @param pkgNames UI包名
     */
    static removeStaticPkgs(pkgNames: string[]): void;
    /**
     * 删除所有常驻UI包名
     */
    static clearStaticPkgs(): void;
    /**
     * 销毁对象，将对象的所有属性都删除
     * @param obj object
     */
    static cleanupObject(obj: object): void;
    /**
     * 销毁UI组件及其所有子组件
     * @param view UI组件
     */
    static cleanupView(view: CS.FairyGUI.GComponent): void;
    /**
     * 界面创建前会调用此方法，外部可重写此方法
     * [建议方案]
     * 1、全屏透明遮挡
     * 2、全屏遮挡并显示界面加载进度条或者转圈圈
     */
    static showUICreatingView(): void;
    /**
     * 界面创建并加载完毕会调用此方法，外部可重写此方法
     * 一般流程为把UTGUIHelper.showUICreatingView()创建的内容销毁
     */
    static hideUICreatingView(): void;
    /**@internal */
    protected static _cleanCom(view: any): void;
}

/**
 * Handler 是事件处理器类。
 * 推荐使用 Handler.create() 方法从对象池创建，减少对象创建消耗。创建的 Handler 对象不再使用后，可以使用 Handler.recover() 将其回收到对象池，回收后不要再使用此对象，否则会导致不可预料的错误。
 * 注意：由于鼠标事件也用本对象池，不正确的回收及调用，可能会影响鼠标事件的执行。
 */
declare class Handler {
    /**@private handler对象池*/
    protected static _pool: Array<Handler>;
    /**@private */
    protected static _gid: number;
    /**@private */
    protected _id: number;
    /** 表示是否只执行一次。如果为true，回调后执行recover()进行回收，回收后会被再利用，默认为false 。*/
    once: boolean;
    /** 执行域(this)。*/
    caller: any;
    /** 处理方法。*/
    method: Function;
    /** 参数。*/
    args: any[];
    /**
     * 根据指定的属性值，创建一个 <code>Handler</code> 类的实例。
     * @param	caller 执行域。
     * @param	method 处理函数。
     * @param	args 函数参数。
     * @param	once 是否只执行一次。
     */
    constructor(caller?: any, method?: Function, args?: any[], once?: boolean);
    /**
     * 设置此对象的指定属性值。
     * @param	caller 执行域(this)。
     * @param	method 回调方法。
     * @param	args 携带的参数。
     * @param	once 是否只执行一次，如果为true，执行后执行recover()进行回收。
     * @return  返回 handler 本身。
     */
    setTo(caller?: any, method?: Function, args?: any[], once?: boolean): Handler;
    /**
     * 执行处理器。
     */
    run(): any;
    /**
     * 执行处理器，并携带额外数据。
     * @param	data 附加的回调数据，可以是单数据或者Array(作为多参)。
     */
    runWith(data: any): any;
    /**
     * 清理对象引用。
     */
    clear(): Handler;
    /**
     * 清理并回收到 Handler 对象池内。
     */
    recover(): void;
    /**
     * 从对象池内创建一个Handler，默认会执行一次并立即回收，如果不需要自动回收，设置once参数为false。
     * @param	caller 执行域(this)。
     * @param	method 回调方法。
     * @param	args 携带的参数。
     * @param	once 是否只执行一次，如果为true，回调后执行recover()进行回收，默认为true。
     * @return  返回创建的handler实例。
     */
    static create(caller?: any, method?: Function, args?: any[], once?: boolean): Handler;
}

declare class OSUtil {
    static getRuntimePlatform(): CS.UnityEngine.RuntimePlatform;
    static get isAndroid(): boolean;
    static get isIOS(): boolean;
    static get isAndroidOrIOS(): boolean;
    static get isDevelopMode(): boolean;
    static get isDevelopNoSDKMode(): boolean;
    static get gamePlatform(): GAME_PLATFORM_TYPE;
    static getLocalStoragePath(): string;
    static getDeviceId(): string;
    static deleteFile(path: string): number;
    static reportException(name: string, message: string, stackTrace?: string): void;
}

/**
 * Pool 是对象池类，用于对象的存储、重复使用。
 * 合理使用对象池，可以有效减少对象创建的开销，避免频繁的垃圾回收，从而优化游戏流畅度。
 */
declare class Pool {
    /**@private */
    private static _CLSID;
    /**@private */
    private static POOLSIGN;
    /**@private  对象存放池。*/
    private static _poolDic;
    /**
     * 根据对象类型标识字符，获取对象池。
     * @param sign 对象类型标识字符。
     * @return 对象池。
     */
    static getPoolBySign(sign: string): any[];
    /**
     * 清除对象池的对象。
     * @param sign 对象类型标识字符。
     */
    static clearBySign(sign: string): void;
    /**
     * 将对象放到对应类型标识的对象池中。
     * @param sign 对象类型标识字符。
     * @param item 对象。
     */
    static recover(sign: string, item: any): void;
    /**
     * 根据类名进行回收，如果类有类名才进行回收，没有则不回收
     * @param	instance 类的具体实例
     */
    static recoverByClass(instance: any): void;
    /**
     * 返回类的唯一标识
     */
    private static _getClassSign;
    /**
     * 根据类名回收类的实例
     * @param	instance 类的具体实例
     */
    static createByClass<T>(cls: new () => T): T;
    /**
     * <p>根据传入的对象类型标识字符，获取对象池中此类型标识的一个对象实例。</p>
     * <p>当对象池中无此类型标识的对象时，则根据传入的类型，创建一个新的对象返回。</p>
     * @param sign 对象类型标识字符。
     * @param cls 用于创建该类型对象的类。
     * @return 此类型标识的一个对象。
     */
    static getItemByClass<T>(sign: string, cls: new () => T): T;
    /**
     * <p>根据传入的对象类型标识字符，获取对象池中此类型标识的一个对象实例。</p>
     * <p>当对象池中无此类型标识的对象时，则使用传入的创建此类型对象的函数，新建一个对象返回。</p>
     * @param sign 对象类型标识字符。
     * @param createFun 用于创建该类型对象的方法。
     * @param caller this对象
     * @return 此类型标识的一个对象。
     */
    static getItemByCreateFun(sign: string, createFun: Function, caller?: any): any;
    /**
     * 根据传入的对象类型标识字符，获取对象池中已存储的此类型的一个对象，如果对象池中无此类型的对象，则返回 null 。
     * @param sign 对象类型标识字符。
     * @return 对象池中此类型的一个对象，如果对象池中无此类型的对象，则返回 null 。
     */
    static getItem(sign: string): any;
}

declare class UTG3DTool {
    /**
     * 指定对象是否为空
     * @param obj 对象
     * @returns true/false
     */
    static isNull(obj: CS.UnityEngine.GameObject): boolean;
    /**
     * 指定对象是否为空
     * @param obj 对象
     * @returns true/false
     */
    static objectIsNull(obj: CS.UnityEngine.GameObject): boolean;
    /**
     * 销毁指定对象下的所有子对象
     * @param obj 父对象
     */
    static removeChildren(obj: CS.UnityEngine.GameObject): void;
    /**
     * 销毁指定对象下指定名称的子对象
     * @param obj   父对象
     * @param name  子对象名称
     */
    static removeChildByName(obj: CS.UnityEngine.GameObject, name: string): void;
    /**
     * 销毁指定对象下指定索引的子对象
     * @param obj       父对象
     * @param index     索引
     */
    static removeChildAt(obj: CS.UnityEngine.GameObject, index: number): void;
    /**
     * 设置对象层级
     * @param gameObject    对象
     * @param layer         层级
     */
    static setObjectLayer(gameObject: CS.UnityEngine.GameObject, layer: number): void;
    /**
     * 设置对象层级
     * @param gameObject    对象
     * @param layer         层级名称
     */
    static setObjectLayerByName(gameObject: CS.UnityEngine.GameObject, layer: string): void;
    /**
     * 设置对象颜色
     * @param gameObject    对象
     * @param color         颜色
     */
    static setObjectColorX(gameObject: CS.UnityEngine.GameObject, color: CS.UnityEngine.Color): void;
    /**
     * 设置对象颜色
     * @param gameObject    对象
     * @param r             红色分量
     * @param g             绿色分量
     * @param b             蓝色分量
     * @param a             透明度分量
     */
    static setObjectColor(gameObject: CS.UnityEngine.GameObject, r?: number, g?: number, b?: number, a?: number): void;
}

declare class UTGBase64 {
    /** private */
    private static b64ch;
    /** private */
    private static b64chs;
    /** private */
    private static b64tab;
    /** private */
    private static b64re;
    /** private */
    private static _fromCC;
    /** private */
    private static re_btou;
    /** private */
    private static re_utob;
    /**
     * converts a UTF-8-encoded string to a Base64 string.
     * @param {string} src UTF-8-encoded string
     * @param {boolean} [urlsafe] if `true` make the result URL-safe
     * @returns {string} Base64 string
     */
    static encode(src: string, urlsafe?: boolean): string;
    /**
     * converts a Base64 string to a UTF-8 string.
     * @param {String} src Base64 string.  Both normal and URL-safe are supported
     * @returns {string} UTF-8 string
     */
    static decode(src: string): string;
    /**
     * polyfill version of `btoa`
     */
    static btoaPolyfill(bin: string): string;
    /**
     * polyfill version of `atob`
     */
    static atobPolyfill(asc: any): string;
    /**
     * should have been internal use only.
     * @param {string} src UTF-16 string
     * @returns {string} UTF-8 string
     */
    private static _btou;
    /**
     * should have been internal use only.
     * @param {string} src UTF-8 string
     * @returns {string} UTF-16 string
     */
    private static _utob;
    private static _mkUriSafe;
    private static _unURI;
    private static _tidyB64;
    private static cb_btou;
    private static cb_utob;
}

/**
 * @private
 * 计算贝塞尔曲线的工具类。
 */
declare class UTGBezier {
    /**
     * 工具类单例
     */
    static I: UTGBezier;
    /** @private */
    private _controlPoints;
    /** @private */
    private _calFun;
    /** @private */
    private _switchPoint;
    /**
     * 计算二次贝塞尔点。
     */
    getPoint2(t: number, rst: any[]): void;
    /**
     * 计算三次贝塞尔点
     */
    getPoint3(t: number, rst: any[]): void;
    /**
     * 计算贝塞尔点序列
     */
    insertPoints(count: number, rst: any[]): void;
    /**
     * 获取贝塞尔曲线上的点。
     * @param pList 控制点[x0,y0,x1,y1...]
     * @param inSertCount 每次曲线的插值数量
     */
    getBezierPoints(pList: any[], inSertCount?: number, count?: number): any[];
}

declare class UTGBitUtil {
    /**
     * 将操作数tag的第index位置为0或1，并返回变更后的操作数
     * @param tag 操作数
     * @param index 第几位，从1开始
     * @param isTrue true/false
     * @return 改变后的操作数
     */
    static setMask(tag: number, index: number, isTrue: boolean): number;
    /**
     * 判断操作数tag的第index位是否为1
     * @param tag 操作数
     * @param index  第几位，从1开始
     * @return true/false
     */
    static maskIsTrue(tag: number, index: number): boolean;
}

declare class UTGMD5 {
    /**
     * Add integers, wrapping at 2^32.
     * This uses 16-bit operations internally to work around bugs in interpreters.
     *
     * @param {number} x First integer
     * @param {number} y Second integer
     * @returns {number} Sum
     */
    protected static safeAdd(x: number, y: number): number;
    /**
     * Bitwise rotate a 32-bit number to the left.
     *
     * @param {number} num 32-bit number
     * @param {number} cnt Rotation count
     * @returns {number} Rotated number
     */
    protected static bitRotateLeft(num: number, cnt: number): number;
    /**
     * Basic operation the algorithm uses.
     *
     * @param {number} q q
     * @param {number} a a
     * @param {number} b b
     * @param {number} x x
     * @param {number} s s
     * @param {number} t t
     * @returns {number} Result
     */
    protected static md5cmn(q: number, a: number, b: number, x: number, s: number, t: number): number;
    /**
     * Basic operation the algorithm uses.
     *
     * @param {number} a a
     * @param {number} b b
     * @param {number} c c
     * @param {number} d d
     * @param {number} x x
     * @param {number} s s
     * @param {number} t t
     * @returns {number} Result
     */
    protected static md5ff(a: number, b: number, c: number, d: number, x: number, s: number, t: number): number;
    /**
     * Basic operation the algorithm uses.
     *
     * @param {number} a a
     * @param {number} b b
     * @param {number} c c
     * @param {number} d d
     * @param {number} x x
     * @param {number} s s
     * @param {number} t t
     * @returns {number} Result
     */
    protected static md5gg(a: number, b: number, c: number, d: number, x: number, s: number, t: number): number;
    /**
     * Basic operation the algorithm uses.
     *
     * @param {number} a a
     * @param {number} b b
     * @param {number} c c
     * @param {number} d d
     * @param {number} x x
     * @param {number} s s
     * @param {number} t t
     * @returns {number} Result
     */
    protected static md5hh(a: number, b: number, c: number, d: number, x: number, s: number, t: number): number;
    /**
     * Basic operation the algorithm uses.
     *
     * @param {number} a a
     * @param {number} b b
     * @param {number} c c
     * @param {number} d d
     * @param {number} x x
     * @param {number} s s
     * @param {number} t t
     * @returns {number} Result
     */
    protected static md5ii(a: number, b: number, c: number, d: number, x: number, s: number, t: number): number;
    /**
     * Calculate the MD5 of an array of little-endian words, and a bit length.
     *
     * @param {Array} x Array of little-endian words
     * @param {number} len Bit length
     * @returns {Array<number>} MD5 Array
     */
    protected static binlMD5(x: Array<number>, len: number): Array<number>;
    /**
     * Convert an array of little-endian words to a string
     *
     * @param {Array<number>} input MD5 Array
     * @returns {string} MD5 string
     */
    protected static binl2rstr(input: Array<number>): string;
    /**
     * Convert a raw string to an array of little-endian words
     * Characters >255 have their high-byte silently ignored.
     *
     * @param {string} input Raw input string
     * @returns {Array<number>} Array of little-endian words
     */
    protected static rstr2binl(input: string): Array<number>;
    /**
     * Calculate the MD5 of a raw string
     *
     * @param {string} s Input string
     * @returns {string} Raw MD5 string
     */
    protected static rstrMD5(s: string): string;
    /**
     * Calculates the HMAC-MD5 of a key and some data (raw strings)
     *
     * @param {string} key HMAC key
     * @param {string} data Raw input string
     * @returns {string} Raw MD5 string
     */
    protected static rstrHMACMD5(key: string, data: string): string;
    /**
     * Convert a raw string to a hex string
     *
     * @param {string} input Raw input string
     * @returns {string} Hex encoded string
     */
    protected static rstr2hex(input: string): string;
    /**
     * Encode a string as UTF-8
     *
     * @param {string} input Input string
     * @returns {string} UTF8 string
     */
    protected static str2rstrUTF8(input: string): string;
    /**
     * Encodes input string as raw MD5 string
     *
     * @param {string} s Input string
     * @returns {string} Raw MD5 string
     */
    protected static rawMD5(s: string): string;
    /**
     * Encodes input string as Hex encoded string
     *
     * @param {string} s Input string
     * @returns {string} Hex encoded string
     */
    protected static hexMD5(s: string): string;
    /**
     * Calculates the raw HMAC-MD5 for the given key and data
     *
     * @param {string} k HMAC key
     * @param {string} d Input string
     * @returns {string} Raw MD5 string
     */
    protected static rawHMACMD5(k: string, d: string): string;
    /**
     * Calculates the Hex encoded HMAC-MD5 for the given key and data
     *
     * @param {string} k HMAC key
     * @param {string} d Input string
     * @returns {string} Raw MD5 string
     */
    protected static hexHMACMD5(k: any, d: any): string;
    /**
     * Calculates MD5 value for a given string.
     * If a key is provided, calculates the HMAC-MD5 value.
     * Returns a Hex encoded string unless the raw argument is given.
     *
     * @param {string} string Input string
     * @param {string} [key] HMAC key
     * @param {boolean} [raw] Raw output switch
     * @returns {string} MD5 output
     */
    static md5(input: string, key?: string, raw?: boolean): string;
}

declare class UTGTimeUtil {
    /**
     * 计算两个时间之间相差多少天(日期不同都算一天，比如2023-08-10 23:59:00和2023-08-11 00:00:01相差1天)
     * @param time1 number：时间戳(ms)，string：标准日期格式（服务器所在时区时间），如2023-04-03 08:30:06
     * @param time2 number：时间戳(ms)，string：标准日期格式（服务器所在时区时间），如2023-04-03 06:03:02
     * @returns 相差的天数(当time1比time2小的时候返回非负数，当time1比time2大的时候返回非正数)
     */
    static diffDays(time1: number | string, time2: number | string, timeZone: string): number;
    /**
     * 计算time2是在time1之后的第几天(日期不同都算一天，比如2023-08-11 00:00:01是在2023-08-10 23:59:00之后的第1天)
     * @param time1 number：时间戳(ms)，string：标准日期格式，如2023-04-03 08:30:06
     * @param time2 number：时间戳(ms)，string：标准日期格式，如2023-04-05 06:03:02
     * @returns 天数(当time1比time2小的时候返回非负数，当time1比time2大的时候返回非正数)
     */
    static nowDay(time1: number | string, time2: number | string, timeZone: string): number;
    /**
     * 格式化日程时间段 例如：00:00-24:00
     * @param beginTime 日程起始时间
     * @param endTime 日程结束时间
     * @return 格式化的时间
     */
    static formatTime2Time(beginTime: number, endTime: number): string;
    /**
     * 获取某一天的N天后的某个时间点的时间戳(ms)
     * @param dayTime       时间戳
     * @param nDays         多少天
     * @param time          多少毫秒
     * @param timeZone      时区
     * @returns 时间戳
     */
    static getNextNDaySomeTime(dayTime: number, nDays: number, time: number | string, timeZone: string): number;
}

/**
 * Utils 是工具类。
 */
declare class Utils {
    /**@private */
    protected static _pi: number;
    /**@private */
    protected static _pi2: number;
    /**@private */
    protected static _gid: number;
    /**@private */
    protected static _extReg: RegExp;
    /**
     * 角度转弧度。
     * @param	angle 角度值。
     * @return	返回弧度值。
     */
    static toRadian(angle: number): number;
    /**
     * 弧度转换为角度。
     * @param	radian 弧度值。
     * @return	返回角度值。
     */
    static toAngle(radian: number): number;
    /**
     * 将传入的 uint 类型颜色值转换为字符串型颜色值。
     * @param color 颜色值。
     * @return 字符串型颜色值。
     */
    static toHexColor(color: number): string;
    /**获取一个全局唯一ID。*/
    static getGID(): number;
    /**
     * @private
     * <p>连接数组。和array的concat相比，此方法不创建新对象</p>
     * <b>注意：</b>若 参数 a 不为空，则会改变参数 source 的值为连接后的数组。
     * @param	source 待连接的数组目标对象。
     * @param	array 待连接的数组对象。
     * @return 连接后的数组。
     */
    static concatArray(source: Array<any>, array: Array<any>): Array<any>;
    /**
     * @private
     * 清空数组对象。
     * @param	array 数组。
     * @return	清空后的 array 对象。
     */
    static clearArray(array: Array<any>): Array<any>;
    /**
     * @private
     * 清空source数组，复制array数组的值。
     * @param	source 需要赋值的数组。
     * @param	array 新的数组值。
     * @return 	复制后的数据 source 。
     */
    static copyArray(source: Array<any>, array: Array<any>): Array<any>;
    /**
     * 给传入的函数绑定作用域，返回绑定后的函数。
     * @param	fun 函数对象。
     * @param	scope 函数作用域。
     * @return 绑定后的函数。
     */
    static bind(fun: Function, scope: any): any;
    /**
     * @private
     * 对传入的数组列表，根据子项的属性 Z 值进行重新排序。返回是否已重新排序的 Boolean 值。
     * @param	array 子对象数组。
     * @return	Boolean 值，表示是否已重新排序。
     */
    static updateOrder(array: Array<any>): boolean;
    /**
     * @private
     * 批量移动点坐标。
     * @param points 坐标列表。
     * @param x x轴偏移量。
     * @param y y轴偏移量。
     */
    static transPointList(points: Array<number>, x: number, y: number): void;
    /**
     * 解析一个字符串，并返回一个整数。和JS原生的parseInt不同：如果str为空或者非数字，原生返回NaN，这里返回0。
     * @param	str		要被解析的字符串。
     * @param	radix	表示要解析的数字的基数。默认值为0，表示10进制，其他值介于 2 ~ 36 之间。如果它以 “0x” 或 “0X” 开头，将以 16 为基数。如果该参数不在上述范围内，则此方法返回 0。
     * @return	返回解析后的数字。
     */
    static parseInt(str: string, radix?: number): number;
    /**@private */
    static getFileExtension(path: any): string;
    /**
     * @private
     * 为兼容平台后缀名不能用的特殊兼容TODO：
     */
    static getFilecompatibleExtension(path: any): string;
}
