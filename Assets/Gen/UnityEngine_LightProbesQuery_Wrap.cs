#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_LightProbesQuery_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen == 1)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Collections.Allocator), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        Unity.Collections.Allocator arg0 = (Unity.Collections.Allocator)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                        var result = new UnityEngine.LightProbesQuery(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.LightProbesQuery), result);
                    }
                }
                if (paramLen == 0)
                {

                    {
                        var result = new UnityEngine.LightProbesQuery();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.LightProbesQuery), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.LightProbesQuery).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Dispose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.LightProbesQuery)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 0)
                {
            
                    {

                        obj.Dispose ();

                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Jobs.JobHandle), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Jobs.JobHandle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Jobs.JobHandle arg0 = (Unity.Jobs.JobHandle)argobj0;

                        var result = obj.Dispose (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Dispose");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_CalculateInterpolatedLightAndOcclusionProbe(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.LightProbesQuery)Puerts.Utils.GetSelf((int)data, self);
        
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, true);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Rendering.SphericalHarmonicsL2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, true); UnityEngine.Rendering.SphericalHarmonicsL2 arg2 = (UnityEngine.Rendering.SphericalHarmonicsL2)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, true); UnityEngine.Vector4 arg3 = (UnityEngine.Vector4)argobj3;

                        obj.CalculateInterpolatedLightAndOcclusionProbe (arg0, ref arg1, out arg2, out arg3);

                        StaticTranslate<int>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        StaticTranslate<UnityEngine.Rendering.SphericalHarmonicsL2>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value2, arg2);
                        StaticTranslate<UnityEngine.Vector4>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value3, arg3);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_CalculateInterpolatedLightAndOcclusionProbes(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.LightProbesQuery)Puerts.Utils.GetSelf((int)data, self);
        
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Collections.NativeArray<UnityEngine.Vector3> arg0 = (Unity.Collections.NativeArray<UnityEngine.Vector3>)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<Unity.Collections.NativeArray<int>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); Unity.Collections.NativeArray<int> arg1 = (Unity.Collections.NativeArray<int>)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> arg2 = (Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2>)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<Unity.Collections.NativeArray<UnityEngine.Vector4>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); Unity.Collections.NativeArray<UnityEngine.Vector4> arg3 = (Unity.Collections.NativeArray<UnityEngine.Vector4>)argobj3;

                        obj.CalculateInterpolatedLightAndOcclusionProbes (arg0, arg1, arg2, arg3);

                        Puerts.Utils.SetSelf((int)data, self, obj);
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
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_IsCreated(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.LightProbesQuery)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.IsCreated;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
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
