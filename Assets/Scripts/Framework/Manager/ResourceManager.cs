using FairyGUI;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;
using UnityEngine.ResourceManagement.ResourceProviders;
using System.Text;

namespace UnityTSGame
{
    public class PreloadInfo
    {
        public AsyncOperationHandle<IList<GameObject>> handle;
        public List<KeyValuePair<string, GameObject>> prefabs;

        public PreloadInfo()
        {
            this.prefabs = new List<KeyValuePair<string, GameObject>>();
        }
    }

    public class PreloadAudioInfo
    {
        public AsyncOperationHandle<IList<AudioClip>> handle;
        public List<KeyValuePair<string, AudioClip>> prefabs;

        public PreloadAudioInfo()
        {
            this.prefabs = new List<KeyValuePair<string, AudioClip>>();
        }
    }

    public class ResourceManager
    {
        public static Action resourceLoadProcNotify;
        public static float preloadTextPercent = 0;
        public static float preloadPrefabPercent = 0;
        public static float preloadUIPercent = 0;
        public static float launchPercent = 0;
        protected static float initLaunchPercent = new System.Random().Next(10, 100) / 400.0f;

        protected static string cryptDataKey = "BH8rn#pwub4!kWafWz5p97W*7%h$ni59";

        private static Dictionary<string, byte[]> _pkgAssets = new();
        private static Dictionary<string, Texture> _publicUITextures = new();
        private static Dictionary<string, Texture> _sceneUITextures = new();

        public static void Init()
        {
            NTexture.CustomDestroyMethod += (Texture tex) =>
            {
                var name = tex.name;
                ReleaseTexture(name);
                Debug.Log("Release NTexture :" + name);
            };

            NAudioClip.CustomDestroyMethod += (AudioClip audio) =>
            {
                var name = audio.name;
                Addressables.Release(audio);
                Debug.Log("release C# :" + name);
            };
        }

        public static void ReleaseFGUIPackage(string packageName)
        {
            UIPackage pkg = UIPackage.GetByName(packageName);
            if (pkg != null)
            {
                pkg.UnloadAssets();
                UIPackage.RemovePackage(packageName);
            }

            ReleaseTexture(packageName);
        }

        public static async Task PreloadGUIPkgBytes(string label)
        {
            var handle = Addressables.LoadAssetsAsync<TextAsset>(label, null);
            await handle.Task;
            if (handle.Result != null)
            {
                foreach (var asset in handle.Result)
                {
                    _pkgAssets.Add(asset.name, asset.bytes);
                }
            }
            else
            {
                Debug.LogError("[ResourceManager] - PreloadGUIPkgBytes Failed......");
            }

            Addressables.Release(handle);
        }

        public static async Task PreloadPublicUITextures(string label)
        {
            preloadUIPercent = 0;
            var resHandle = Addressables.LoadResourceLocationsAsync(label);
            var resList = await resHandle.Task;
            var total = resList.Count;
            var nowCount = 0;
            foreach (var key in resList)
            {
                if(!_publicUITextures.ContainsKey(key.PrimaryKey))
                {
                    var tex = await Addressables.LoadAssetAsync<Texture>(key.PrimaryKey).Task;
                    if(tex != null)
                    {
                        _publicUITextures.Add(key.PrimaryKey, tex);
                    }

                    nowCount++;
                    preloadUIPercent = nowCount * 1.0f / total;
                    resourceLoadProcNotify?.Invoke();
                }
            }
            
            preloadUIPercent = 1;
            Addressables.Release(resHandle);
        }

        public static async Task PreloadSceneUITextures(string label)
        {
            preloadUIPercent = 0;
            var resHandle = Addressables.LoadResourceLocationsAsync(label);
            var resList = await resHandle.Task;
            var total = resList.Count;
            var nowCount = 0;
            foreach (var key in resList)
            {
                if(!_sceneUITextures.ContainsKey(key.PrimaryKey))
                {
                    var tex = await Addressables.LoadAssetAsync<Texture>(key.PrimaryKey).Task;
                    if(tex != null)
                    {
                        _sceneUITextures.Add(key.PrimaryKey, tex);
                    }

                    nowCount++;
                    preloadUIPercent = nowCount * 1.0f / total;
                    resourceLoadProcNotify?.Invoke();
                }
            }
            
            preloadUIPercent = 1;
            Addressables.Release(resHandle);
        }

        public static void LoadFairyGUIPackage(string address, string prefix)
        {
            _pkgAssets.TryGetValue(address, out byte[] pkgAsset);
            if (pkgAsset != null)
            {
                UIPackage.AddPackage(pkgAsset, prefix, (string name, string extension, Type type, out DestroyMethod destroyMethod) =>
                {
                    Debug.Log("[ResourceManager] LoadFairyGUIPackage--->>" + name + "  " + extension + "  " + type.ToString());
                    destroyMethod = DestroyMethod.Custom;
                    if (type == typeof(Texture))
                    {
                        _publicUITextures.TryGetValue(name, out Texture tex);
                        if (tex == null)
                        {
                            _sceneUITextures.TryGetValue(name, out tex);
                        }

                        if (tex != null)
                        {
                            return tex;
                        }
                    }

                    return null;
                });
            }
        }

        public static async Task<List<string[]>> PreloadTextAssets(string label)
        {
            preloadTextPercent = 0;
            var totalCount = 0;
            var resHandle = Addressables.LoadResourceLocationsAsync(label);
            var resList = await resHandle.Task;
            totalCount = resList.Count;
            var keys = new List<string>(resList.Count);
            foreach (var key in resList)
            {
                keys.Add(key.PrimaryKey);
            }

            var loadedCount = 0;
            var time = DateTime.Now.Ticks;
            var nowTime = 0L;
            var handle = Addressables.LoadAssetsAsync<TextAsset>(keys, (obj) =>
            {
                loadedCount++;
                preloadTextPercent = loadedCount * 1.0f / totalCount;
                nowTime = DateTime.Now.Ticks;
                resourceLoadProcNotify?.Invoke();
                time = nowTime;
            }, Addressables.MergeMode.Union);

            await handle.Task;
            Addressables.Release(resList);

            var list = new List<string[]>();
            foreach (var asset in handle.Result)
            {
                var content = new string[2];
                content[0] = asset.name;
                content[1] = asset.text;
                list.Add(content);
            }

            preloadTextPercent = 1;

            // 加载完成
            Addressables.Release(handle);

            return list;
        }

        public static async Task<PreloadInfo> PreloadPrefabs(string label)
        {
            preloadPrefabPercent = 0;
            var totalCount = 0;
            var keys = new List<string> { label };
            var resList = await Addressables.LoadResourceLocationsAsync(keys, Addressables.MergeMode.UseFirst).Task;
            totalCount = resList.Count;
            var results = new List<string>(resList.Count);
            foreach (var key in resList)
            {
                results.Add(key.PrimaryKey);
            }

            Debug.Log("[ResourceManager] - LoadResourceLocationsAsync -->" + label + "  " + totalCount);

            var loadedCount = 0;
            var time = DateTime.Now.Ticks;
            var nowTime = 0L;
            var handle = Addressables.LoadAssetsAsync<GameObject>(keys, (obj) =>
            {
                loadedCount++;
                preloadPrefabPercent = loadedCount * 1.0f / totalCount;
                nowTime = DateTime.Now.Ticks;
                Debug.Log("[ResourceManager] - PreloadPrefabs -->" + loadedCount + "  " + totalCount + "  " + preloadPrefabPercent + "  " + obj.name + "  " + (nowTime - time) / 10000);
                resourceLoadProcNotify?.Invoke();
                time = nowTime;
            }, Addressables.MergeMode.Union);

            await handle.Task;

            var preloadInfo = new PreloadInfo
            {
                handle = handle
            };
            foreach (var asset in handle.Result)
            {
                preloadInfo.prefabs.Add(new KeyValuePair<string, GameObject>(asset.name, asset));
            }

            preloadPrefabPercent = 1;

            return preloadInfo;
        }

        public static async Task<PreloadAudioInfo> PreloadAudios(string label)
        {
            var handle = Addressables.LoadAssetsAsync<AudioClip>(label, null);
            await handle.Task;

            var preloadInfo = new PreloadAudioInfo
            {
                handle = handle
            };
            foreach (var asset in handle.Result)
            {
                preloadInfo.prefabs.Add(new KeyValuePair<string, AudioClip>(asset.name, asset));
            }

            return preloadInfo;
        }

        public static async Task<bool> PreloadJS(string jsLabel)
        {
            launchPercent = initLaunchPercent;
            var totalCount = 0;
            var keys = new List<string> { jsLabel };
            var resList = await Addressables.LoadResourceLocationsAsync(keys, Addressables.MergeMode.UseFirst).Task;
            totalCount = resList.Count;
            var results = new List<string>(resList.Count);
            foreach (var key in resList)
            {
                results.Add(key.PrimaryKey);
            }

            Debug.Log("[ResourceManager] - LoadResourceLocationsAsync -->" + jsLabel + "  " + totalCount);

            var loadedCount = 0;
            var time = DateTime.Now.Ticks;
            var nowTime = 0L;
            var handle = Addressables.LoadAssetsAsync<TextAsset>(keys, (obj) =>
            {
                loadedCount++;
                launchPercent = Math.Max(initLaunchPercent, loadedCount * 0.5f / totalCount);
                nowTime = DateTime.Now.Ticks;
                Debug.Log("[ResourceManager] - PreloadJS -->" + loadedCount + "  " + totalCount + "  " + preloadPrefabPercent + "  " + obj.name + "  " + (nowTime - time) / 10000);
                resourceLoadProcNotify?.Invoke();
                time = nowTime;
            }, Addressables.MergeMode.Union);

            var list = await handle.Task;
            if (list != null)
            {
                foreach (var txt in list)
                {
                    JSManager.jscache.Remove(txt.name);
                    JSManager.jscache.Add(txt.name, txt.text);
                }

                Addressables.Release(list);

                return true;
            }
            else
            {
                Debug.LogError("[ResourceManager] - PreloadJS Failed......");
                return false;
            }
        }

        public static async Task<GameObject> LoadPrefab(string address)
        {
            var res = await Addressables.LoadAssetAsync<GameObject>(address).Task;
            return res;
        }

        public static async Task<GameObject> InstantiatePrefab(string address, Transform parent = null, bool instantiateInWorldSpace = false)
        {
            var res = await Addressables.InstantiateAsync(address, parent, instantiateInWorldSpace).Task;
            return res;
        }

        public static async Task<TextAsset> LoadTextAsset(string address)
        {
            var res = await Addressables.LoadAssetAsync<TextAsset>(address).Task;
            return res;
        }

        public static async Task<Puerts.ArrayBuffer> LoadTextBytes(string address)
        {
            var res = await Addressables.LoadAssetAsync<TextAsset>(address).Task;
            return new Puerts.ArrayBuffer(res.bytes);
        }

        public static async Task<Sprite> LoadSprite(string address)
        {
            var res = await Addressables.LoadAssetAsync<Sprite>(address).Task;
            return res;
        }

        public static async Task<Texture> LoadTexture(string address)
        {
            var res = await Addressables.LoadAssetAsync<Texture>(address).Task;
            return res;
        }

        public static async Task<Font> LoadFont(string address)
        {
            var res = await Addressables.LoadAssetAsync<Font>(address).Task;
            return res;
        }

        public static async Task<Material> LoadMaterial(string address)
        {
            var res = await Addressables.LoadAssetAsync<Material>(address).Task;
            return res;
        }

        public static async Task<SceneInstance> LoadScene(string address)
        {
            var res = await Addressables.LoadSceneAsync(address, LoadSceneMode.Additive, true).Task;
            return res;
        }

        public static void ReleaseAddressablesGO(UnityEngine.Object go)
        {
            Addressables.Release(go);
        }

        public static void ReleaseAddressablesHandle(AsyncOperationHandle handle)
        {
            Addressables.Release(handle);
        }

        public static void ReleaseAddressablesListHandle(AsyncOperationHandle<IList<GameObject>> handle)
        {
            Addressables.Release(handle);
        }

        public static void UnloadScene(SceneInstance scene, bool autoReleaseHandle = true)
        {
            Addressables.UnloadSceneAsync(scene, autoReleaseHandle);
        }

        public static Dictionary<string, ulong[]> GetDownloadBundlesInfo()
        {
            return LXYDDownloadUtil.downloadBundles;
        }

        protected static void ReleaseTexture(string packageName)
        {
            var list1 = new List<string>();
            foreach(var data in _sceneUITextures)
            {
                if(data.Key.StartsWith(packageName))
                {
                    // Debug.Log("[ResourceManager] ReleaseTexture _sceneUITextures  " + packageName + "  " + data.Key);
                    Addressables.Release(data.Value);
                    list1.Add(data.Key);
                }
            }

            foreach(var key in list1)
            {
                _sceneUITextures.Remove(key);
            }

            var list2 = new List<string>();
            foreach(var data in _publicUITextures)
            {
                if(data.Key.StartsWith(packageName))
                {
                    // Debug.Log("[ResourceManager] ReleaseTexture _publicUITextures  " + packageName + "  " + data.Key);
                    Addressables.Release(data.Value);
                    list2.Add(data.Key);
                }
            }

            foreach(var key in list2)
            {
                _publicUITextures.Remove(key);
            }
        }
    }
}