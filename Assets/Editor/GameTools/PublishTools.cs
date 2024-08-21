using System;
using UnityEditor;
using System.Diagnostics;
using System.IO;
using UnityEditor.Build.Reporting;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Build;
using UnityEngine.AddressableAssets;
using UnityTSGame;

[InitializeOnLoad]
public class PublishTools
{
    [Serializable]
    protected class ZooCanteenCatalogData
    {
        public string m_LocatorId;
        public string m_BuildResultHash;
        public string[] m_InternalIds;
    }

    [MenuItem("ZooCanteen/Generate Config JSONs", false, 601)]
    public static void GenerateConfigJsons()
    {
        var start = DateTime.Now;
        var batPath = Application.dataPath + "/../TsProj/zPublishJson.bat";
        processCommand(batPath, "");

        UnityEngine.Debug.Log("Generate Config JSONs finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/SVN Update", false, 701)]
    public static void SvnUpdateDocsDir()
    {
        var start = DateTime.Now;
        var buildExePath = "TortoiseProc.exe";
        var srcDir = Application.dataPath + "/../";
        processCommand(buildExePath, "/command:update /path:\"" + srcDir + "\" /closeonend:0");

        UnityEngine.Debug.Log("SVN Update finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/Generate Protobuf", false, 102)]
    public static void GenerateProtobuf()
    {
        var start = DateTime.Now;
        var hardCodeSavePath = Application.dataPath + "/../TsProj/src/data/hardcode/";
        var srcProtoFileDir = Application.dataPath + "/../../../../design/protobuf/";
        var destProtoFileDir = Application.dataPath + "/../../Protobuf/protofile/";
        var clientProtoFileDir = Application.dataPath + "/../TsProj/src/protofile/";

        // 清空协议生成工程目录下的协议文件
        DirectoryInfo destInfo = new DirectoryInfo(destProtoFileDir);
        FileInfo[] fileInfoArr = destInfo.GetFiles("*.proto", SearchOption.AllDirectories);
        for (int i = 0; i < fileInfoArr.Length; ++i)
        {
            File.Delete(fileInfoArr[i].FullName);
        }

        // 清空客户端脚本工程目录下的协议文件
        destInfo = new DirectoryInfo(clientProtoFileDir);
        fileInfoArr = destInfo.GetFiles("*.proto", SearchOption.AllDirectories);
        for (int i = 0; i < fileInfoArr.Length; ++i)
        {
            File.Delete(fileInfoArr[i].FullName);
        }

        // 拷贝协议文件到客户端脚本工程目录及协议生成工程目录
        DirectoryInfo dirInfo = new DirectoryInfo(srcProtoFileDir);
        fileInfoArr = dirInfo.GetFiles("*.proto", SearchOption.AllDirectories);
        for (int i = 0; i < fileInfoArr.Length; ++i)
        {
            string fullName = fileInfoArr[i].FullName;
            File.Copy(fullName, destProtoFileDir + fileInfoArr[i].Name, true);
            File.Copy(fullName, clientProtoFileDir + fileInfoArr[i].Name, true);
        }

        // 生成协议代码
        var batPath = Application.dataPath + "/../../Protobuf/zpublish.bat";
        processCommand(batPath, "");

        // 修改protobuf-bundles，将window改为global
        var bundlePath = Application.dataPath + "/../../Protobuf/bundles/protobuf-bundles.js";
        String data = File.ReadAllText(bundlePath, System.Text.Encoding.UTF8);
        data = data.Replace("window", "global");
        data = data.Replace("window", "global");
        File.WriteAllText(bundlePath, data, System.Text.Encoding.UTF8);

        bundlePath = Application.dataPath + "/../../Protobuf/bundles/protobuf-bundles.min.js";
        data = File.ReadAllText(bundlePath, System.Text.Encoding.UTF8);
        data = data.Replace("window", "global");
        data = data.Replace("window", "global");
        File.WriteAllText(bundlePath, data, System.Text.Encoding.UTF8);

        // 拷贝生成的代码及协议到工程目录
        var codeRootDir = Application.dataPath + "/../../Protobuf/";
        var clientProtoRootDir = Application.dataPath + "/../TsProj/src/protobuf/";
        var gameAssetsRootDir = Application.dataPath + "/GameAssets/Src/";
        File.Copy(codeRootDir + "bundles/protobuf-bundles.d.ts", clientProtoRootDir + "protobuf-bundles.d.ts", true);
        File.Copy(codeRootDir + "bundles/protobuf-bundles.min.js", gameAssetsRootDir + "protobuf-bundles.bytes", true);

        // 生成映射文件
        var buildExePath = Application.dataPath + "/../../../../design/tools/protoc/build.exe";
        processCommand(buildExePath, "--proto=../../../client/trunk/Protobuf/protofile --type=c --code=../../../client/trunk/ZooCanteen/TsProj/src/protobuf/key");

        UnityEngine.Debug.Log("Generate Protobuf finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/Publish TypeScript", false, 103)]
    public static void PublishTypeScript()
    {
        var start = DateTime.Now;
        var scriptPath = Application.dataPath + "/../TsProj/zpublish.py";
        processCommand(scriptPath, " -merge");

        UnityEngine.Debug.Log("Publish TypeScript finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/RC4 Encrypt Android Bundles(DEV)", false, 106)]
    public static void RC4EncryptAndroidBundles()
    {
        var start = DateTime.Now;

        var fullPath = Application.dataPath + "/../LXYDRemoteRes_Dev/Android/";
        DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
        FileInfo[] files = dirInfo.GetFiles("*.bundle", SearchOption.AllDirectories);
        for (int i = 0; i < files.Length; i++)
        {
            var rc4 = new LXYDRC4();
            byte[] encData = File.ReadAllBytes(files[i].FullName);
            rc4.ToRC4(ref encData, 0, encData.Length);
            File.WriteAllBytes(files[i].FullName, encData);
            UnityEngine.Debug.Log("RC4 Encrypt-->  " + i + "  " + files[i].FullName);
        }

        UnityEngine.Debug.Log("RC4 Encrypt Bundles finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/RC4 Encrypt iOS Bundles(DEV)", false, 107)]
    public static void RC4EncryptIOSBundles()
    {
        var start = DateTime.Now;

        var fullPath = Application.dataPath + "/../LXYDRemoteRes_Dev/iOS/";
        DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
        FileInfo[] files = dirInfo.GetFiles("*.bundle", SearchOption.AllDirectories);
        for (int i = 0; i < files.Length; i++)
        {
            var rc4 = new LXYDRC4();
            byte[] encData = File.ReadAllBytes(files[i].FullName);
            rc4.ToRC4(ref encData, 0, encData.Length);
            File.WriteAllBytes(files[i].FullName, encData);
            UnityEngine.Debug.Log("RC4 Encrypt-->  " + i + "  " + files[i].FullName);
        }

        UnityEngine.Debug.Log("RC4 Encrypt Bundles finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/Build/Build Android", false, 201)]
    public static void BuildApk()
    {
        var oldBuildTarget = EditorUserBuildSettings.activeBuildTarget;
        var oldTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/GameEntry.unity" }
        };
        var rootPath = Application.dataPath + "/../Build";
        Directory.CreateDirectory(rootPath);
        Directory.CreateDirectory(rootPath + "/Android");
        buildPlayerOptions.locationPathName = rootPath + "/Android/ZooCanteen.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        EditorUserBuildSettings.buildAppBundle = false;
        var srcScriptSym = PlayerSettings.GetScriptingDefineSymbols(UnityEditor.Build.NamedBuildTarget.Android);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "FAIRYGUI_PUERTS;FAIRYGUI_SPINE;BFGAME_RELEASE_MODE");
        AssetDatabase.Refresh();
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, srcScriptSym);
        AssetDatabase.Refresh();
        BuildSummary summary = report.summary;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(oldTargetGroup, oldBuildTarget);
        }

        if (summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("Android Build succeeded: " + summary.totalSize + " bytes");
            var fullPath = rootPath + "/Android/";
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyyy_MM_dd_HH_mm_ss");
            File.Move(fullPath + "ZooCanteen.apk", fullPath + "ZooCanteen_Release_" + PlayerSettings.bundleVersion + "_" + PlayerSettings.Android.bundleVersionCode.ToString() + "_" + str + ".apk");
        }
        else if (summary.result == BuildResult.Failed)
        {
            UnityEngine.Debug.Log("Android Build failed");
        }
    }

    [MenuItem("ZooCanteen/Build/Build Android AAB", false, 202)]
    public static void BuildAAB()
    {
        var oldBuildTarget = EditorUserBuildSettings.activeBuildTarget;
        var oldTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/GameEntry.unity" }
        };
        var rootPath = Application.dataPath + "/../Build";
        Directory.CreateDirectory(rootPath);
        Directory.CreateDirectory(rootPath + "/Android");
        buildPlayerOptions.locationPathName = rootPath + "/Android/ZooCanteen.aab";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        EditorUserBuildSettings.buildAppBundle = true;
        var srcScriptSym = PlayerSettings.GetScriptingDefineSymbols(UnityEditor.Build.NamedBuildTarget.Android);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "FAIRYGUI_PUERTS;FAIRYGUI_SPINE;BFGAME_RELEASE_MODE");
        AssetDatabase.Refresh();
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, srcScriptSym);
        AssetDatabase.Refresh();
        BuildSummary summary = report.summary;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(oldTargetGroup, oldBuildTarget);
        }

        if (summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("Android AAB Build succeeded: " + summary.totalSize + " bytes");
            var fullPath = rootPath + "/Android/";
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyyy_MM_dd_HH_mm_ss");
            File.Move(fullPath + "ZooCanteen.aab", fullPath + "ZooCanteen_Release_" + PlayerSettings.bundleVersion + "_" + PlayerSettings.Android.bundleVersionCode.ToString() + "_" + str + ".aab");
        }
        else if (summary.result == BuildResult.Failed)
        {
            UnityEngine.Debug.Log("Android AAB Build failed");
        }
    }

    [MenuItem("ZooCanteen/Build/Build iOS", false, 203)]
    public static void BuildIOS()
    {
        var oldBuildTarget = EditorUserBuildSettings.activeBuildTarget;
        var oldTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        if (oldBuildTarget != BuildTarget.iOS)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/GameEntry.unity" }
        };
        var rootPath = Application.dataPath + "/../Build";
        Directory.CreateDirectory(rootPath);
        Directory.CreateDirectory(rootPath + "/iOS");
        buildPlayerOptions.locationPathName = rootPath + "/iOS/ZooCanteenIOS";
        buildPlayerOptions.target = BuildTarget.iOS;
        buildPlayerOptions.options = BuildOptions.None;
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        BuildSummary summary = report.summary;
        if (oldBuildTarget != BuildTarget.iOS)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(oldTargetGroup, oldBuildTarget);
        }

        if (summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("IOS Build succeeded: " + summary.totalSize + " bytes");
        }
        else if (summary.result == BuildResult.Failed)
        {
            UnityEngine.Debug.Log("IOS Build failed");
        }
    }

    [MenuItem("ZooCanteen/Build/Build Android Develop NO SDK", false, 204)]
    public static void BuildApkDevelopNoSDK()
    {
        var oldBuildTarget = EditorUserBuildSettings.activeBuildTarget;
        var oldTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/GameEntry.unity" }
        };
        var rootPath = Application.dataPath + "/../Build";
        Directory.CreateDirectory(rootPath);
        Directory.CreateDirectory(rootPath + "/Android");
        buildPlayerOptions.locationPathName = rootPath + "/Android/ZooCanteen.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        EditorUserBuildSettings.buildAppBundle = false;
        var srcScriptSym = PlayerSettings.GetScriptingDefineSymbols(UnityEditor.Build.NamedBuildTarget.Android);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "FAIRYGUI_PUERTS;FAIRYGUI_SPINE;BFGAME_DEVELOP_NO_SDK_MODE");
        var lastPkgName = PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.Android);
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.lxyd.ZooCanteen.nosdk");
        AssetDatabase.Refresh();
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, srcScriptSym);
        AssetDatabase.Refresh();
        BuildSummary summary = report.summary;
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, lastPkgName);
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(oldTargetGroup, oldBuildTarget);
        }

        if (summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("Android Develop Build succeeded: " + summary.totalSize + " bytes");
            var fullPath = rootPath + "/Android/";
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyyy_MM_dd_HH_mm_ss");
            File.Move(fullPath + "ZooCanteen.apk", fullPath + "ZooCanteen_DevelopNoSDK_" + PlayerSettings.bundleVersion + "_" + PlayerSettings.Android.bundleVersionCode.ToString() + "_" + str + ".apk");
        }
        else if (summary.result == BuildResult.Failed)
        {
            UnityEngine.Debug.Log("Android Develop Build failed");
        }
    }

    [MenuItem("ZooCanteen/Build/Build Android Develop", false, 205)]
    public static void BuildApkDevelop()
    {
        var oldBuildTarget = EditorUserBuildSettings.activeBuildTarget;
        var oldTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/GameEntry.unity" }
        };
        var rootPath = Application.dataPath + "/../Build";
        Directory.CreateDirectory(rootPath);
        Directory.CreateDirectory(rootPath + "/Android");
        buildPlayerOptions.locationPathName = rootPath + "/Android/ZooCanteen.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        EditorUserBuildSettings.buildAppBundle = false;
        var srcScriptSym = PlayerSettings.GetScriptingDefineSymbols(UnityEditor.Build.NamedBuildTarget.Android);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "FAIRYGUI_PUERTS;FAIRYGUI_SPINE");
        AssetDatabase.Refresh();
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, srcScriptSym);
        AssetDatabase.Refresh();
        BuildSummary summary = report.summary;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(oldTargetGroup, oldBuildTarget);
        }

        if (summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("Android Develop Build succeeded: " + summary.totalSize + " bytes");
            var fullPath = rootPath + "/Android/";
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyyy_MM_dd_HH_mm_ss");
            File.Move(fullPath + "ZooCanteen.apk", fullPath + "ZooCanteen_Develop_" + PlayerSettings.bundleVersion + "_" + PlayerSettings.Android.bundleVersionCode.ToString() + "_" + str + ".apk");
        }
        else if (summary.result == BuildResult.Failed)
        {
            UnityEngine.Debug.Log("Android Develop Build failed");
        }
    }

    [MenuItem("ZooCanteen/Build/Build Android Online Test", false, 206)]
    public static void BuildApkTest()
    {
        var oldBuildTarget = EditorUserBuildSettings.activeBuildTarget;
        var oldTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/GameEntry.unity" }
        };
        var rootPath = Application.dataPath + "/../Build";
        Directory.CreateDirectory(rootPath);
        Directory.CreateDirectory(rootPath + "/Android");
        buildPlayerOptions.locationPathName = rootPath + "/Android/ZooCanteen.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        EditorUserBuildSettings.buildAppBundle = false;
        var srcScriptSym = PlayerSettings.GetScriptingDefineSymbols(UnityEditor.Build.NamedBuildTarget.Android);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, "FAIRYGUI_PUERTS;FAIRYGUI_SPINE;BFGAME_ONLINE_TEST_MODE");
        AssetDatabase.Refresh();
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android, srcScriptSym);
        AssetDatabase.Refresh();
        BuildSummary summary = report.summary;
        if (oldBuildTarget != BuildTarget.Android)
        {
            EditorUserBuildSettings.SwitchActiveBuildTarget(oldTargetGroup, oldBuildTarget);
        }

        if (summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("Android Online Test Build succeeded: " + summary.totalSize + " bytes");
            var fullPath = rootPath + "/Android/";
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyyy_MM_dd_HH_mm_ss");
            File.Move(fullPath + "ZooCanteen.apk", fullPath + "ZooCanteen_OnlineTest_" + PlayerSettings.bundleVersion + "_" + PlayerSettings.Android.bundleVersionCode.ToString() + "_" + str + ".apk");
        }
        else if (summary.result == BuildResult.Failed)
        {
            UnityEngine.Debug.Log("Android Online Test Build failed");
        }
    }

    protected static void BuildAndroidBundlesImpl(bool notCoptRes = false)
    {
        var group = EditorUserBuildSettings.selectedBuildTargetGroup;
        var target = EditorUserBuildSettings.activeBuildTarget;
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();
        var folder = PlatformMappingService.GetPlatformPathSubFolder();
        EditorUserBuildSettings.SwitchActiveBuildTarget(group, target);
        if (!notCoptRes)
        {
            CopyRemoteRes2Local(folder);
        }
        UnityEngine.Debug.Log("Build Android Bundles------------END");
    }

    [MenuItem("ZooCanteen/Addressables/Build Android Bundles", false, 303)]
    public static void BuildAndroidBundles()
    {
        var setting = AddressableAssetSettingsDefaultObject.Settings;
        var srcProfileId = setting.activeProfileId;
        var profileId = setting.profileSettings.GetProfileId("Default");
        setting.activeProfileId = profileId;
        BuildAndroidBundlesImpl();
        setting.activeProfileId = srcProfileId;
    }

    [MenuItem("ZooCanteen/Addressables/Build Android Bundles(Copy Full Res)", false, 304)]
    public static void BuildAndroidBundlesAndCopyFullRes()
    {
        var group = EditorUserBuildSettings.selectedBuildTargetGroup;
        var target = EditorUserBuildSettings.activeBuildTarget;
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        var setting = AddressableAssetSettingsDefaultObject.Settings;
        var srcProfileId = setting.activeProfileId;
        var profileId = setting.profileSettings.GetProfileId("Default");
        setting.activeProfileId = profileId;
        UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();
        var folder = PlatformMappingService.GetPlatformPathSubFolder();
        EditorUserBuildSettings.SwitchActiveBuildTarget(group, target);
        CopyRemoteRes2Local(folder, true);
        UnityEngine.Debug.Log("Build Android Bundles------------END");
        setting.activeProfileId = srcProfileId;
    }

    protected static void BuildIOSBundlesImpl(bool notCopyRes = false)
    {
        var group = EditorUserBuildSettings.selectedBuildTargetGroup;
        var target = EditorUserBuildSettings.activeBuildTarget;
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS);
        UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();
        var folder = PlatformMappingService.GetPlatformPathSubFolder();
        EditorUserBuildSettings.SwitchActiveBuildTarget(group, target);
        if (!notCopyRes)
        {
            CopyRemoteRes2Local(folder);
        }
        UnityEngine.Debug.Log("Build iOS bundles------------END");
    }

    [MenuItem("ZooCanteen/Addressables/Build iOS Bundles", false, 305)]
    public static void BuildIOSBundles()
    {
        var setting = AddressableAssetSettingsDefaultObject.Settings;
        var srcProfileId = setting.activeProfileId;
        var profileId = setting.profileSettings.GetProfileId("Default_iOS");
        setting.activeProfileId = profileId;
        BuildIOSBundlesImpl();
        setting.activeProfileId = srcProfileId;
    }

    [MenuItem("ZooCanteen/Addressables/Build iOS Bundles(Copy Full Res)", false, 306)]
    public static void BuildIOSBundlesAndCopyFullRes()
    {
        var group = EditorUserBuildSettings.selectedBuildTargetGroup;
        var target = EditorUserBuildSettings.activeBuildTarget;
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS);
        var setting = AddressableAssetSettingsDefaultObject.Settings;
        var srcProfileId = setting.activeProfileId;
        var profileId = setting.profileSettings.GetProfileId("Default_iOS");
        setting.activeProfileId = profileId;
        UnityEditor.AddressableAssets.Settings.AddressableAssetSettings.BuildPlayerContent();
        var folder = PlatformMappingService.GetPlatformPathSubFolder();
        EditorUserBuildSettings.SwitchActiveBuildTarget(group, target);
        CopyRemoteRes2Local(folder, true);
        UnityEngine.Debug.Log("Build iOS bundles------------END");
        setting.activeProfileId = srcProfileId;
    }

    protected static void BuildAndroidBundlesByProfileName(string name, bool copyRes = false, string resRoot = "")
    {
        var setting = AddressableAssetSettingsDefaultObject.Settings;
        var srcProfileId = setting.activeProfileId;
        var profileId = setting.profileSettings.GetProfileId(name);
        setting.activeProfileId = profileId;
        AssetDatabase.Refresh();
        BuildAndroidBundlesImpl(true);
        setting.activeProfileId = srcProfileId;
        AssetDatabase.Refresh();
        if (copyRes)
        {
            CopyRemoteRes2Local("Android", false, resRoot);
        }
        else
        {
            RC4EncryptAndroidBundles();
        }
    }

    [MenuItem("ZooCanteen/Addressables(Test)/Build Android Develop Bundles", false, 501)]
    public static void BuildAndroidDevelopBundles()
    {
        BuildAndroidBundlesByProfileName("Develop_Android", false, "LXYDRemoteRes_Dev");
    }

    [MenuItem("ZooCanteen/Addressables(Test)/Build Android OnlineTest Bundles", false, 502)]
    public static void BuildAndroidOnlineTestBundles()
    {
        BuildAndroidBundlesByProfileName("OnlineTest_Android", true, "LXYDRemoteRes_OL");
    }

    protected static void BuildIOSBundlesByProfileName(string name, bool copyRes = false, string resRoot = "")
    {
        var setting = AddressableAssetSettingsDefaultObject.Settings;
        var srcProfileId = setting.activeProfileId;
        var profileId = setting.profileSettings.GetProfileId(name);
        setting.activeProfileId = profileId;
        AssetDatabase.Refresh();
        BuildIOSBundlesImpl(true);
        setting.activeProfileId = srcProfileId;
        AssetDatabase.Refresh();
        if (copyRes)
        {
            CopyRemoteRes2Local("iOS", false, resRoot);
        }
        else
        {
            RC4EncryptIOSBundles();
        }
    }

    [MenuItem("ZooCanteen/Addressables(Test)/Build iOS Develop Bundles", false, 503)]
    public static void BuildIOSDevelopBundles()
    {
        BuildIOSBundlesByProfileName("Develop_iOS", false, "LXYDRemoteRes_Dev");
    }

    [MenuItem("ZooCanteen/Addressables(Test)/Build iOS OnlineTest Bundles", false, 504)]
    public static void BuildIOSOnlineTestBundles()
    {
        BuildIOSBundlesByProfileName("OnlineTest_iOS", true, "LXYDRemoteRes_OL");
    }

    [MenuItem("ZooCanteen/Multi-language/Import From XMLs", false, 401)]
    public static void ImportMuliLanguageFromXmls()
    {
        var start = DateTime.Now;
        var batPath = Application.dataPath + "/../TsProj/zMultiLanguageImport.bat";
        processCommand(batPath, "");

        UnityEngine.Debug.Log("Multi-language - Import From XML finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    [MenuItem("ZooCanteen/Multi-language/Export to Client", false, 402)]
    public static void ExportMultiLanguageToClient()
    {
        var start = DateTime.Now;
        var batPath = Application.dataPath + "/../TsProj/zMultiLanguageExport.bat";
        processCommand(batPath, "");

        UnityEngine.Debug.Log("Multi-language - Export to Client finished! use " + (DateTime.Now - start).TotalMilliseconds + " ms");
        AssetDatabase.Refresh();
    }

    private static void processCommand(string command, string argument)
    {
        ProcessStartInfo start = new ProcessStartInfo(command)
        {
            Arguments = argument,
            CreateNoWindow = false,
            ErrorDialog = false,
            UseShellExecute = true,
            WindowStyle = ProcessWindowStyle.Normal
        };

        Process process = Process.Start(start);

        var succ = process.WaitForExit(30000);
        if (!succ)
        {
            process.Kill();
            UnityEngine.Debug.Log("processCommand - timeout, maybe the commond has some errors... ");
        }

        process.Close();
        process.Dispose();
    }

    private static void CopyRemoteRes2Local(string platformName, bool fullRes = false, string resRoot = "LXYDRemoteRes")
    {
        var localRes = new Dictionary<string, string>()
        {
            {"zhgame_audios", "zhgame_audios"},
            {"zhgame_configs", "zhgame_configs"},
            {"zhgame_effect", "zhgame_effect"},
            {"zhgame_fairygui_active", "zhgame_fairygui_active"},
            {"zhgame_fairygui", "zhgame_fairygui"},
            {"zhgame_fairygui_dice_act_10001", "zhgame_fairygui_dice_act_10001"},
            {"zhgame_fairygui_game", "zhgame_fairygui_game"},
            {"zhgame_fairygui_login", "zhgame_fairygui_login"},
            {"zhgame_fairygui_main", "zhgame_fairygui_main"},
            {"zhgame_fairygui_minigame", "zhgame_fairygui_minigame"},
            {"zhgame_fairygui_normal", "zhgame_fairygui_normal"},
            {"zhgame_fairygui_setting", "zhgame_fairygui_setting"},
            {"zhgame_fairygui_shop", "zhgame_fairygui_shop"},
            {"zhgame_fonts", "zhgame_fonts"},
            {"zhgame_js", "zhgame_js"},
            {"zhgame_languages", "zhgame_languages"},
            {"zhgame_prefabs", "zhgame_prefabs"},
            {"zhgame_scene_1", "zhgame_scene_1"},
            {"zhgame_scene_2", "zhgame_scene_2"},
            {"zhgame_scene_prefab_1", "zhgame_scene_prefab_1"},
            {"zhgame_scene_game_1", "zhgame_scene_game_1"},
            {"zhgame_scene_game_prefab", "zhgame_scene_game_prefab"},
            {"zhgame_scene_dice_10001", "zhgame_scene_dice_10001"},
            {"zhgame_scene_dice_prefab_10001", "zhgame_scene_dice_prefab_10001"},
#if UNITY_IOS
            {"zhgame_scene_3", "zhgame_scene_3"},
            {"zhgame_scene_4", "zhgame_scene_4"},
            {"zhgame_scene_game_2", "zhgame_scene_game_2"},
            {"zhgame_scene_game_3", "zhgame_scene_game_3"},
            {"zhgame_scene_game_4", "zhgame_scene_game_4"},
            {"zhgame_scene_game_5", "zhgame_scene_game_5"},
            {"zhgame_scene_game_6", "zhgame_scene_game_6"},
            {"zhgame_scene_game_7", "zhgame_scene_game_7"},
            {"zhgame_scene_prefab_2", "zhgame_scene_prefab_2"},
            {"zhgame_scene_prefab_3", "zhgame_scene_prefab_3"},
            {"zhgame_scene_prefab_4", "zhgame_scene_prefab_4"},
#endif
        };

        var srcRoot = Application.dataPath + "/../";
        var srcResRoot = srcRoot + resRoot + "/" + platformName;
        var destRoot = srcRoot + "Library/com.unity.addressables/aa/" + platformName;
        var destResPath = destRoot + "/" + platformName;
        if (Directory.Exists(destResPath))
        {
            Directory.Delete(destResPath, true);
        }

        Directory.CreateDirectory(destResPath);

        var catalogFilePath = destRoot + "/catalog.json";
        if (!File.Exists(catalogFilePath))
        {
            UnityEngine.Debug.LogWarning("[PublishTool] - catalog.json is not exist ");
            return;
        }

        var catalog = JsonUtility.FromJson<ZooCanteenCatalogData>(File.ReadAllText(catalogFilePath));
        if (catalog == null || catalog.m_InternalIds == null)
        {
            UnityEngine.Debug.LogWarning("[PublishTool] - read catalog.json failed...");
            return;
        }

        var fileCount = 0;
        for (int i = 0; i < catalog.m_InternalIds.Length; i++)
        {
            if ((catalog.m_InternalIds[i].StartsWith("http://") || catalog.m_InternalIds[i].StartsWith("https://")) && catalog.m_InternalIds[i].EndsWith(".bundle"))
            {
                var index = catalog.m_InternalIds[i].IndexOf("/zhgame_");
                if (index >= 0)
                {
                    string fileName = catalog.m_InternalIds[i].Substring(index + 1);
                    if (File.Exists(srcResRoot + "/" + fileName))
                    {
                        var rc4 = new LXYDRC4();
                        byte[] encData = File.ReadAllBytes(srcResRoot + "/" + fileName);
                        rc4.ToRC4(ref encData, 0, encData.Length);
                        File.WriteAllBytes(srcResRoot + "/" + fileName, encData);

                        var nameIndex = fileName.IndexOf("_assets_all_");
                        string bundleName = "------";
                        if (nameIndex >= 0)
                        {
                            bundleName = fileName.Substring(0, nameIndex);
                        }
                        else
                        {
                            nameIndex = fileName.IndexOf("_scenes_all_");
                            if (nameIndex >= 0)
                            {
                                bundleName = fileName.Substring(0, nameIndex);
                            }
                        }

                        if (fullRes || localRes.ContainsKey(bundleName))
                        {
                            File.Copy(srcResRoot + "/" + fileName, destResPath + "/" + fileName);
                            UnityEngine.Debug.Log("[PublishTool] - bundle copyed -->" + fileName);
                            fileCount++;
                        }
                    }
                }
                else
                {
                    index = catalog.m_InternalIds[i].IndexOf("_unitybuiltinshaders_");
                    if (index >= 0)
                    {
                        index = catalog.m_InternalIds[i].LastIndexOf('/');
                        string fileName = catalog.m_InternalIds[i].Substring(index);

                        var rc4 = new LXYDRC4();
                        byte[] encData = File.ReadAllBytes(srcResRoot + "/" + fileName);
                        rc4.ToRC4(ref encData, 0, encData.Length);
                        File.WriteAllBytes(srcResRoot + "/" + fileName, encData);

                        File.Copy(srcResRoot + "/" + fileName, destResPath + "/" + fileName);
                        UnityEngine.Debug.Log("[PublishTool] - bundle copyed -->" + fileName);
                        fileCount++;
                    }

                    UnityEngine.Debug.LogWarning("[PublishTool] - bundle is not exist -->" + catalog.m_InternalIds[i]);
                }
            }
        }

        UnityEngine.Debug.Log("[PublishTool] - bundle copy count -->" + fileCount);
    }
}

