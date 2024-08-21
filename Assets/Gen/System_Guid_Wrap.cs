#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class System_Guid_Wrap 
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(byte[]), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<byte[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); byte[] arg0 = (byte[])argobj0;
                        var result = new System.Guid(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Guid), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))

                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        var result = new System.Guid(arg0);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Guid), result);
                    }
                }
                if (paramLen == 11)
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
                    IntPtr v8Value8 = PuertsDLL.GetArgumentValue(info, 8);
                    object argobj8 = null;
                    JsValueType argType8 = JsValueType.Invalid;
                    IntPtr v8Value9 = PuertsDLL.GetArgumentValue(info, 9);
                    object argobj9 = null;
                    JsValueType argType9 = JsValueType.Invalid;
                    IntPtr v8Value10 = PuertsDLL.GetArgumentValue(info, 10);
                    object argobj10 = null;
                    JsValueType argType10 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(uint), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(ushort), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(ushort), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value10, ref argobj10, ref argType10))

                    {
                        uint arg0 = (uint)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        ushort arg1 = (ushort)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        ushort arg2 = (ushort)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        byte arg3 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        byte arg4 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        byte arg5 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        byte arg6 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        byte arg7 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);
                        byte arg8 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        byte arg9 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        byte arg10 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value10, false);
                        var result = new System.Guid(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Guid), result);
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(short), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(short), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value7, ref argobj7, ref argType7) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value8, ref argobj8, ref argType8) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value9, ref argobj9, ref argType9) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(byte), false, false, v8Value10, ref argobj10, ref argType10))

                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        short arg1 = (short)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        short arg2 = (short)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        byte arg3 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        byte arg4 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        byte arg5 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        byte arg6 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);
                        byte arg7 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);
                        byte arg8 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value8, false);
                        byte arg9 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value9, false);
                        byte arg10 = (byte)PuertsDLL.GetNumberFromValue(isolate, v8Value10, false);
                        var result = new System.Guid(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Guid), result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(short), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(short), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(byte[]), false, false, v8Value3, ref argobj3, ref argType3))

                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        short arg1 = (short)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        short arg2 = (short)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<byte[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); byte[] arg3 = (byte[])argobj3;
                        var result = new System.Guid(arg0, arg1, arg2, arg3);


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Guid), result);
                    }
                }
                if (paramLen == 0)
                {

                    {
                        var result = new System.Guid();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(System.Guid), result);
                    }
                }

                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to " + typeof(System.Guid).GetFriendlyName() + " constructor");
            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_NewGuid(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        var result = System.Guid.NewGuid ();

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
        internal static void F_Parse(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = System.Guid.Parse (arg0);

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
        internal static void F_TryParse(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, true); System.Guid arg1 = (System.Guid)argobj1;

                        var result = System.Guid.TryParse (arg0, out arg1);

                        StaticTranslate<System.Guid>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value1, arg1);
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_ParseExact(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        var result = System.Guid.ParseExact (arg0, arg1);

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
        internal static void F_TryParseExact(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, true); System.Guid arg2 = (System.Guid)argobj2;

                        var result = System.Guid.TryParseExact (arg0, arg1, out arg2);

                        StaticTranslate<System.Guid>.Set((int)data, isolate, Puerts.NativeValueApi.SetValueToByRefArgument, v8Value2, arg2);
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_ToByteArray(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (System.Guid)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        var result = obj.ToByteArray ();

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
        internal static void M_ToString(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (System.Guid)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 0)
                {
            
                    {

                        var result = obj.ToString ();

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
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

                        var result = obj.ToString (arg0);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.IFormatProvider), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.IFormatProvider>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.IFormatProvider arg1 = (System.IFormatProvider)argobj1;

                        var result = obj.ToString (arg0, arg1);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to ToString");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetHashCode(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (System.Guid)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 0)
                {
            
                    {

                        var result = obj.GetHashCode ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetHashCode");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Equals(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (System.Guid)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Object arg0 = (System.Object)argobj0;

                        var result = obj.Equals (arg0);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Guid), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Guid arg0 = (System.Guid)argobj0;

                        var result = obj.Equals (arg0);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Equals");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_CompareTo(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (System.Guid)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Any, typeof(System.Object), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Object>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Object arg0 = (System.Object)argobj0;

                        var result = obj.CompareTo (arg0);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(System.Guid), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Guid arg0 = (System.Guid)argobj0;

                        var result = obj.CompareTo (arg0);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CompareTo");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_Empty(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = System.Guid.Empty;
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
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void O_op_Equality(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Guid arg0 = (System.Guid)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Guid arg1 = (System.Guid)argobj1;
                        var result = arg0 == arg1;
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void O_op_Inequality(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                {
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); System.Guid arg0 = (System.Guid)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Guid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Guid arg1 = (System.Guid)argobj1;
                        var result = arg0 != arg1;
                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== operator end ====================
    // ==================== events start ====================
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
