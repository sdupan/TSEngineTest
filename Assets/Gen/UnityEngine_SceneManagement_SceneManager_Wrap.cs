﻿#if !(EXPERIMENTAL_IL2CPP_PUERTS && ENABLE_IL2CPP)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
    public static class UnityEngine_SceneManagement_SceneManager_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new UnityEngine.SceneManagement.SceneManager();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(UnityEngine.SceneManagement.SceneManager), result);
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
        internal static void F_GetActiveScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    {

                        var result = UnityEngine.SceneManagement.SceneManager.GetActiveScene ();

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
        internal static void F_SetActiveScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.SceneManagement.Scene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.SceneManagement.Scene arg0 = (UnityEngine.SceneManagement.Scene)argobj0;

                        var result = UnityEngine.SceneManagement.SceneManager.SetActiveScene (arg0);

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
        internal static void F_GetSceneByPath(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.GetSceneByPath (arg0);

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
        internal static void F_GetSceneByName(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.GetSceneByName (arg0);

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
        internal static void F_GetSceneByBuildIndex(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex (arg0);

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
        internal static void F_GetSceneAt(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.GetSceneAt (arg0);

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
        internal static void F_CreateScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.CreateSceneParameters), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.CreateSceneParameters>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.CreateSceneParameters arg1 = (UnityEngine.SceneManagement.CreateSceneParameters)argobj1;

                        var result = UnityEngine.SceneManagement.SceneManager.CreateScene (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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

                        var result = UnityEngine.SceneManagement.SceneManager.CreateScene (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to CreateScene");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_MergeScenes(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.SceneManagement.Scene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.SceneManagement.Scene arg0 = (UnityEngine.SceneManagement.Scene)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.Scene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.Scene arg1 = (UnityEngine.SceneManagement.Scene)argobj1;

                        UnityEngine.SceneManagement.SceneManager.MergeScenes (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_MoveGameObjectToScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.GameObject>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.GameObject arg0 = (UnityEngine.GameObject)argobj0;
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.Scene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.Scene arg1 = (UnityEngine.SceneManagement.Scene)argobj1;

                        UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene (arg0, arg1);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_LoadScene(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.LoadSceneMode), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.SceneManagement.LoadSceneMode arg1 = (UnityEngine.SceneManagement.LoadSceneMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        UnityEngine.SceneManagement.SceneManager.LoadScene (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.LoadSceneParameters), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.LoadSceneParameters>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.LoadSceneParameters arg1 = (UnityEngine.SceneManagement.LoadSceneParameters)argobj1;

                        var result = UnityEngine.SceneManagement.SceneManager.LoadScene (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.LoadSceneMode), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.SceneManagement.LoadSceneMode arg1 = (UnityEngine.SceneManagement.LoadSceneMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        UnityEngine.SceneManagement.SceneManager.LoadScene (arg0, arg1);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.LoadSceneParameters), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.LoadSceneParameters>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.LoadSceneParameters arg1 = (UnityEngine.SceneManagement.LoadSceneParameters)argobj1;

                        var result = UnityEngine.SceneManagement.SceneManager.LoadScene (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
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

                        UnityEngine.SceneManagement.SceneManager.LoadScene (arg0);

                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        UnityEngine.SceneManagement.SceneManager.LoadScene (arg0);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to LoadScene");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_LoadSceneAsync(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.LoadSceneMode), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.SceneManagement.LoadSceneMode arg1 = (UnityEngine.SceneManagement.LoadSceneMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.LoadSceneParameters), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.LoadSceneParameters>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.LoadSceneParameters arg1 = (UnityEngine.SceneManagement.LoadSceneParameters)argobj1;

                        var result = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.LoadSceneMode), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.SceneManagement.LoadSceneMode arg1 = (UnityEngine.SceneManagement.LoadSceneMode)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.LoadSceneParameters), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        argobj1 = argobj1 != null ? argobj1 : StaticTranslate<UnityEngine.SceneManagement.LoadSceneParameters>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false); UnityEngine.SceneManagement.LoadSceneParameters arg1 = (UnityEngine.SceneManagement.LoadSceneParameters)argobj1;

                        var result = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to LoadSceneAsync");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void F_UnloadSceneAsync(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
        
                if (paramLen == 1)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);

                        var result = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync (arg0);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.Scene), false, false, v8Value0, ref argobj0, ref argType0))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.SceneManagement.Scene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.SceneManagement.Scene arg0 = (UnityEngine.SceneManagement.Scene)argobj0;

                        var result = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync (arg0);

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
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(int), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.UnloadSceneOptions), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        UnityEngine.SceneManagement.UnloadSceneOptions arg1 = (UnityEngine.SceneManagement.UnloadSceneOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.String, typeof(string), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.UnloadSceneOptions), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        string arg0 = (string)PuertsDLL.GetStringFromValue(isolate, v8Value0, false);
                        UnityEngine.SceneManagement.UnloadSceneOptions arg1 = (UnityEngine.SceneManagement.UnloadSceneOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(UnityEngine.SceneManagement.Scene), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Number, typeof(UnityEngine.SceneManagement.UnloadSceneOptions), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.SceneManagement.Scene>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.SceneManagement.Scene arg0 = (UnityEngine.SceneManagement.Scene)argobj0;
                        UnityEngine.SceneManagement.UnloadSceneOptions arg1 = (UnityEngine.SceneManagement.UnloadSceneOptions)StaticTranslate<int>.Get((int)data, isolate, Puerts.NativeValueApi.GetValueFromArgument, v8Value1, false);

                        var result = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync (arg0, arg1);

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to UnloadSceneAsync");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_sceneCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.SceneManagement.SceneManager.sceneCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_loadedSceneCount(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.SceneManagement.SceneManager.loadedSceneCount;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void G_sceneCountInBuildSettings(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var result = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
                Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
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
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_sceneLoaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> arg0 = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>)argobj0;
                UnityEngine.SceneManagement.SceneManager.sceneLoaded += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_sceneLoaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> arg0 = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>)argobj0;
                UnityEngine.SceneManagement.SceneManager.sceneLoaded -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_sceneUnloaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> arg0 = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)argobj0;
                UnityEngine.SceneManagement.SceneManager.sceneUnloaded += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_sceneUnloaded(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> arg0 = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>)argobj0;
                UnityEngine.SceneManagement.SceneManager.sceneUnloaded -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void A_activeSceneChanged(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> arg0 = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>)argobj0;
                UnityEngine.SceneManagement.SceneManager.activeSceneChanged += arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void R_activeSceneChanged(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                IntPtr v8Value0 = PuertsDLL.GetArgumentValue(info, 0);
                object argobj0 = null;
                argobj0 = argobj0 != null ? argobj0 : StaticTranslate<UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false); UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> arg0 = (UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>)argobj0;
                UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= arg0;
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
