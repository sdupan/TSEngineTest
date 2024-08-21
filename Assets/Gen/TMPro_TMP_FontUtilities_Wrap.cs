#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class TMPro_TMP_FontUtilities_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(TMPro.TMP_FontUtilities).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_SearchForCharacter(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(TMPro.TMP_FontAsset), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(uint), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(TMPro.TMP_Character), true, true, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<TMPro.TMP_FontAsset>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); TMPro.TMP_FontAsset arg0 = (TMPro.TMP_FontAsset)argobj0;
                        uint arg1 = (uint)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<TMPro.TMP_Character>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, true); TMPro.TMP_Character arg2 = (TMPro.TMP_Character)argobj2;

                        var result = TMPro.TMP_FontUtilities.SearchForCharacter (arg0, arg1, out arg2);

                        StaticTranslate<TMPro.TMP_Character>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value2, arg2);
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<TMPro.TMP_FontAsset>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(uint), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(TMPro.TMP_Character), true, true, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Collections.Generic.List<TMPro.TMP_FontAsset>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Collections.Generic.List<TMPro.TMP_FontAsset> arg0 = (System.Collections.Generic.List<TMPro.TMP_FontAsset>)argobj0;
                        uint arg1 = (uint)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<TMPro.TMP_Character>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, true); TMPro.TMP_Character arg2 = (TMPro.TMP_Character)argobj2;

                        var result = TMPro.TMP_FontUtilities.SearchForCharacter (arg0, arg1, out arg2);

                        StaticTranslate<TMPro.TMP_Character>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value2, arg2);
                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to SearchForCharacter");
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
