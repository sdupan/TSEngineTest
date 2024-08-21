#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_HashUtilities_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.HashUtilities).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_AppendHash(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true); UnityEngine.Hash128 arg0 = (UnityEngine.Hash128)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true); UnityEngine.Hash128 arg1 = (UnityEngine.Hash128)argobj1;

                        UnityEngine.HashUtilities.AppendHash (ref arg0, ref arg1);

                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_QuantisedMatrixHash(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Matrix4x4>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true); UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true); UnityEngine.Hash128 arg1 = (UnityEngine.Hash128)argobj1;

                        UnityEngine.HashUtilities.QuantisedMatrixHash (ref arg0, ref arg1);

                        StaticTranslate<UnityEngine.Matrix4x4>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_QuantisedVectorHash(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector3>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, true); UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true); UnityEngine.Hash128 arg1 = (UnityEngine.Hash128)argobj1;

                        UnityEngine.HashUtilities.QuantisedVectorHash (ref arg0, ref arg1);

                        StaticTranslate<UnityEngine.Vector3>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value0, arg0);
                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ComputeHash128(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<byte[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); byte[] arg0 = (byte[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Hash128>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true); UnityEngine.Hash128 arg1 = (UnityEngine.Hash128)argobj1;

                        UnityEngine.HashUtilities.ComputeHash128 (arg0, ref arg1);

                        StaticTranslate<UnityEngine.Hash128>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
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
