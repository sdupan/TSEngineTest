using Puerts;
using System.IO;
using UnityEngine;

public class JSLoader : ILoader
{
    public JSLoader()
    {

    }

    public bool FileExists(string filepath)
    {
        return true;
    }

    public string ReadFile(string filepath, out string debugpath)
    {
        var jscache = JSManager.jscache;
        debugpath = filepath;

#if UNITY_EDITOR
        debugpath = Application.dataPath + "/../TsProj/bin/" + filepath;
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        debugpath = debugpath.Replace("/", "\\");
#endif
        debugpath = debugpath.Replace(".mjs", ".js");
        debugpath = debugpath.Replace(".cjs", ".js");
        debugpath = System.IO.Path.GetFullPath(debugpath);
#endif

        // UnityEngine.Debug.Log("[JSLoader] - " + debugpath);

        string jsName = filepath.Replace("puerts/", "");
        jsName = jsName.Replace("puer-commonjs/", "");
        jsName = jsName.Replace(".mjs", "");
        jsName = jsName.Replace(".js", "");
        jsName = jsName.Replace(".cjs", "");
        jscache.TryGetValue(jsName, out string txt);
        if (txt == null)
        {
            txt = "";
        }

        return txt;
    }
}