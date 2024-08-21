#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class TMPro_TMP_FontAssetUtilities_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new TMPro.TMP_FontAssetUtilities();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(TMPro.TMP_FontAssetUtilities), result);
                    }
                }

            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetCharacterFromFontAsset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(info, 5);
                    object argobj5 = null;
                    ;
                    {
                        uint arg0 = (uint)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<TMPro.TMP_FontAsset>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); TMPro.TMP_FontAsset arg1 = (TMPro.TMP_FontAsset)argobj1;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        TMPro.FontStyles arg3 = (TMPro.FontStyles)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        TMPro.FontWeight arg4 = (TMPro.FontWeight)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value4, false);
                        bool arg5 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value5, true);

                        var result = TMPro.TMP_FontAssetUtilities.GetCharacterFromFontAsset (arg0, arg1, arg2, arg3, arg4, out arg5);

                        StaticTranslate<bool>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value5, arg5);
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
        internal static void F_GetCharacterFromFontAssets(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(info, 5);
                    object argobj5 = null;
                    ;
                    IntPtr v8Value6 = PuertsDLL.GetArgumentValue(info, 6);
                    object argobj6 = null;
                    ;
                    {
                        uint arg0 = (uint)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<TMPro.TMP_FontAsset>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); TMPro.TMP_FontAsset arg1 = (TMPro.TMP_FontAsset)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Collections.Generic.List<TMPro.TMP_FontAsset>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Collections.Generic.List<TMPro.TMP_FontAsset> arg2 = (System.Collections.Generic.List<TMPro.TMP_FontAsset>)argobj2;
                        bool arg3 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value3, false);
                        TMPro.FontStyles arg4 = (TMPro.FontStyles)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value4, false);
                        TMPro.FontWeight arg5 = (TMPro.FontWeight)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value5, false);
                        bool arg6 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value6, true);

                        var result = TMPro.TMP_FontAssetUtilities.GetCharacterFromFontAssets (arg0, arg1, arg2, arg3, arg4, arg5, out arg6);

                        StaticTranslate<bool>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value6, arg6);
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
        internal static void F_GetSpriteCharacterFromSpriteAsset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    {
                        uint arg0 = (uint)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<TMPro.TMP_SpriteAsset>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); TMPro.TMP_SpriteAsset arg1 = (TMPro.TMP_SpriteAsset)argobj1;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        var result = TMPro.TMP_FontAssetUtilities.GetSpriteCharacterFromSpriteAsset (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
        internal static void G_instance(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = TMPro.TMP_FontAssetUtilities.instance;
                Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
