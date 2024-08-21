#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_PhysicsScene2D_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.PhysicsScene2D();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.PhysicsScene2D), result);
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
        internal static void M_ToString(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 0)
                {
            
                    {

                        var result = obj.ToString ();

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
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.PhysicsScene2D), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.PhysicsScene2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.PhysicsScene2D arg0 = (UnityEngine.PhysicsScene2D)argobj0;

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
        internal static void M_IsValid(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        var result = obj.IsValid ();

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
        internal static void M_IsEmpty(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    {

                        var result = obj.IsEmpty ();

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
        internal static void M_Simulate(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = obj.Simulate (arg0);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
        internal static void M_Linecast(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.Linecast (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;

                        var result = obj.Linecast (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.RaycastHit2D[] arg2 = (UnityEngine.RaycastHit2D[])argobj2;

                        var result = obj.Linecast (arg0, arg1, arg2, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;

                        var result = obj.Linecast (arg0, arg1, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.RaycastHit2D[] arg2 = (UnityEngine.RaycastHit2D[])argobj2;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.Linecast (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.RaycastHit2D[] arg3 = (UnityEngine.RaycastHit2D[])argobj3;

                        var result = obj.Linecast (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Collections.Generic.List<UnityEngine.RaycastHit2D> arg3 = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)argobj3;

                        var result = obj.Linecast (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Linecast");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Raycast(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.Raycast (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.ContactFilter2D arg3 = (UnityEngine.ContactFilter2D)argobj3;

                        var result = obj.Raycast (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.RaycastHit2D[] arg3 = (UnityEngine.RaycastHit2D[])argobj3;

                        var result = obj.Raycast (arg0, arg1, arg2, arg3, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.Raycast (arg0, arg1, arg2, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.RaycastHit2D[] arg3 = (UnityEngine.RaycastHit2D[])argobj3;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = obj.Raycast (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.ContactFilter2D arg3 = (UnityEngine.ContactFilter2D)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.RaycastHit2D[] arg4 = (UnityEngine.RaycastHit2D[])argobj4;

                        var result = obj.Raycast (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.ContactFilter2D arg3 = (UnityEngine.ContactFilter2D)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Collections.Generic.List<UnityEngine.RaycastHit2D> arg4 = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)argobj4;

                        var result = obj.Raycast (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Raycast");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_CircleCast(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.ContactFilter2D arg4 = (UnityEngine.ContactFilter2D)argobj4;

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.RaycastHit2D[] arg4 = (UnityEngine.RaycastHit2D[])argobj4;

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, arg4, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.RaycastHit2D[] arg4 = (UnityEngine.RaycastHit2D[])argobj4;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.ContactFilter2D arg4 = (UnityEngine.ContactFilter2D)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.RaycastHit2D[] arg5 = (UnityEngine.RaycastHit2D[])argobj5;

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)argobj2;
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.ContactFilter2D arg4 = (UnityEngine.ContactFilter2D)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); System.Collections.Generic.List<UnityEngine.RaycastHit2D> arg5 = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)argobj5;

                        var result = obj.CircleCast (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CircleCast");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_BoxCast(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.ContactFilter2D arg5 = (UnityEngine.ContactFilter2D)argobj5;

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.RaycastHit2D[] arg5 = (UnityEngine.RaycastHit2D[])argobj5;

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, arg5, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.RaycastHit2D[] arg5 = (UnityEngine.RaycastHit2D[])argobj5;
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.ContactFilter2D arg5 = (UnityEngine.ContactFilter2D)argobj5;
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); UnityEngine.RaycastHit2D[] arg6 = (UnityEngine.RaycastHit2D[])argobj6;

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)argobj3;
                        float arg4 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.ContactFilter2D arg5 = (UnityEngine.ContactFilter2D)argobj5;
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); System.Collections.Generic.List<UnityEngine.RaycastHit2D> arg6 = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)argobj6;

                        var result = obj.BoxCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to BoxCast");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_CapsuleCast(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        int arg6 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value6, false);

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); UnityEngine.ContactFilter2D arg6 = (UnityEngine.ContactFilter2D)argobj6;

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); UnityEngine.RaycastHit2D[] arg6 = (UnityEngine.RaycastHit2D[])argobj6;

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); UnityEngine.RaycastHit2D[] arg6 = (UnityEngine.RaycastHit2D[])argobj6;
                        int arg7 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value7, false);

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); UnityEngine.ContactFilter2D arg6 = (UnityEngine.ContactFilter2D)argobj6;
                        argobj7 = argobj7 != null ? argobj7 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false); UnityEngine.RaycastHit2D[] arg7 = (UnityEngine.RaycastHit2D[])argobj7;

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value6, ref argobj6, ref argType6) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>), false, false, v8Value7, ref argobj7, ref argType7))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Vector2 arg4 = (UnityEngine.Vector2)argobj4;
                        float arg5 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);
                        argobj6 = argobj6 != null ? argobj6 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value6, false); UnityEngine.ContactFilter2D arg6 = (UnityEngine.ContactFilter2D)argobj6;
                        argobj7 = argobj7 != null ? argobj7 : StaticTranslate<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value7, false); System.Collections.Generic.List<UnityEngine.RaycastHit2D> arg7 = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)argobj7;

                        var result = obj.CapsuleCast (arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CapsuleCast");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetRayIntersection(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Ray), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Ray>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Ray arg0 = (UnityEngine.Ray)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.GetRayIntersection (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Ray), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Ray>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Ray arg0 = (UnityEngine.Ray)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.RaycastHit2D[] arg2 = (UnityEngine.RaycastHit2D[])argobj2;

                        var result = obj.GetRayIntersection (arg0, arg1, arg2, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Ray), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Ray>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Ray arg0 = (UnityEngine.Ray)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = obj.GetRayIntersection (arg0, arg1, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Ray), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.RaycastHit2D[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Ray>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Ray arg0 = (UnityEngine.Ray)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.RaycastHit2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.RaycastHit2D[] arg2 = (UnityEngine.RaycastHit2D[])argobj2;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.GetRayIntersection (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to GetRayIntersection");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_OverlapPoint(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = obj.OverlapPoint (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.ContactFilter2D arg1 = (UnityEngine.ContactFilter2D)argobj1;

                        var result = obj.OverlapPoint (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Collider2D[] arg1 = (UnityEngine.Collider2D[])argobj1;

                        var result = obj.OverlapPoint (arg0, arg1, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;

                        var result = obj.OverlapPoint (arg0, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Collider2D[] arg1 = (UnityEngine.Collider2D[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.OverlapPoint (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.ContactFilter2D arg1 = (UnityEngine.ContactFilter2D)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Collider2D[] arg2 = (UnityEngine.Collider2D[])argobj2;

                        var result = obj.OverlapPoint (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.ContactFilter2D arg1 = (UnityEngine.ContactFilter2D)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Collider2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Collections.Generic.List<UnityEngine.Collider2D> arg2 = (System.Collections.Generic.List<UnityEngine.Collider2D>)argobj2;

                        var result = obj.OverlapPoint (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to OverlapPoint");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_OverlapCircle(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.OverlapCircle (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;

                        var result = obj.OverlapCircle (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Collider2D[] arg2 = (UnityEngine.Collider2D[])argobj2;

                        var result = obj.OverlapCircle (arg0, arg1, arg2, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = obj.OverlapCircle (arg0, arg1, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Collider2D[] arg2 = (UnityEngine.Collider2D[])argobj2;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.OverlapCircle (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Collider2D[] arg3 = (UnityEngine.Collider2D[])argobj3;

                        var result = obj.OverlapCircle (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Collider2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Collections.Generic.List<UnityEngine.Collider2D> arg3 = (System.Collections.Generic.List<UnityEngine.Collider2D>)argobj3;

                        var result = obj.OverlapCircle (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to OverlapCircle");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_OverlapBox(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.OverlapBox (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.ContactFilter2D arg3 = (UnityEngine.ContactFilter2D)argobj3;

                        var result = obj.OverlapBox (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Collider2D[] arg3 = (UnityEngine.Collider2D[])argobj3;

                        var result = obj.OverlapBox (arg0, arg1, arg2, arg3, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.OverlapBox (arg0, arg1, arg2, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Collider2D[] arg3 = (UnityEngine.Collider2D[])argobj3;
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = obj.OverlapBox (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.ContactFilter2D arg3 = (UnityEngine.ContactFilter2D)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Collider2D[] arg4 = (UnityEngine.Collider2D[])argobj4;

                        var result = obj.OverlapBox (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.ContactFilter2D arg3 = (UnityEngine.ContactFilter2D)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Collider2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); System.Collections.Generic.List<UnityEngine.Collider2D> arg4 = (System.Collections.Generic.List<UnityEngine.Collider2D>)argobj4;

                        var result = obj.OverlapBox (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to OverlapBox");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_OverlapArea(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = obj.OverlapArea (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;

                        var result = obj.OverlapArea (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Collider2D[] arg2 = (UnityEngine.Collider2D[])argobj2;

                        var result = obj.OverlapArea (arg0, arg1, arg2, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;

                        var result = obj.OverlapArea (arg0, arg1, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Collider2D[] arg2 = (UnityEngine.Collider2D[])argobj2;
                        int arg3 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.OverlapArea (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Collider2D[] arg3 = (UnityEngine.Collider2D[])argobj3;

                        var result = obj.OverlapArea (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.ContactFilter2D arg2 = (UnityEngine.ContactFilter2D)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Collider2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); System.Collections.Generic.List<UnityEngine.Collider2D> arg3 = (System.Collections.Generic.List<UnityEngine.Collider2D>)argobj3;

                        var result = obj.OverlapArea (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to OverlapArea");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_OverlapCapsule(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = (UnityEngine.PhysicsScene2D)Puerts.Utils.GetSelf((int)data, self);
        
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        int arg4 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value4, false);

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.ContactFilter2D arg4 = (UnityEngine.ContactFilter2D)argobj4;

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Collider2D[] arg4 = (UnityEngine.Collider2D[])argobj4;

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, arg4, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, -5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.Collider2D[] arg4 = (UnityEngine.Collider2D[])argobj4;
                        int arg5 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value5, false);

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.ContactFilter2D arg4 = (UnityEngine.ContactFilter2D)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.Collider2D[] arg5 = (UnityEngine.Collider2D[])argobj5;

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.CapsuleDirection2D), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)argobj1;
                        UnityEngine.CapsuleDirection2D arg2 = (UnityEngine.CapsuleDirection2D)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.ContactFilter2D arg4 = (UnityEngine.ContactFilter2D)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Collider2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); System.Collections.Generic.List<UnityEngine.Collider2D> arg5 = (System.Collections.Generic.List<UnityEngine.Collider2D>)argobj5;

                        var result = obj.OverlapCapsule (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        Puerts.Utils.SetSelf((int)data, self, obj);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to OverlapCapsule");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_OverlapCollider(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Collider2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Collider2D[] arg1 = (UnityEngine.Collider2D[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.PhysicsScene2D.OverlapCollider (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Collider2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.ContactFilter2D arg1 = (UnityEngine.ContactFilter2D)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.Collider2D[] arg2 = (UnityEngine.Collider2D[])argobj2;

                        var result = UnityEngine.PhysicsScene2D.OverlapCollider (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.ContactFilter2D), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Collider2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.ContactFilter2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.ContactFilter2D arg1 = (UnityEngine.ContactFilter2D)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<System.Collections.Generic.List<UnityEngine.Collider2D>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); System.Collections.Generic.List<UnityEngine.Collider2D> arg2 = (System.Collections.Generic.List<UnityEngine.Collider2D>)argobj2;

                        var result = UnityEngine.PhysicsScene2D.OverlapCollider (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Collider2D[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Collider2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Collider2D[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Collider2D[] arg1 = (UnityEngine.Collider2D[])argobj1;

                        var result = UnityEngine.PhysicsScene2D.OverlapCollider (arg0, arg1, -5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to OverlapCollider");
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.PhysicsScene2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.PhysicsScene2D arg0 = (UnityEngine.PhysicsScene2D)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.PhysicsScene2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.PhysicsScene2D arg1 = (UnityEngine.PhysicsScene2D)argobj1;
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.PhysicsScene2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.PhysicsScene2D arg0 = (UnityEngine.PhysicsScene2D)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.PhysicsScene2D>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.PhysicsScene2D arg1 = (UnityEngine.PhysicsScene2D)argobj1;
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
