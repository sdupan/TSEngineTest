using Puerts;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

/// <summary>
/// 如果你全ts/js编程，可以参考这份自动化配置
/// </summary>
[Configure]
public class PuertsConfig
{
    [Typing]
    static IEnumerable<Type> Typeing
    {
        get
        {
            return new List<Type>()
            {
                //仅生成ts接口, 不生成C#静态代码
                //typeof(Dictionary<int,int>)
            };
        }
    }
    [BlittableCopy]
    static IEnumerable<Type> Blittables
    {
        get
        {
            return new List<Type>()
            {
                //打开这个可以优化Vector3的GC，但需要开启unsafe编译
                //typeof(Vector3),
            };
        }
    }
    static IEnumerable<Type> Bindings
    {
        get
        {
            return new List<Type>()
            {
               //直接指定的类型
                typeof(JsEnv),
                typeof(ILoader),
                typeof(System.Uri),
                typeof(System.Delegate),
                typeof(System.Object),
                typeof(System.Array),
                typeof(List<int>),
                typeof(List<string>),
                typeof(List<string[]>),
                typeof(List<UnityEngine.GameObject>),
                typeof(List<UnityTSGame.JSSnapshotData>),
                typeof(Dictionary<int, string>),
                typeof(Dictionary<string, string>),
                typeof(KeyValuePair<string, UnityEngine.GameObject>),
                typeof(System.Type),
                typeof(HashSet<string>),
                typeof(System.Collections.Hashtable),
                typeof(System.IntPtr),
                typeof(System.Guid),
                typeof(File),
                typeof(System.Globalization.RegionInfo),
                typeof(Unity.Profiling.ProfilerRecorder),
                typeof(Unity.Profiling.ProfilerCategory),
                typeof(Unity.Profiling.ProfilerRecorderOptions),
                typeof(UnityEngine.SceneManagement.SceneManager),
                typeof(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance),
                typeof(UnityEngine.UI.Text),
            };
        }
    }
    [Binding]
    static IEnumerable<Type> DynamicBindings
    {
        get
        {
            // 在这里添加名字空间
            var namespaces = new List<string>()
            {
                // Unity
                "UnityEngine",
                // AI
                "UnityEngine.AI",
                // Playables
                "UnityEngine.Playables",
                // Network
                "UnityEngine.Networking",
                // FairyGUI
                "FairyGUI",
                "FairyGUI.Utils",
                // WebSocket
                "BestHTTP.WebSocket",
                // DoTween
                "DG.Tweening",
                // TextMeshPro
                "TMPro",
                // Spine
                "Spine",
                "Spine.Unity",
                // Framework
                "UnityTSGame",
            };
            var unityTypes = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                              where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                              from type in assembly.GetExportedTypes()
                              where type.Namespace != null && namespaces.Contains(type.Namespace) && !IsExcluded(type)
                              select type);
            string[] customAssemblys = new string[] {
                "Assembly-CSharp"
            };
            var customTypes = (from assembly in customAssemblys.Select(s => Assembly.Load(s))
                               where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                               from type in assembly.GetExportedTypes()
                               where type.Namespace == null || !type.Namespace.StartsWith("Puerts")
                                    && !IsExcluded(type)
                               select type);
            return unityTypes
                .Concat(customTypes)
                .Concat(Bindings)
                .Distinct();
        }
    }
    static bool IsExcluded(Type type)
    {
        if (type == null)
            return false;

        string assemblyName = Path.GetFileName(type.Assembly.Location);
        if (excludeAssemblys.Contains(assemblyName))
            return true;

        string fullname = type.FullName != null ? type.FullName.Replace("+", ".") : "";
        if (excludeTypes.Contains(fullname))
            return true;
        return IsExcluded(type.BaseType);
    }
    //需要排除的程序集
    static List<string> excludeAssemblys = new List<string>{
        "UnityEditor.dll",
        "Assembly-CSharp-Editor.dll",
        "com.tencent.puerts.core.Editor.dll",
        "MaxSdk.Scripts.Editor.dll",
        "MaxSdk.Scripts.IntegrationManager.Editor.dll",
        "AppsFlyer.Editor.dll",
        "Google.Android.AppBundle.Editor.dll",
        "spine-unity-editor.dll",
        "GoogleMobileAds.Editor.dll",
    };
    //需要排除的类型
    static List<string> excludeTypes = new List<string>
    {
        "UnityEngine.iPhone",
        "UnityEngine.iPhoneTouch",
        "UnityEngine.iPhoneKeyboard",
        "UnityEngine.iPhoneInput",
        "UnityEngine.iPhoneAccelerationEvent",
        "UnityEngine.iPhoneUtils",
        "UnityEngine.iPhoneSettings",
        "UnityEngine.AndroidInput",
        "UnityEngine.AndroidJavaProxy",
        "UnityEngine.BitStream",
        "UnityEngine.ADBannerView",
        "UnityEngine.ADInterstitialAd",
        "UnityEngine.RemoteNotification",
        "UnityEngine.LocalNotification",
        "UnityEngine.NotificationServices",
        "UnityEngine.MasterServer",
        "UnityEngine.Network",
        "UnityEngine.NetworkView",
        "UnityEngine.ParticleSystemRenderer",
        "UnityEngine.ParticleSystem.CollisionEvent",
        "UnityEngine.ProceduralPropertyDescription",
        "UnityEngine.ProceduralTexture",
        "UnityEngine.ProceduralMaterial",
        "UnityEngine.ProceduralSystemRenderer",
        "UnityEngine.TerrainData",
        "UnityEngine.HostData",
        "UnityEngine.RPC",
        "UnityEngine.AnimationInfo",
        "UnityEngine.UI.IMask",
        "UnityEngine.Caching",
        "UnityEngine.Handheld",
        "UnityEngine.MeshRenderer",
        "UnityEngine.UI.DefaultControls",
        "UnityEngine.AnimationClipPair", //Obsolete
        "UnityEngine.CacheIndex", //Obsolete
        "UnityEngine.SerializePrivateVariables", //Obsolete
        "UnityEngine.Networking.NetworkTransport", //Obsolete
        "UnityEngine.Networking.ChannelQOS", //Obsolete
        "UnityEngine.Networking.ConnectionConfig", //Obsolete
        "UnityEngine.Networking.HostTopology", //Obsolete
        "UnityEngine.Networking.GlobalConfig", //Obsolete
        "UnityEngine.Networking.ConnectionSimulatorConfig", //Obsolete
        "UnityEngine.Networking.DownloadHandlerMovieTexture", //Obsolete
        "AssetModificationProcessor", //Obsolete
        "AddressablesPlayerBuildProcessor", //Obsolete
        "UnityEngine.WWW", //Obsolete
        "UnityEngine.EventSystems.TouchInputModule", //Obsolete
        "UnityEngine.MovieTexture", //Obsolete[ERROR]
        "UnityEngine.NetworkPlayer", //Obsolete[ERROR]
        "UnityEngine.NetworkViewID", //Obsolete[ERROR]
        "UnityEngine.NetworkMessageInfo", //Obsolete[ERROR]
        "UnityEngine.UI.BaseVertexEffect", //Obsolete[ERROR]
        "UnityEngine.UI.IVertexModifier", //Obsolete[ERROR]
        "UnityEngine.Camera.RenderRequest", //Obsolete[ERROR]
        //Windows Obsolete[ERROR]
        "UnityEngine.EventProvider",
        "UnityEngine.UI.GraphicRebuildTracker",
        "UnityEngine.GUI.GroupScope",
        "UnityEngine.GUI.ScrollViewScope",
        "UnityEngine.GUI.ClipScope",
        "UnityEngine.GUILayout.HorizontalScope",
        "UnityEngine.GUILayout.VerticalScope",
        "UnityEngine.GUILayout.AreaScope",
        "UnityEngine.GUILayout.ScrollViewScope",
        "UnityEngine.GUIElement",
        "UnityEngine.GUILayer",
        "UnityEngine.GUIText",
        "UnityEngine.GUITexture",
        "UnityEngine.ClusterInput",
        "UnityEngine.ClusterNetwork",
        //System
        "System.Tuple",
        "System.Double",
        "System.Single",
        "System.ArgIterator",
        "System.SpanExtensions",
        "System.TypedReference",
        "System.StringBuilderExt",
        "System.IO.Stream",
        "System.Net.HttpListenerTimeoutManager",
        "System.Net.Sockets.SocketAsyncEventArgs",

        // Extra
        "UnityEngine.LightingSettings",
        "UnityEngine.ClusterSerialization",
        "UnityEngine.CloudStreaming",
        "UnityEngine.QualitySettings",

        // BestHttp
        "BestHTTP.PlatformSupport.TcpClient.General.TcpClient",

        // TextMeshPro
        "TMPro.TMP_PreBuildProcessor",
        "TMPro.TMP_PackageUtilities",
        "TMPro.TMP_FontAsset_CreationMenu",
        "TMPro.TMP_EditorResourceManager",
        "TMPro.SortingLayerHelper",
        "TMPro.SortingLayerHelper",
        "TMPro.TMP_PackageResourceImporter",
        "TMPro.TMP_PostBuildProcessHandler",

        // Google SDK
        "Google.GoogleSignIn.SignInException",
        "Google.GoogleSignIn",
        "Google.GoogleSignInConfiguration",
        "Google.Impl.SignInHelperObject",

        // Spine
        "Spine.Unity.BuildUtilities",
        "Spine.Unity.MaterialChecks",
        "Spine.Unity.SkeletonDataCompatibility",

        // 自定义
        "AASUtility",
        "AddressableTools",
        "PublishTools",
        "CrusadeMapTool",
        "CreatPrefab",
        "AddChildObject",
        "EditorTool",
        "BF2nightContral",
        "UnityEditor.ScriptableObject",
        "UnityEditor.EditorWindow",
        "UnityEditor.GUI.TSPropertiesEditor",
        "UnityEditor.GUI.TSBehaviourEditor",
        "UnityEditor.GUI.ArrayDrawer",
        "UnityEditor.GUI.Display",
        "UnityEditor.GUI.DisplayUtility",
        "UnityEditor.GUI.Drawer",
        "UnityEditor.GUI.DrawerInfo",
        "UnityEditor.GUI.Element",
    };
}