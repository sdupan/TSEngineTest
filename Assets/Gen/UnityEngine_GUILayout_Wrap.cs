#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_GUILayout_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.GUILayout();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.GUILayout), result);
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
        internal static void F_Label(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.Label (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.Label (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.Label (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;

                        UnityEngine.GUILayout.Label (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        UnityEngine.GUILayout.Label (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;

                        UnityEngine.GUILayout.Label (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.Label (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.Label (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.Label (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.Label (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.Label (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.Label (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Label");
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
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.Box (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.Box (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.Box (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;

                        UnityEngine.GUILayout.Box (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        UnityEngine.GUILayout.Box (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;

                        UnityEngine.GUILayout.Box (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.Box (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.Box (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.Box (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.Box (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.Box (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.Box (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

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
        internal static void F_Button(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.Button (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.Button (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.Button (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;

                        var result = UnityEngine.GUILayout.Button (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.Button (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;

                        var result = UnityEngine.GUILayout.Button (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Button (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Button (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Button (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.Button (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.Button (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.Button (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Button");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_RepeatButton(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.RepeatButton (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to RepeatButton");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_TextField(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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

                        var result = UnityEngine.GUILayout.TextField (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.TextField (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to TextField");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_PasswordField(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(System.Char), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<System.Char>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); System.Char arg1 = (System.Char)argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;

                        var result = UnityEngine.GUILayout.PasswordField (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to PasswordField");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_TextArea(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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

                        var result = UnityEngine.GUILayout.TextArea (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.TextArea (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnString(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to TextArea");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Toggle(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture arg1 = (UnityEngine.Texture)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture arg1 = (UnityEngine.Texture)argobj1;

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)argobj1;

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture arg1 = (UnityEngine.Texture)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture arg1 = (UnityEngine.Texture)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.Toggle (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Toggle");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Toolbar(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUI.ToolbarButtonSize arg3 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUI.ToolbarButtonSize arg3 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUI.ToolbarButtonSize arg3 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(bool[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<bool[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); bool[] arg2 = (bool[])argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUI.ToolbarButtonSize arg3 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUI.ToolbarButtonSize arg3 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUI.ToolbarButtonSize arg3 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value3, false);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(bool[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<bool[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); bool[] arg2 = (bool[])argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(bool[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<bool[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); bool[] arg2 = (bool[])argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUI.ToolbarButtonSize arg4 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value4, false);
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(bool[]), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.GUI.ToolbarButtonSize), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<bool[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); bool[] arg2 = (bool[])argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUI.ToolbarButtonSize arg4 = (UnityEngine.GUI.ToolbarButtonSize)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value4, false);

                        var result = UnityEngine.GUILayout.Toolbar (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Toolbar");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_SelectionGrid(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(string[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<string[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); string[] arg1 = (string[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture[] arg1 = (UnityEngine.Texture[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent[]), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent[]>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent[] arg1 = (UnityEngine.GUIContent[])argobj1;
                        int arg2 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;

                        var result = UnityEngine.GUILayout.SelectionGrid (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to SelectionGrid");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_HorizontalSlider(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.HorizontalSlider (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.HorizontalSlider (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.HorizontalSlider (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.HorizontalSlider (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to HorizontalSlider");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_VerticalSlider(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.VerticalSlider (arg0, arg1, arg2, arg3);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.VerticalSlider (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.VerticalSlider (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.VerticalSlider (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to VerticalSlider");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_HorizontalScrollbar(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.HorizontalScrollbar (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.GUILayout.HorizontalScrollbar (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.HorizontalScrollbar (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.HorizontalScrollbar (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to HorizontalScrollbar");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_VerticalScrollbar(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.VerticalScrollbar (arg0, arg1, arg2, arg3, arg4);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.GUILayout.VerticalScrollbar (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.VerticalScrollbar (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(float), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        float arg1 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);
                        float arg2 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value2, false);
                        float arg3 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.VerticalScrollbar (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to VerticalScrollbar");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Space(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        UnityEngine.GUILayout.Space (arg0);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_FlexibleSpace(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        UnityEngine.GUILayout.FlexibleSpace ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_BeginHorizontal(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 0)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 0, paramLen, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.GUILayoutOption[] arg0 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 0, paramLen, v8Value0);

                        UnityEngine.GUILayout.BeginHorizontal (arg0);

                        return;
                    }
                }
                if (paramLen == 0)
                {
            
                    {

                        UnityEngine.GUILayout.BeginHorizontal (System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)argobj0;

                        UnityEngine.GUILayout.BeginHorizontal (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginHorizontal (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to BeginHorizontal");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_EndHorizontal(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        UnityEngine.GUILayout.EndHorizontal ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_BeginVertical(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 0)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 0, paramLen, v8Value0, ref argobj0, ref argType0))
                    {
                        UnityEngine.GUILayoutOption[] arg0 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 0, paramLen, v8Value0);

                        UnityEngine.GUILayout.BeginVertical (arg0);

                        return;
                    }
                }
                if (paramLen == 0)
                {
            
                    {

                        UnityEngine.GUILayout.BeginVertical (System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1);

                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIStyle arg0 = (UnityEngine.GUIStyle)argobj0;

                        UnityEngine.GUILayout.BeginVertical (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1, arg2);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Texture arg0 = (UnityEngine.Texture)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GUIContent arg0 = (UnityEngine.GUIContent)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginVertical (arg0, arg1, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to BeginVertical");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_EndVertical(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        UnityEngine.GUILayout.EndVertical ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_BeginArea(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;

                        UnityEngine.GUILayout.BeginArea (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);

                        UnityEngine.GUILayout.BeginArea (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture arg1 = (UnityEngine.Texture)argobj1;

                        UnityEngine.GUILayout.BeginArea (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)argobj1;

                        UnityEngine.GUILayout.BeginArea (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        UnityEngine.GUILayout.BeginArea (arg0, arg1);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        string arg1 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value1, false);
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        UnityEngine.GUILayout.BeginArea (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Texture arg1 = (UnityEngine.Texture)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        UnityEngine.GUILayout.BeginArea (arg0, arg1, arg2);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Rect arg0 = (UnityEngine.Rect)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIContent arg1 = (UnityEngine.GUIContent)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        UnityEngine.GUILayout.BeginArea (arg0, arg1, arg2);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to BeginArea");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_EndArea(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        UnityEngine.GUILayout.EndArea ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_BeginScrollView(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 1, paramLen, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        UnityEngine.GUILayoutOption[] arg1 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 1, paramLen, v8Value1);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 3)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, arg3);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 3, paramLen, v8Value3, ref argobj3, ref argType3))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;
                        UnityEngine.GUILayoutOption[] arg3 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 3, paramLen, v8Value3);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, arg3);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUIStyle arg2 = (UnityEngine.GUIStyle)argobj2;

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, System.Array.Empty<UnityEngine.GUILayoutOption>());

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 2)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 2, paramLen, v8Value2, ref argobj2, ref argType2))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.GUIStyle arg1 = (UnityEngine.GUIStyle)argobj1;
                        UnityEngine.GUILayoutOption[] arg2 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 2, paramLen, v8Value2);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, arg3, arg4, arg5);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 6)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value5, ref argobj5, ref argType5) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 6, paramLen, v8Value6, ref argobj6, ref argType6))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.GUIStyle arg5 = (UnityEngine.GUIStyle)argobj5;
                        UnityEngine.GUILayoutOption[] arg6 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 6, paramLen, v8Value6);

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, arg3, arg4, arg5, arg6);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Vector2), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)argobj0;
                        bool arg1 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value1, false);
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIStyle arg3 = (UnityEngine.GUIStyle)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        argobj5 = argobj5 != null ? argobj5 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value5, false); UnityEngine.GUIStyle arg5 = (UnityEngine.GUIStyle)argobj5;

                        var result = UnityEngine.GUILayout.BeginScrollView (arg0, arg1, arg2, arg3, arg4, arg5, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to BeginScrollView");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_EndScrollView(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        UnityEngine.GUILayout.EndScrollView ();

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Window(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen >= 4)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        string arg3 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value3, false);
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Texture arg3 = (UnityEngine.Texture)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 4, paramLen, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIContent arg3 = (UnityEngine.GUIContent)argobj3;
                        UnityEngine.GUILayoutOption[] arg4 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 4, paramLen, v8Value4);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        string arg3 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value3, false);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Texture arg3 = (UnityEngine.Texture)argobj3;

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIContent arg3 = (UnityEngine.GUIContent)argobj3;

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen >= 5)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        string arg3 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Texture arg3 = (UnityEngine.Texture)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4, arg5);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatchParams((int)data, isolate, info, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUILayoutOption), 5, paramLen, v8Value5, ref argobj5, ref argType5))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIContent arg3 = (UnityEngine.GUIContent)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;
                        UnityEngine.GUILayoutOption[] arg5 = ArgHelper.GetParams<UnityEngine.GUILayoutOption>((int)data, isolate, info, 5, paramLen, v8Value5);

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4, arg5);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        string arg3 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value3, false);
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.Texture), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.Texture>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.Texture arg3 = (UnityEngine.Texture)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.Rect), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject | Puerts.JsValueType.Function, typeof(UnityEngine.GUI.WindowFunction), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIContent), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(UnityEngine.GUIStyle), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.Rect>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.Rect arg1 = (UnityEngine.Rect)argobj1;
                        argobj2 = argobj2 != null ? argobj2 : StaticTranslate<UnityEngine.GUI.WindowFunction>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false); UnityEngine.GUI.WindowFunction arg2 = (UnityEngine.GUI.WindowFunction)argobj2;
                        argobj3 = argobj3 != null ? argobj3 : StaticTranslate<UnityEngine.GUIContent>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false); UnityEngine.GUIContent arg3 = (UnityEngine.GUIContent)argobj3;
                        argobj4 = argobj4 != null ? argobj4 : StaticTranslate<UnityEngine.GUIStyle>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value4, false); UnityEngine.GUIStyle arg4 = (UnityEngine.GUIStyle)argobj4;

                        var result = UnityEngine.GUILayout.Window (arg0, arg1, arg2, arg3, arg4, System.Array.Empty<UnityEngine.GUILayoutOption>());

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Window");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_Width(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.Width (arg0);

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
        internal static void F_MinWidth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.MinWidth (arg0);

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
        internal static void F_MaxWidth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.MaxWidth (arg0);

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
        internal static void F_Height(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.Height (arg0);

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
        internal static void F_MinHeight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.MinHeight (arg0);

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
        internal static void F_MaxHeight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        float arg0 = (float)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.MaxHeight (arg0);

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
        internal static void F_ExpandWidth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.ExpandWidth (arg0);

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
        internal static void F_ExpandHeight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        bool arg0 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.GUILayout.ExpandHeight (arg0);

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
