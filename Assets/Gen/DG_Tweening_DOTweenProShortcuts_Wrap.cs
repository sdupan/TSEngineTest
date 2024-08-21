#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class DG_Tweening_DOTweenProShortcuts_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(DG.Tweening.DOTweenProShortcuts).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_DOSpiral(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        float arg6 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        float arg6 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        bool arg7 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value7, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 7)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        float arg6 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, arg5, arg6, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        float arg6 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, arg5, arg6, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, arg5, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, arg5, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, arg4, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, 1f, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(DG.Tweening.SpiralMode), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;
                        DG.Tweening.SpiralMode arg3 = (DG.Tweening.SpiralMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, arg3, 1f, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, DG.Tweening.SpiralMode.Expand, 1f, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<UnityEngine.Vector3>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Nullable<UnityEngine.Vector3>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Nullable<UnityEngine.Vector3> arg2 = (System.Nullable<UnityEngine.Vector3>)argobj2;

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, arg2, DG.Tweening.SpiralMode.Expand, 1f, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Transform), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Transform>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Transform arg0 = (UnityEngine.Transform)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, default(System.Nullable<UnityEngine.Vector3>), DG.Tweening.SpiralMode.Expand, 1f, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rigidbody), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rigidbody>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rigidbody arg0 = (UnityEngine.Rigidbody)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = DG.Tweening.DOTweenProShortcuts.DOSpiral (arg0, arg1, default(System.Nullable<UnityEngine.Vector3>), DG.Tweening.SpiralMode.Expand, 1f, 10f, 0f, false);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DOSpiral");
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
