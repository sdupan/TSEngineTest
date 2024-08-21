using UnityEngine.Networking;
using System;
using System.IO;
using System.Threading;
using UnityEngine;
using System.Collections.Generic;

public class LXYDDownLoadFileHandler : DownloadHandlerScript
{
    // 异步请求句柄
    public AsyncOperation requestOperation;
    // 异步请求回调
    public Action<AsyncOperation> Completed;
    // 下载文件后保存的路径
    private string _savePath;
    // 原始的bundleId
    private string _bundleId;
    // 解密后的数据
    private byte[] _cacheBytes;
    // 已经接收到的数据长度
    private ulong _recvLength;
    // 是否已经完成接收(CompleteContent触发)
    private bool _recvFinished;
    // 保存文件的句柄
    private FileStream _fileStream;
    // 最终生成bundle
    private AssetBundle _bundle;
    // 是否已经处理完
    private bool _handleEnded;
    // 时间戳
    private DateTime _startTime;

    // 解密类
    protected LXYDRC4 _rc4;
    protected Thread workThread;
    protected SynchronizationContext _mainContext;

    // 原始文件路径
    protected string _orignUrl;
    // 下载文件路径
    protected string _downloadUrl;

    // 接收的数据块链表
    protected LinkedList<byte[]> _byteArrList;
    // 当前解密的数据块节点
    protected LinkedListNode<byte[]> _curListNode;
    // 已解密的字节数量
    protected ulong _decryptByteLength;

    // 销毁标记
    protected bool isDisposing;

    public LXYDDownLoadFileHandler(string url, string savePath, string name) : base()
    {
        UnityEngine.Debug.Log("[Test] - download url - " + url);
        _orignUrl = url;
        if (url.StartsWith("http"))
        {
            Directory.CreateDirectory(savePath);
            _savePath = savePath + "/__data";
            _downloadUrl = url;
            if (LXYDDownloadUtil.downloadBundles.ContainsKey(_downloadUrl))
            {
                LXYDDownloadUtil.downloadBundles.Remove(_downloadUrl);
            }

            LXYDDownloadUtil.downloadBundles.Add(_downloadUrl, new ulong[] { 0, 0 });
        }

        _startTime = DateTime.Now;
        _byteArrList = new LinkedList<byte[]>();
        _curListNode = null;
        _decryptByteLength = 0;
        isDisposing = false;

        _bundleId = name;
        _recvLength = 0;
        _recvFinished = false;
        _handleEnded = false;
        _rc4 = new LXYDRC4();
        _mainContext = SynchronizationContext.Current;
        requestOperation = null;
    }

    public AssetBundle assetBundle
    {
        get { return _bundle; }
    }

    public bool isHandleEnded
    {
        get { return _handleEnded; }
    }

    public override void Dispose()
    {
        isDisposing = true;
        base.Dispose();
    }

    // 从网络收到数据后，每帧会调用的方法
    protected override bool ReceiveData(byte[] buffer, int dataLength)
    {
        UnityEngine.Debug.Log("[Test] ReceiveData -->" + dataLength + "  " + _orignUrl);
        if (buffer == null || buffer.Length <= 0 || dataLength <= 0)
        {
            if (buffer == null)
            {
                UnityEngine.Debug.LogError("[Test] - ReceiveData buffer is null, dataLength--> " + dataLength);
            }
            else
            {
                UnityEngine.Debug.LogError("[Test] - ReceiveData data is invalid: " + buffer.Length + "  " + dataLength);
            }
            _handleEnded = true;
            return false;
        }

        var recvData = new byte[dataLength];
        Array.Copy(buffer, 0, recvData, 0, dataLength);
        _recvLength += (ulong)dataLength;
        _byteArrList.AddLast(recvData);

        // 保存文件
        if (!string.IsNullOrEmpty(_savePath) && _fileStream == null)
        {
            _startTime = DateTime.Now;
            _fileStream = new FileStream(_savePath + ".tmp", FileMode.Create, FileAccess.Write);
        }

        // 开启解密线程，边接收数据边落地和解密
        if (workThread == null)
        {
            workThread = new Thread(new ThreadStart(DescryptThread))
            {
                IsBackground = true
            };
            workThread.Start();
        }

        if (_downloadUrl != null && LXYDDownloadUtil.downloadBundles.ContainsKey(_downloadUrl))
        {
            LXYDDownloadUtil.downloadBundles[_downloadUrl][1] = _recvLength;
        }

        return true;
    }

    // 从服务器收到contentLength标头时会调用
    protected override void ReceiveContentLengthHeader(ulong contentLength)
    {
        // UnityEngine.Debug.Log("[Test] - ReceiveContentLengthHeader - " + contentLength + "  " + _orignUrl);
        if (contentLength > 0 && !string.IsNullOrEmpty(_savePath))
        {
            if (_downloadUrl != null && LXYDDownloadUtil.downloadBundles.ContainsKey(_downloadUrl))
            {
                LXYDDownloadUtil.downloadBundles[_downloadUrl][0] = contentLength;
            }
        }
    }

    // 消息收完了，会自动调用的方法
    protected override void CompleteContent()
    {
        UnityEngine.Debug.Log("[Test] - CompleteContent - " + (DateTime.Now - _startTime).TotalMilliseconds + "  " + _recvLength + "  " + _orignUrl);
        _recvFinished = true;

        if (_downloadUrl != null && LXYDDownloadUtil.downloadBundles.ContainsKey(_downloadUrl))
        {
            LXYDDownloadUtil.downloadBundles.Remove(_downloadUrl);
        }
    }

    protected void BeginLoadAssetBundle()
    {
        var bundles = AssetBundle.GetAllLoadedAssetBundles();
        foreach (AssetBundle bundle in bundles)
        {
            if (bundle.name.StartsWith(_bundleId))
            {
                _bundle = bundle;
                _handleEnded = true;
                _byteArrList.Clear();
                Completed?.Invoke(requestOperation);
                return;
            }
        }

        _cacheBytes = new byte[_recvLength];
        _curListNode = _byteArrList.First;
        int count = 0;
        int total = 0;
        byte[] data = null;
        while (_curListNode != null)
        {
            data = _curListNode.Value;
            count = data.Length;
            Array.Copy(data, 0, _cacheBytes, total, count);
            total += count;
            _curListNode = _curListNode.Next;
        }

        _byteArrList.Clear();
        _byteArrList = null;
        _curListNode = null;
        var bundleReq = AssetBundle.LoadFromMemoryAsync(_cacheBytes);
        bundleReq.completed += LoadAssetBundleCompleted;
    }

    protected void LoadAssetBundleCompleted(AsyncOperation op)
    {
        UnityEngine.Debug.Log("[Test] - LoadAssetBundleCompleted - " + _cacheBytes.Length + "  " + (DateTime.Now - _startTime).TotalMilliseconds + "  " + (Completed == null).ToString());
        _bundle = (op as AssetBundleCreateRequest).assetBundle;
        _handleEnded = true;
        Completed?.Invoke(requestOperation);
    }

    protected void DescryptThread()
    {
        int count = 0;
        byte[] data = null;
        LinkedListNode<byte[]> listNode = null;
        while (!_recvFinished || _decryptByteLength < _recvLength)
        {
            if(isDisposing)
            {
                break;
            }

            if (_curListNode == null)
            {
                _curListNode = _byteArrList.First;
                listNode = _curListNode;
            }
            else if (_curListNode.Next != null)
            {
                _curListNode = _curListNode.Next;
                listNode = _curListNode;
            }

            if (listNode != null)
            {
                data = listNode.Value;
                count = data.Length;
                UnityEngine.Debug.Log("[Test] - DescryptThread - " + count);
                if (_fileStream != null)
                {
                    _fileStream.Write(data, 0, count);
                }

                _rc4.ToRC4(ref data, 0, count);
                _decryptByteLength += (ulong)count;
            }
            else
            {
                Thread.Sleep(1);
            }

            listNode = null;
            data = null;
        }

        _curListNode = null;
        if (_fileStream != null)
        {
            _fileStream.Close();
            if(!isDisposing)
            {
                File.Move(_savePath + ".tmp", _savePath);
            }
        }
        
        if(!isDisposing)
        {
            _mainContext.Send((state) =>
            {
                BeginLoadAssetBundle();
            }, null);
        }
    }
}