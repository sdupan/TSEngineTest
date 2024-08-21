using System;
using Unity.VisualScripting;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

#if UNITY_ANDROID
// using GoogleMobileAds.Ump.Api;
// using Google.Play.Review;
#endif

namespace UnityTSGame
{
    public class BFGameOSUtil
    {
        public static string deviceId;

        protected static string serviceName = BFGameMode.GAME_MODE.ToString() + ":__com.lxyd.zoocanteen__";
#if UNITY_ANDROID
        protected static AndroidJavaClass _keyStoreUtil;
#elif UNITY_IOS
        protected static string accountName = "__zhgame_account__";

        [DllImport("__Internal")]
        private static extern string getBundleVersion();

        [DllImport("__Internal")]
        private static extern void setAccessibilityType(int abType);

        [DllImport("__Internal")]
        private static extern string getKeyChainData(string service, string account);

        [DllImport("__Internal")]
        private static extern bool setKeyChainData(string service, string account, string content);

        [DllImport("__Internal")]
        private static extern bool deleteKeyChainData(string service, string account);
#endif

        public static string GetVersionCode()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
#if UNITY_ANDROID
                    AndroidJavaClass contextCls = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    AndroidJavaObject context = contextCls.GetStatic<AndroidJavaObject>("currentActivity");
                    AndroidJavaObject packageMngr = context.Call<AndroidJavaObject>("getPackageManager");
                    string packageName = context.Call<string>("getPackageName");
                    AndroidJavaObject packageInfo = packageMngr.Call<AndroidJavaObject>("getPackageInfo", packageName, 0);
                    return packageInfo.Get<string>("versionName");
#endif
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
#if UNITY_IOS
                    return getBundleVersion();
#endif
            }

            return "1.0.0";
        }

        public static string GetDeviceId()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
#if UNITY_ANDROID
                try
                {
                    AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                    AndroidJavaObject contentResolver = currentActivity.Call<AndroidJavaObject>("getContentResolver");
                    AndroidJavaClass secure = new AndroidJavaClass("android.provider.Settings$Secure");
                    string android_id = secure.CallStatic<string>("getString", contentResolver, "android_id");
                    Debug.Log("[BFGameOSUtil] - GetDeviceId -->android_id-->" + android_id);
                    if(android_id == null || android_id == "" || android_id == "9774d56d682e549c") {
                        android_id = null;
                        AndroidJavaObject telephoneMgr = currentActivity.Call<AndroidJavaObject>("getSystemService", "phone");
                        android_id = telephoneMgr.Call<string>("getDeviceId");
                        Debug.Log("[BFGameOSUtil] - GetDeviceId -->getDeviceId-->" + android_id);
                    }

                    deviceId = android_id;
                    return android_id;
                }
                catch(Exception e)
                {
                    Debug.Log("[BFGameOSUtil] - GetDeviceId -->Exception-->" + e.ToString());
                }
#endif
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
#if UNITY_IOS
                try
                {
                    var iOSDid = getKeyChainData(serviceName, accountName);
                    if(iOSDid != null && iOSDid != "") {
                        deviceId = iOSDid;
                        Debug.Log("[BFGameOSUtil] - GetDeviceId-->getKeyChainData-->" + iOSDid);
                        return iOSDid;
                    }
                }
                catch(Exception e)
                {
                    Debug.Log("[BFGameOSUtil] - GetDeviceId -->Exception-->" + e.ToString());
                }
#endif
            }

            deviceId = Guid.NewGuid().ToString().Replace("-", "");
            Debug.Log("[BFGameOSUtil] - GetDeviceId-->" + deviceId);
            return deviceId;
        }

        public static bool SetDeviceId(string deviceId)
        {
#if UNITY_IOS
            try
            {
                deleteKeyChainData(serviceName, accountName);
                setAccessibilityType(4);
                setKeyChainData(serviceName, accountName, deviceId);
                return true;
            }
            catch(Exception e)
            {
                Debug.Log("[BFGameOSUtil] - SetDeviceId -->Exception-->" + e.ToString());
            }
#endif
            return false;
        }

        public static string GetKeyChainContent(string name)
        {
            try
            {
#if UNITY_ANDROID
                _GetAndroidKeyStoreUtil();
                if(_keyStoreUtil != null)
                {
                    return _keyStoreUtil.CallStatic<string>("getKeyChainData", serviceName + ":" + name);
                }
#elif UNITY_IOS
                return getKeyChainData(serviceName, name);
#endif
            }
            catch(Exception e)
            {
                Debug.Log("[BFGameOSUtil] - GetKeyChainContent -->Exception-->" + e.ToString());
            }

            return null;
        }

        public static bool SetKeyChainContent(string name, string content)
        {
            try
            {
#if UNITY_ANDROID
                _GetAndroidKeyStoreUtil();
                if(_keyStoreUtil != null)
                {
                    _keyStoreUtil.CallStatic<bool>("deleteKeyChainData", serviceName + ":" + name);
                    return _keyStoreUtil.CallStatic<bool>("setKeyChainData", serviceName + ":" + name, content);
                }
#elif UNITY_IOS
                deleteKeyChainData(serviceName, name);
                setAccessibilityType(4);
                setKeyChainData(serviceName, name, content);
                return true;
#endif
            }
            catch(Exception e)
            {
                Debug.Log("[BFGameOSUtil] - SetKeyChainContent -->Exception-->" + e.ToString());
            }

            return false;
        }

        public static bool deleteKeyChainContent(string name)
        {
            try
            {
#if UNITY_ANDROID
                _GetAndroidKeyStoreUtil();
                if(_keyStoreUtil != null)
                {
                    return _keyStoreUtil.CallStatic<bool>("deleteKeyChainData", serviceName + ":" + name);
                }
#elif UNITY_IOS
                return deleteKeyChainData(serviceName, name);
#endif
            }
            catch(Exception e)
            {
                Debug.Log("[BFGameOSUtil] - deleteKeyChainContent -->Exception-->" + e.ToString());
            }

            return false;
        }

        public static bool FileExist(string path)
        {
            if (Application.platform == RuntimePlatform.Android)
            {
#if UNITY_ANDROID
                    string[] args = new string[]{path};
                    AndroidJavaObject fileObj = new AndroidJavaObject("java.io.File", args);
                    return fileObj.Call<bool>("exists");
#endif
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
#if UNITY_IOS
                    return System.IO.File.Exists(path);
#endif
            }


            return System.IO.File.Exists(path);
        }

        public static bool DeleteFile(string path)
        {
            if (Application.platform == RuntimePlatform.Android)
            {
#if UNITY_ANDROID
                    string[] args = new string[]{path};
                    AndroidJavaObject fileObj = new AndroidJavaObject("java.io.File", args);
                    return fileObj.Call<bool>("delete");
#endif
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
#if UNITY_IOS
                    System.IO.File.Delete(path);
                    return true;
#endif
            }


            System.IO.File.Delete(path);
            return true;
        }

        public static bool StreamAssetsFileExist(string path, string fileName)
        {
            if (Application.platform == RuntimePlatform.Android)
            {
#if UNITY_ANDROID
                try
                {
                    AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                    AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                    AndroidJavaObject assetMgr = currentActivity.Call<AndroidJavaObject>("getAssets");
                    AndroidJavaObject inputStream = assetMgr.Call<AndroidJavaObject>("open", "aa/" + PlatformMappingService.GetPlatformPathSubFolder() + "/" + fileName);
                    if(inputStream != null)
                    {
                        inputStream.Call("close");
                        return true;
                    }
                }
                catch(Exception e)
                {
                    Debug.Log("[BFGameOSUtil] - StreamAssetsFileExist -->Exception-->" + e.ToString());
                }
#endif
            }
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
            {   
#if UNITY_IOS
                var iosPath = System.IO.Path.Combine(path, PlatformMappingService.GetPlatformPathSubFolder(), fileName);
                return System.IO.File.Exists(iosPath);
#endif
            }


            return System.IO.File.Exists(path);
        }

        public static async Task<string> OpenReview()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            // ReviewManager rm = new ReviewManager();
            // var requestFlowOperation = rm.RequestReviewFlow();
            // while(!requestFlowOperation.IsDone)
            // {
            //     await Task.Delay(50);
            // }

            // if(requestFlowOperation.Error != ReviewErrorCode.NoError)
            // {
            //     Debug.LogFormat("requestFlowOperation:{0}", requestFlowOperation.Error);
            //     return requestFlowOperation.Error.ToString();
            // }

            // PlayReviewInfo playReviewInfo =  requestFlowOperation.GetResult();
            // var launchFlowOperation = rm.LaunchReviewFlow(playReviewInfo);
            // while(!launchFlowOperation.IsDone)
            // {
            //     await Task.Delay(50);
            // }
            
            // playReviewInfo = null; // Reset the object
            // if (launchFlowOperation.Error != ReviewErrorCode.NoError)
            // {
            //     return launchFlowOperation.Error.ToString();
            // }
#elif UNITY_IOS
            UnityEngine.iOS.Device.RequestStoreReview();
#else
            await Task.Delay(50);
#endif

            return "";
        }

        public static int GetGDPRStatus()
        {
#if UNITY_ANDROID
            // return (int)ConsentInformation.PrivacyOptionsRequirementStatus;
            return 0;
#else
            return 0;
#endif
        }

        public static void ShowPrivacyOptionsForm()
        {
#if UNITY_ANDROID
            // ConsentForm.ShowPrivacyOptionsForm((FormError showError) =>
            // {
            //     if (showError != null)
            //     {
            //         Debug.LogWarning("[BFGameOSUtil] - Error showing privacy options form with error: " + showError.Message);
            //     }
            // });
#endif
        }

        public static void ReportException(string name, string message, string stackTrace)
        {
#if UNITY_IPHONE || UNITY_IOS || UNITY_ANDROID
            // BuglyAgent.ReportException(name, message, stackTrace);
#endif
        }

#if UNITY_ANDROID
        protected static void _GetAndroidKeyStoreUtil()
        {
            if(_keyStoreUtil == null)
            {
                try
                {
                    _keyStoreUtil = new AndroidJavaClass("com.lxyd.utils.KeyStoreHelper");
                }
                catch(Exception e)
                {
                    Debug.Log("[BFGameOSUtil] - _GetAndroidKeyStoreUtil -->Exception-->" + e.ToString());
                }
            }
        }
#endif
    }
}