#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class Spine_SkeletonJson_Wrap 
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(Spine.AttachmentLoader), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Spine.AttachmentLoader>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Spine.AttachmentLoader arg0 = (Spine.AttachmentLoader)argobj0;
                        var result = new Spine.SkeletonJson(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Spine.SkeletonJson), result);
                    }
                }
                if (paramLen >= 0)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(Spine.Atlas), 0, paramLen, v8Value0, ref argobj0, ref argType0))

                    {
                        Spine.Atlas[] arg0 = ArgHelper.GetParams<Spine.Atlas>((int)data, isolate, info, 0, paramLen, v8Value0);
                        var result = new Spine.SkeletonJson(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Spine.SkeletonJson), result);
                    }
                }
                if (paramLen == 0)
                {

                    {
                        var result = new Spine.SkeletonJson();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Spine.SkeletonJson), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(Spine.SkeletonJson).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ReadSkeletonData(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Spine.SkeletonJson;
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = obj.ReadSkeletonData (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.IO.TextReader), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IO.TextReader>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IO.TextReader arg0 = (System.IO.TextReader)argobj0;

                        var result = obj.ReadSkeletonData (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ReadSkeletonData");
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
