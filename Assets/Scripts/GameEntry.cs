using System;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityTSGame;

public class GameEntry : MonoBehaviour
{
    void Awake()
    {
        BFGameMode.Init();
        Addressables.InternalIdTransformFunc = InternalIdTransformFunc;
    }

    async void Start()
    {
        // 捕获全部异常
        Application.logMessageReceived += GlobalExceptionHandler;

        // 进入游戏
        ResourceManager.Init();
        JSManager.gameRootObject = gameObject;
        await JSManager.StartGame();
    }

    void Update()
    {
        JSManager.Update();
    }

    void OnApplicationQuit()
    {
        Application.logMessageReceived -= GlobalExceptionHandler;
        JSManager.OnApplicationQuit();
        JSManager.Dispose();
    }

    void OnApplicationFocus(bool focusStatus)
    {
        JSManager.OnApplicationFocus(focusStatus);
    }

    protected void GlobalExceptionHandler(string condition, string stackTrace, LogType type)
    {
        if (type != LogType.Error && type != LogType.Exception && type != LogType.Assert)
        {
            return;
        }

        // 这里需要上报错误信息及堆栈到后台
        Debug.Log("[GlobalExceptionHandler] - " + stackTrace);
    }

    private string InternalIdTransformFunc(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location)
    {
        // Debug.Log("[GameEntry] - Request InternalId: " + location.InternalId);

        //判定是否是一个AB包的请求
        if (location.Data is AssetBundleRequestOptions)
        {
            var ab = location.Data as AssetBundleRequestOptions;

            // Debug.Log("[GameEntry] - :: " + Addressables.RuntimePath + "  " + PlatformMappingService.GetPlatformPathSubFolder() + "  " + ab.BundleName + "  " + ab.BundleSize + "  " + ab.Hash + "  " + location.PrimaryKey);
            // PrimaryKey是AB包的原始名字(例如 bfgame_js_assets_all_f93eef08f74ad9d746276b99464cdaff.bundle)，不是下载后的名称
            // path就是StreamingAssets/aa/{BuildTarget}/AB包名.bundle，发布应用程序时，复制的目录
            // Library/com.unity.addressables/aa/{BuildTarget}
            var path = Path.Combine(Addressables.RuntimePath, PlatformMappingService.GetPlatformPathSubFolder(), location.PrimaryKey);
            if (BFGameOSUtil.StreamAssetsFileExist(Addressables.RuntimePath, location.PrimaryKey))
            {
                // Debug.Log("[GameEntry] - return RuntimePath --> " + path);
                return path;
            }
            else
            {
                path = Path.Combine(Caching.currentCacheForWriting.path, ab.BundleName, ab.Hash, "__data");
                if (File.Exists(path))
                {
                    // Debug.Log("[GameEntry] - return persistentDataPath --> " + path);
                    return path;
                }
            }
        }
        else if (location.InternalId.StartsWith("http://") || location.InternalId.StartsWith("https://"))
        {
            if (location.InternalId.EndsWith("catalog_zhgame.hash") || location.InternalId.EndsWith("catalog_zhgame.json"))
            {
                var resId = location.InternalId + "?" + ((DateTime.Now.Ticks - 621355968000000000) / 10000).ToString();
                // Debug.Log("[GameEntry] - return InternalId?timestamp --> " + resId);
                return resId;
            }
        }

        // Debug.Log("[GameEntry] - return InternalId --> " + location.InternalId);
        return location.InternalId;
    }
}
