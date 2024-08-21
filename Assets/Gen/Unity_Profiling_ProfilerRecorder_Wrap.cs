#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class Unity_Profiling_ProfilerRecorder_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value2, ref argobj2, ref argType2))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        Unity.Profiling.ProfilerRecorderOptions arg2 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerCategory), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerCategory>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerCategory arg0 = (Unity.Profiling.ProfilerCategory)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerMarker), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value2, ref argobj2, ref argType2))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerMarker>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerMarker arg0 = (Unity.Profiling.ProfilerMarker)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        Unity.Profiling.ProfilerRecorderOptions arg2 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value2, ref argobj2, ref argType2))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle arg0 = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        Unity.Profiling.ProfilerRecorderOptions arg2 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerCategory), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerCategory>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerCategory arg0 = (Unity.Profiling.ProfilerCategory)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerMarker), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerMarker>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerMarker arg0 = (Unity.Profiling.ProfilerMarker)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle arg0 = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                }
                if (paramLen == 1)
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerMarker), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerMarker>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerMarker arg0 = (Unity.Profiling.ProfilerMarker)argobj0;
                        var result = new Unity.Profiling.ProfilerRecorder(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle arg0 = (Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle)argobj0;
                        var result = new Unity.Profiling.ProfilerRecorder(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value3, ref argobj3, ref argType3))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        Unity.Profiling.ProfilerRecorderOptions arg3 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2, arg3);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerCategory), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value3, ref argobj3, ref argType3))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerCategory>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerCategory arg0 = (Unity.Profiling.ProfilerCategory)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        Unity.Profiling.ProfilerRecorderOptions arg3 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        var result = new Unity.Profiling.ProfilerRecorder(arg0, arg1, arg2, arg3);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                }
                if (paramLen == 0)
                {

                    {
                        var result = new Unity.Profiling.ProfilerRecorder();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Unity.Profiling.ProfilerRecorder), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(Unity.Profiling.ProfilerRecorder).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_StartNew(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerCategory), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerCategory>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerCategory arg0 = (Unity.Profiling.ProfilerCategory)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        Unity.Profiling.ProfilerRecorderOptions arg3 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = Unity.Profiling.ProfilerRecorder.StartNew (arg0, arg1, arg2, arg3);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerCategory), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerCategory>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerCategory arg0 = (Unity.Profiling.ProfilerCategory)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = Unity.Profiling.ProfilerRecorder.StartNew (arg0, arg1, arg2, Unity.Profiling.ProfilerRecorderOptions.Default);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerMarker), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(Unity.Profiling.ProfilerRecorderOptions), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerMarker>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerMarker arg0 = (Unity.Profiling.ProfilerMarker)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        Unity.Profiling.ProfilerRecorderOptions arg2 = (Unity.Profiling.ProfilerRecorderOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);

                        var result = Unity.Profiling.ProfilerRecorder.StartNew (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerCategory), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerCategory>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerCategory arg0 = (Unity.Profiling.ProfilerCategory)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        var result = Unity.Profiling.ProfilerRecorder.StartNew (arg0, arg1, 1, Unity.Profiling.ProfilerRecorderOptions.Default);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerMarker), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerMarker>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerMarker arg0 = (Unity.Profiling.ProfilerMarker)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = Unity.Profiling.ProfilerRecorder.StartNew (arg0, arg1, Unity.Profiling.ProfilerRecorderOptions.Default);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Unity.Profiling.ProfilerMarker), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<Unity.Profiling.ProfilerMarker>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); Unity.Profiling.ProfilerMarker arg0 = (Unity.Profiling.ProfilerMarker)argobj0;

                        var result = Unity.Profiling.ProfilerRecorder.StartNew (arg0, 1, Unity.Profiling.ProfilerRecorderOptions.Default);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to StartNew");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Start(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        obj.Start ();

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
        internal static void M_Stop(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        obj.Stop ();

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
        internal static void M_Reset(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        obj.Reset ();

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
        internal static void M_GetSample(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = obj.GetSample (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
        internal static void M_CopyTo(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample> arg0 = (System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);

                        obj.CopyTo (arg0, arg1);

                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample> arg0 = (System.Collections.Generic.List<Unity.Profiling.ProfilerRecorderSample>)argobj0;

                        obj.CopyTo (arg0, false);

                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CopyTo");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ToArray(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        var result = obj.ToArray ();

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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
        internal static void M_Dispose(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        obj.Dispose ();

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
        internal static void G_Valid(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.Valid;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_DataType(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.DataType;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (byte)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_UnitType(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.UnitType;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, (byte)result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_CurrentValue(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.CurrentValue;
                Puerts.PuertsDLL.ReturnBigInt(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_CurrentValueAsDouble(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.CurrentValueAsDouble;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_LastValue(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.LastValue;
                Puerts.PuertsDLL.ReturnBigInt(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_LastValueAsDouble(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.LastValueAsDouble;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_Capacity(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.Capacity;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_Count(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.Count;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_IsRunning(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.IsRunning;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_WrappedAround(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (Unity.Profiling.ProfilerRecorder)Puerts.Utils.GetSelf((int)data, self);
                var result = obj.WrappedAround;
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
