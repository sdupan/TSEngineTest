namespace PuertsStaticWrap
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using JsEnv = Puerts.JsEnv;
    using BindingFlags = System.Reflection.BindingFlags;

    public static class AutoStaticCodeUsing
    {
        public static void AutoUsing(this JsEnv jsEnv)
        {
            jsEnv.UsingAction<BestHTTP.WebSocket.WebSocket, BestHTTP.PlatformSupport.Memory.BufferSegment>();
            jsEnv.UsingAction<BestHTTP.WebSocket.WebSocket, BestHTTP.WebSocket.Frames.WebSocketFrameReader>();
            jsEnv.UsingAction<BestHTTP.WebSocket.WebSocket, System.UInt16, System.String>();
            jsEnv.UsingAction<BestHTTP.WebSocket.WebSocketResponse, BestHTTP.PlatformSupport.Memory.BufferSegment>();
            jsEnv.UsingAction<BestHTTP.WebSocket.WebSocketResponse, BestHTTP.WebSocket.Frames.WebSocketFrameReader>();
            jsEnv.UsingAction<BestHTTP.WebSocket.WebSocketResponse, System.UInt16, System.String>();
            jsEnv.UsingAction<FairyGUI.GTreeNode, System.Boolean>();
            jsEnv.UsingAction<FairyGUI.TreeNode, System.Boolean>();
            jsEnv.UsingAction<Puerts.JsEnv, Puerts.ILoader, System.Int32>();
            jsEnv.UsingAction<Spine.Unity.MeshGeneratorBuffers>();
            jsEnv.UsingAction<System.Boolean>();
            jsEnv.UsingAction<System.Boolean, System.Boolean, System.Int32>();
            jsEnv.UsingAction<System.Double>();
            jsEnv.UsingAction<System.Int32>();
            jsEnv.UsingAction<System.Int32, FairyGUI.GObject>();
            jsEnv.UsingAction<System.Int32, System.Int32, UnityTSGame.JSOPData>();
            jsEnv.UsingAction<System.Int64>();
            jsEnv.UsingAction<System.Single>();
            jsEnv.UsingAction<System.String, System.Boolean, System.String>();
            jsEnv.UsingAction<System.String, System.String, UnityEngine.LogType>();
            jsEnv.UsingAction<System.UInt32>();
            jsEnv.UsingAction<System.UInt64>();
            jsEnv.UsingAction<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>();
            jsEnv.UsingAction<UnityEngine.Color>();
            jsEnv.UsingAction<UnityEngine.CullingGroupEvent>();
            jsEnv.UsingAction<UnityEngine.CustomRenderTexture, System.Int32>();
            jsEnv.UsingAction<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ContactPairHeader>>();
            jsEnv.UsingAction<UnityEngine.PhysicsScene, Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>>();
            jsEnv.UsingAction<UnityEngine.Quaternion>();
            jsEnv.UsingAction<UnityEngine.Rect>();
            jsEnv.UsingAction<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent>();
            jsEnv.UsingAction<UnityEngine.SceneManagement.Scene>();
            jsEnv.UsingAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>();
            jsEnv.UsingAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>();
            jsEnv.UsingAction<UnityEngine.SortingLayer>();
            jsEnv.UsingAction<UnityEngine.Terrain, System.String, UnityEngine.RectInt, System.Boolean>();
            jsEnv.UsingAction<UnityEngine.Terrain, UnityEngine.RectInt, System.Boolean>();
            jsEnv.UsingAction<UnityEngine.Vector2>();
            jsEnv.UsingAction<UnityEngine.Vector3>();
            jsEnv.UsingAction<UnityEngine.Vector4>();
            jsEnv.UsingFunc<System.Boolean>();
            jsEnv.UsingFunc<System.Double>();
            jsEnv.UsingFunc<System.Int32>();
            jsEnv.UsingFunc<System.Int32, System.Boolean>();
            jsEnv.UsingFunc<System.Int32, System.Int32, System.Int32>();
            jsEnv.UsingFunc<System.Int32, System.String>();
            jsEnv.UsingFunc<System.Int32, System.String, TMPro.TMP_FontAsset>();
            jsEnv.UsingFunc<System.Int32, System.String, TMPro.TMP_SpriteAsset>();
            jsEnv.UsingFunc<System.Int64>();
            jsEnv.UsingFunc<System.Reflection.Assembly, System.String, System.Boolean, System.Type>();
            jsEnv.UsingFunc<System.Reflection.MemberInfo, System.Object, System.Boolean>();
            jsEnv.UsingFunc<System.Single>();
            jsEnv.UsingFunc<System.Single, System.Single, System.Single, System.Single, System.Single>();
            jsEnv.UsingFunc<System.String, System.Boolean>();
            jsEnv.UsingFunc<System.String, System.Boolean, System.String, System.String>();
            jsEnv.UsingFunc<System.String, System.Int32, System.Char, System.Char>();
            jsEnv.UsingFunc<System.String, System.String, System.Int32>();
            jsEnv.UsingFunc<System.String[], System.Boolean>();
            jsEnv.UsingFunc<System.String[], System.String[], System.Int32>();
            jsEnv.UsingFunc<System.Type, System.Object, System.Boolean>();
            jsEnv.UsingFunc<System.UInt32>();
            jsEnv.UsingFunc<System.UInt64>();
            jsEnv.UsingFunc<UnityEngine.Color>();
            jsEnv.UsingFunc<UnityEngine.GameObject, System.Boolean>();
            jsEnv.UsingFunc<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>();
            jsEnv.UsingFunc<UnityEngine.LogType, System.Object, System.Boolean>();
            jsEnv.UsingFunc<UnityEngine.Quaternion>();
            jsEnv.UsingFunc<UnityEngine.Rect>();
            jsEnv.UsingFunc<UnityEngine.Vector2>();
            jsEnv.UsingFunc<UnityEngine.Vector3>();
            jsEnv.UsingFunc<UnityEngine.Vector4>();
            jsEnv.UsingFunc<UnityTSGame.JSSnapshotData, System.Boolean>();
            jsEnv.UsingFunc<UnityTSGame.JSSnapshotData, UnityTSGame.JSSnapshotData, System.Int32>();
        }

        public static void UsingAction(this JsEnv jsEnv, params string[] args)
        {
            jsEnv.UsingGeneric(true, FindTypes(args));
        }
        public static void UsingFunc(this JsEnv jsEnv, params string[] args)
        {
            jsEnv.UsingGeneric(false, FindTypes(args));
        }
        public static void UsingGeneric(this JsEnv jsEnv, bool usingAction, params Type[] types)
        {
            var name = usingAction ? "UsingAction" : "UsingFunc";
            var count = types.Length;
            var method = (from m in typeof(JsEnv).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                          where m.Name.Equals(name)
                             && m.IsGenericMethod
                             && m.GetGenericArguments().Length == count
                          select m).FirstOrDefault();
            if (method == null)
                throw new Exception("Not found method: '" + name + "', ArgsLength=" + count);
            method.MakeGenericMethod(types).Invoke(jsEnv, null);
        }
        static Type[] FindTypes(string[] args)
        {
            var assemblys = AppDomain.CurrentDomain.GetAssemblies();
            var types = new List<Type>();
            foreach (var arg in args)
            {
                Type type = null;
                for (var i = 0; i < assemblys.Length && type == null; i++)
                    type = assemblys[i].GetType(arg, false);
                if (type == null)
                    throw new Exception("Not found type: '" + arg + "'");
                types.Add(type);
            }
            return types.ToArray();
        }
    }
}