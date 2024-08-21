#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_AndroidJNIHelper_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(UnityEngine.AndroidJNIHelper).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetConstructorID(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;

                        var result = UnityEngine.AndroidJNIHelper.GetConstructorID (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        var result = UnityEngine.AndroidJNIHelper.GetConstructorID (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Object[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Object[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Object[] arg1 = (System.Object[])argobj1;

                        var result = UnityEngine.AndroidJNIHelper.GetConstructorID (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetConstructorID");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetMethodID(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        var result = UnityEngine.AndroidJNIHelper.GetMethodID (arg0, arg1);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        string arg2 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.AndroidJNIHelper.GetMethodID (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        string arg2 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value2, false);
                        bool arg3 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.AndroidJNIHelper.GetMethodID (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Object[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Object[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Object[] arg2 = (System.Object[])argobj2;
                        bool arg3 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.AndroidJNIHelper.GetMethodID (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetMethodID");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetFieldID(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        var result = UnityEngine.AndroidJNIHelper.GetFieldID (arg0, arg1);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        string arg2 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.AndroidJNIHelper.GetFieldID (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        string arg2 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value2, false);
                        bool arg3 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.AndroidJNIHelper.GetFieldID (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetFieldID");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_CreateJavaRunnable(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.AndroidJavaRunnable>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.AndroidJavaRunnable arg0 = (UnityEngine.AndroidJavaRunnable)argobj0;

                        var result = UnityEngine.AndroidJNIHelper.CreateJavaRunnable (arg0);

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
        internal static void F_CreateJavaProxy(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.AndroidJavaProxy>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.AndroidJavaProxy arg0 = (UnityEngine.AndroidJavaProxy)argobj0;

                        var result = UnityEngine.AndroidJNIHelper.CreateJavaProxy (arg0);

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
        internal static void F_ConvertToJNIArray(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Array>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Array arg0 = (System.Array)argobj0;

                        var result = UnityEngine.AndroidJNIHelper.ConvertToJNIArray (arg0);

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
        internal static void F_CreateJNIArgArray(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Object[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Object[] arg0 = (System.Object[])argobj0;

                        var result = UnityEngine.AndroidJNIHelper.CreateJNIArgArray (arg0);

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
        internal static void F_DeleteJNIArgArray(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Object[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Object[] arg0 = (System.Object[])argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.jvalue[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.jvalue[] arg1 = (UnityEngine.jvalue[])argobj1;

                        UnityEngine.AndroidJNIHelper.DeleteJNIArgArray (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_GetSignature(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Object arg0 = (System.Object)argobj0;

                        var result = UnityEngine.AndroidJNIHelper.GetSignature (arg0);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Object[]), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Object[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Object[] arg0 = (System.Object[])argobj0;

                        var result = UnityEngine.AndroidJNIHelper.GetSignature (arg0);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetSignature");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Box(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(sbyte), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        sbyte arg0 = (sbyte)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(short), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        short arg0 = (short)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        long arg0 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value0, false);;

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(double), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        double arg0 = (double)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Char arg0 = (System.Char)argobj0;

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.AndroidJNIHelper.Box (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Box");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Unbox(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(sbyte), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        sbyte arg1 = (sbyte)PuertsDLL.GetNumberFromValue(isolate, v8Value1, true);

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<sbyte>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(short), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        short arg1 = (short)PuertsDLL.GetNumberFromValue(isolate, v8Value1, true);

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<short>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, true);

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<int>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.BigInt, typeof(long), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        long arg1 = (long)StaticTranslate<long>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, true);;

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<long>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, true);

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<float>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(double), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        double arg1 = (double)PuertsDLL.GetNumberFromValue(isolate, v8Value1, true);

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<double>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true); System.Char arg1 = (System.Char)argobj1;

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<System.Char>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.IntPtr), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), true, true, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.IntPtr>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.IntPtr arg0 = (System.IntPtr)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, true);

                        UnityEngine.AndroidJNIHelper.Unbox (arg0, out arg1);

                        StaticTranslate<bool>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Unbox");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_debug(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.AndroidJNIHelper.debug;
                Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void S_debug(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                UnityEngine.AndroidJNIHelper.debug = arg0;
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
