using UnityEngine;
using UnityEngine.Networking;
using System;

public class LXYDWebRequestAssetBundle
{
    public static UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0)
    {
        var savePath = Caching.currentCacheForWriting.path + "/" + cachedAssetBundle.name + "/" + cachedAssetBundle.hash.ToString();
        return new UnityWebRequest(uri, "GET", new LXYDDownLoadFileHandler(uri.AbsoluteUri, savePath, null), null);;
    }

    public static UnityWebRequest GetAssetBundle(Uri uri, uint crc)
    {
        return new UnityWebRequest(uri, "GET", new LXYDDownLoadFileHandler(uri.AbsoluteUri, Caching.currentCacheForWriting.path, null), null);
    }

    public static UnityWebRequest GetAssetBundle(Uri uri)
    {
        return GetAssetBundle(uri, 0u);
    }
}