#if UNITY_IOS
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using System.IO;

public class BFPostProcessBuildSetting : IPostprocessBuildWithReport
{
    public int callbackOrder { get { return 45; } }

    public void OnPostprocessBuild(BuildReport report)
    {
        if (report.summary.platform == BuildTarget.iOS)
        {
            //初始化
            string projPath = PBXProject.GetPBXProjectPath(report.summary.outputPath);
            PBXProject proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));
            var mainTarget = proj.GetUnityMainTargetGuid();
            proj.SetBuildProperty(mainTarget, "ENABLE_BITCODE", "NO");
            proj.AddBuildProperty(mainTarget, "OTHER_LDFLAGS", "-ld_classic");

            var frameworkTarget = proj.GetUnityFrameworkTargetGuid();
            proj.SetBuildProperty(frameworkTarget, "ENABLE_BITCODE", "NO");
            proj.AddBuildProperty(frameworkTarget, "OTHER_LDFLAGS", "-ld_classic");

            // Apple 登录
            proj.AddFrameworkToProject(frameworkTarget, "AuthenticationServices.framework", true);

            // 保存修改
            File.WriteAllText(projPath, proj.WriteToString());

            var manager = new ProjectCapabilityManager(projPath, "Unity-iPhone.entitlements", null, mainTarget);
            manager.AddSignInWithApple();
            manager.AddPushNotifications(true);
            manager.AddBackgroundModes(BackgroundModesOptions.RemoteNotifications);
            manager.WriteToFile();

            // info.plist
            var plistPath = Path.Combine(report.summary.outputPath, "Info.plist");
            var plist = new PlistDocument();
            plist.ReadFromString(File.ReadAllText(plistPath));
            var rootDict = plist.root;
            var transportDict = rootDict["NSAppTransportSecurity"] as PlistElementDict;
            if(transportDict == null) {
                transportDict = rootDict.CreateDict("NSAppTransportSecurity");
            }

            transportDict.SetBoolean("NSAllowsArbitraryLoads", true);
            transportDict.SetBoolean("NSAllowsArbitraryLoadsInWebContent", true);
            var domainDict = transportDict.CreateDict("NSExceptionDomains");
            CreateDomainDict(domainDict, "106.75.166.77");
            CreateDomainDict(domainDict, "107.150.110.213");
            CreateDomainDict(domainDict, "107.150.98.114");
            CreateDomainDict(domainDict, "android.bugly.qq.com");
            CreateDomainDict(domainDict, "ios.bugly.qq.com");
            CreateDomainDict(domainDict, "rqd.uu.qq.com");

            File.WriteAllText(plistPath, plist.WriteToString());

            // Podfile：修改CocoaPods源 & 增加Bugly
            var podfilePath = Path.Combine(report.summary.outputPath, "Podfile");
            if(File.Exists(podfilePath))
            {
                var podFileContent = File.ReadAllText(podfilePath);
                // 修改CocoaPods源
                var platformStr = "platform :ios,";
                var index = podFileContent.IndexOf(platformStr);
                var startStr = podFileContent.Substring(0, index);
                podFileContent.Replace(startStr, "source 'https://mirrors.tuna.tsinghua.edu.cn/git/CocoaPods/Specs.git'\n\n");

                // 添加Bugly
                var googleSign = "pod 'GoogleSignIn', '~> 6.0.2'";
                index = podFileContent.IndexOf(googleSign) + googleSign.Length;
                var podFileContentStart = podFileContent.Substring(0, index);
                var podFileContentEnd = podFileContent.Substring(index);
                podFileContent = podFileContentStart + "\n  pod 'Bugly'" + podFileContentEnd;
                File.WriteAllText(podfilePath, podFileContent);
            }
        }
    }

    protected void CreateDomainDict(PlistElementDict dict, string name)
    {
        var elementDict = dict.CreateDict(name);
        elementDict.SetBoolean("NSExceptionAllowsInsecureHTTPLoads", true);
        elementDict.SetBoolean("NSIncludesSubdomains", true);
    }
}
#endif