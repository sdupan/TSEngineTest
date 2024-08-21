#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_AI_NavMeshBuilder_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.AI.NavMeshBuilder).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CollectSources(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 8)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(info, 6);
                    object argobj6 = null;
                    JsValueType argType6 = JsValueType.Invalid;
                    IntPtr v8Value7 = PuertsDLL.GetArgumentValue(info, 7);
                    object argobj7 = null;
                    JsValueType argType7 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.AI.NavMeshCollectGeometry), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Bounds arg0 = (UnityEngine.Bounds)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.AI.NavMeshCollectGeometry arg2 = (UnityEngine.AI.NavMeshCollectGeometry)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> arg5 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)argobj5;
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);
                        argobj7 = argobj7 != null ? argobj7 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg7 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj7;

                        UnityEngine.AI.NavMeshBuilder.CollectSources (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.AI.NavMeshCollectGeometry), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.AI.NavMeshCollectGeometry arg2 = (UnityEngine.AI.NavMeshCollectGeometry)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> arg5 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)argobj5;
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, false);
                        argobj7 = argobj7 != null ? argobj7 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg7 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj7;

                        UnityEngine.AI.NavMeshBuilder.CollectSources (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        return;
                    }
                }
                if (paramLen == 6)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Bounds), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.AI.NavMeshCollectGeometry), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Bounds arg0 = (UnityEngine.Bounds)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.AI.NavMeshCollectGeometry arg2 = (UnityEngine.AI.NavMeshCollectGeometry)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> arg4 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg5 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj5;

                        UnityEngine.AI.NavMeshBuilder.CollectSources (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.AI.NavMeshCollectGeometry), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.AI.NavMeshCollectGeometry arg2 = (UnityEngine.AI.NavMeshCollectGeometry)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> arg4 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg5 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj5;

                        UnityEngine.AI.NavMeshBuilder.CollectSources (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CollectSources");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_BuildNavMeshData(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(info, 3);
                    object argobj3 = null;
                    ;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(info, 4);
                    object argobj4 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.AI.NavMeshBuildSettings>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.AI.NavMeshBuildSettings arg0 = (UnityEngine.AI.NavMeshBuildSettings)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg1 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Bounds arg2 = (UnityEngine.Bounds)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Quaternion>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)argobj4;

                        var result = UnityEngine.AI.NavMeshBuilder.BuildNavMeshData (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_UpdateNavMeshData(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(info, 3);
                    object argobj3 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.AI.NavMeshData>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.AI.NavMeshData arg0 = (UnityEngine.AI.NavMeshData)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.AI.NavMeshBuildSettings>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.AI.NavMeshBuildSettings arg1 = (UnityEngine.AI.NavMeshBuildSettings)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg2 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Bounds arg3 = (UnityEngine.Bounds)argobj3;

                        var result = UnityEngine.AI.NavMeshBuilder.UpdateNavMeshData (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_UpdateNavMeshDataAsync(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(info, 3);
                    object argobj3 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.AI.NavMeshData>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.AI.NavMeshData arg0 = (UnityEngine.AI.NavMeshData)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.AI.NavMeshBuildSettings>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.AI.NavMeshBuildSettings arg1 = (UnityEngine.AI.NavMeshBuildSettings)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> arg2 = (System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Bounds>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Bounds arg3 = (UnityEngine.Bounds)argobj3;

                        var result = UnityEngine.AI.NavMeshBuilder.UpdateNavMeshDataAsync (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Cancel(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.AI.NavMeshData>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.AI.NavMeshData arg0 = (UnityEngine.AI.NavMeshData)argobj0;

                        UnityEngine.AI.NavMeshBuilder.Cancel (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
    // ==================== properties end ====================
    // ==================== array item get/set start ====================
    
    
    // ==================== array item get/set end ====================
    // ==================== operator start ====================
    // ==================== operator end ====================
    // ==================== events start ====================
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
