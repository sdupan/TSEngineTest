#if UNITY_IOS
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using System.IO;
using UnityEditor.iOS.Xcode.Extensions;

public class BFPostProcessiOS : IPostprocessBuildWithReport
{
    public int callbackOrder { get { return int.MaxValue; } }

    public void OnPostprocessBuild(BuildReport report)
    {
        if (report.summary.platform == BuildTarget.iOS)
        {
            //初始化
            string projPath = PBXProject.GetPBXProjectPath(report.summary.outputPath);
            PBXProject proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));
            var mainTarget = proj.GetUnityMainTargetGuid();

            // 添加必要的库
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/FBAEMKit/XCFrameworks/FBAEMKit.xcframework"));
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/FBSDKCoreKit/XCFrameworks/FBSDKCoreKit.xcframework"));
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/FBSDKCoreKit_Basics/XCFrameworks/FBSDKCoreKit_Basics.xcframework"));
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/FBSDKGamingServicesKit/XCFrameworks/FBSDKGamingServicesKit.xcframework"));
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/FBSDKLoginKit/XCFrameworks/FBSDKLoginKit.xcframework"));
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/FBSDKShareKit/XCFrameworks/FBSDKShareKit.xcframework"));
            AddFrameWorks(proj, mainTarget, Path.Combine(report.summary.outputPath, "Pods/Fyber_Marketplace_SDK/IASDKCore/IASDKCore.xcframework"));

            // 保存修改
            File.WriteAllText(projPath, proj.WriteToString());
        }
    }

    protected void AddFrameWorks(PBXProject proj, string target, string libPath)
    {
        var fileGuid = proj.AddFile(libPath, libPath, PBXSourceTree.Sdk);
        PBXProjectExtensions.AddFileToEmbedFrameworks(proj, target, fileGuid);
    }
}

#endif