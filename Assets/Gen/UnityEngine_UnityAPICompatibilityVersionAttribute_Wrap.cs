#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_UnityAPICompatibilityVersionAttribute_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                if (paramLen == 2)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        var result = new UnityEngine.UnityAPICompatibilityVersionAttribute(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UnityAPICompatibilityVersionAttribute), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        var result = new UnityEngine.UnityAPICompatibilityVersionAttribute(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.UnityAPICompatibilityVersionAttribute), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.UnityAPICompatibilityVersionAttribute).GetFriendlyName() + " constructor");
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
        internal static void G_version(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as UnityEngine.UnityAPICompatibilityVersionAttribute;
                var result = obj.version;
                Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
