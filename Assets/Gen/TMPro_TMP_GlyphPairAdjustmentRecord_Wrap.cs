#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class TMPro_TMP_GlyphPairAdjustmentRecord_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<TMPro.TMP_GlyphAdjustmentRecord>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); TMPro.TMP_GlyphAdjustmentRecord arg0 = (TMPro.TMP_GlyphAdjustmentRecord)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<TMPro.TMP_GlyphAdjustmentRecord>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); TMPro.TMP_GlyphAdjustmentRecord arg1 = (TMPro.TMP_GlyphAdjustmentRecord)argobj1;
                        var result = new TMPro.TMP_GlyphPairAdjustmentRecord(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(TMPro.TMP_GlyphPairAdjustmentRecord), result);
                    }
                }

            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_firstAdjustmentRecord(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as TMPro.TMP_GlyphPairAdjustmentRecord;
                var result = obj.firstAdjustmentRecord;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_firstAdjustmentRecord(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as TMPro.TMP_GlyphPairAdjustmentRecord;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<TMPro.TMP_GlyphAdjustmentRecord>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); TMPro.TMP_GlyphAdjustmentRecord arg0 = (TMPro.TMP_GlyphAdjustmentRecord)argobj0;
                obj.firstAdjustmentRecord = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_secondAdjustmentRecord(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as TMPro.TMP_GlyphPairAdjustmentRecord;
                var result = obj.secondAdjustmentRecord;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_secondAdjustmentRecord(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as TMPro.TMP_GlyphPairAdjustmentRecord;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<TMPro.TMP_GlyphAdjustmentRecord>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); TMPro.TMP_GlyphAdjustmentRecord arg0 = (TMPro.TMP_GlyphAdjustmentRecord)argobj0;
                obj.secondAdjustmentRecord = arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_featureLookupFlags(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as TMPro.TMP_GlyphPairAdjustmentRecord;
                var result = obj.featureLookupFlags;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (int)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_featureLookupFlags(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as TMPro.TMP_GlyphPairAdjustmentRecord;
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                TMPro.FontFeatureLookupFlags arg0 = (TMPro.FontFeatureLookupFlags)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);
                obj.featureLookupFlags = arg0;
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
