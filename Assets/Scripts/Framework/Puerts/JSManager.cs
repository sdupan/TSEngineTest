using Puerts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityTSGame;
using UnityEngine;

public class JSManager
{
    public static Dictionary<string, string> jscache = new();

    public static Action JsOnApplicationQuit;
    public static Action JsOnDispose;
    public static Action JsOnUpdate;
    public static Action JsOnFixedUpdate;
    public static Action<bool> JsOnApplicationFocus;
    public static Action<bool> JsOnApplicationPause;

    public static float deltaTime = 0;

    public static UnityEngine.GameObject gameRootObject;

    private static JsEnv jsEnv = null;
    private static bool _breakPoint = false;

    public static void Update()
    {
        deltaTime = UnityEngine.Time.unscaledDeltaTime;
        jsEnv?.Tick();
        JsOnUpdate?.Invoke();
    }

    public static void FixedUpdate()
    {
        JsOnFixedUpdate?.Invoke();
    }

    public static JsEnv GetJSEnv()
    {
        return jsEnv;
    }

    public static bool JSEnvDisposed()
    {
        return jsEnv == null;
    }

    protected static async Task InitJsEnv()
    {
#if UNITY_EDITOR
        //_breakPoint = true;
#endif

        //预加载JS ，在JSEnv初始化前调用
        await ResourceManager.PreloadJS(AddressableConfig.GAME_JS_LABEL);

        jsEnv = new JsEnv(new JSLoader(), _breakPoint ? 8080 : -1);
        if (jsEnv == null)
        {
            Debug.LogError("[JSManager] - InitJsEnv null!!!");
        }
        else
        {
            Puerts.ThirdParty.CommonJS.InjectSupportForCJS(jsEnv);
            PuertsStaticWrap.AutoStaticCodeUsing.AutoUsing(jsEnv);
        }
    }

    public static async Task StartGame()
    {
        await InitJsEnv();

        if (jsEnv != null)
        {
            try
            {
                // 调试环境
                if (_breakPoint)
                {
                    await jsEnv.WaitDebuggerAsync();
                }
                jsEnv.Eval(@"require('bundle')");
            }
            catch (Exception e)
            {
                Debug.LogError("[JSManager] - StartGame Exception" + e.ToString());
            }
        }
    }

    public static async void Restart()
    {
        Dispose();
        await StartGame();
    }

    public static void OnApplicationQuit()
    {
        if (jsEnv != null)
        {
            JsOnApplicationQuit?.Invoke();
        }
    }

    public static void OnApplicationFocus(bool focusStatus)
    {
        if (jsEnv != null)
        {
            JsOnApplicationFocus?.Invoke(focusStatus);
        }
    }

    public static void OnApplicationPause(bool pauseStatus)
    {
        if (jsEnv != null)
        {
            JsOnApplicationPause?.Invoke(pauseStatus);
        }
    }

    public static void Dispose()
    {
        JsOnDispose?.Invoke();

        if (jsEnv != null)
        {
            try
            {
                jsEnv.Dispose();
                jsEnv = null;
            }
            catch (Exception ex)
            {
                string msg = string.Format("js exception : {0}\n {1}", ex.Message, ex.StackTrace);
                Debug.LogError("[JSManager] - Dispose Exception " + msg);
            }
        }
    }
}

