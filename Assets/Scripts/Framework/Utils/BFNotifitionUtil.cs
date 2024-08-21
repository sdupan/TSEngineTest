using System.Threading.Tasks;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#elif UNITY_IOS
using Unity.Notifications.iOS;
#endif
using System;
using UnityEngine;

namespace UnityTSGame
{
    public class BFNotifitionUtil
    {
        public class BFNotifitionData
        {
            public int Id;
            public string Title;
            public string Body;
            public string Subtitle;
            public string Data;
            public string Group;
            public int delayMilliseconds;
            public int BadgeNumber;
            public bool Scheduled;
            public string SmallIcon;
            public string LargeIcon;
            public bool ShowInForeground;
            public int RepeatSeconds;
            public string ChannelId;

            public BFNotifitionData()
            {

            }
        }

        public static Action<BFNotifitionData> JsOnLocalNotificationReceived;
        public static Action<BFNotifitionData> JsOnRemoteNotificationReceived;

        protected static string _channelId;

        public static int Init(string cId, string cName, string cDesc)
        {
            _channelId = cId;
#if UNITY_ANDROID
            var group = new AndroidNotificationChannelGroup()
            {
                Id = "ZHGame",
                Name = "ZHGame Notifications",
            };
            AndroidNotificationCenter.RegisterNotificationChannelGroup(group);

            var channel = new AndroidNotificationChannel()
                {
                    Id = cId,
                    Name = cName,
                    Importance = Importance.High,
                    Description = cDesc,
                    Group = "ZHGame"
            };
            AndroidNotificationCenter.RegisterNotificationChannel(channel);

            AndroidNotificationCenter.OnNotificationReceived += android =>
            {
                var androidData = new BFNotifitionData
                {
                    Id = android.Id,
                    Title = android.Notification.Title,
                    Body = android.Notification.Text,
                    Data = android.Notification.IntentData,
                    delayMilliseconds = 0,
                    Group = android.Notification.Group,
                    SmallIcon = android.Notification.SmallIcon,
                    LargeIcon = android.Notification.LargeIcon,
                    ShowInForeground = android.Notification.ShowInForeground,
                    BadgeNumber = android.Notification.Number,
                    Scheduled = true,
                    RepeatSeconds = android.Notification.RepeatInterval.HasValue ? android.Notification.RepeatInterval.Value.Milliseconds : 0,
                    ChannelId = android.Channel
                };

                var repeatInterval = android.Notification.RepeatInterval;
                if (repeatInterval != null && repeatInterval.HasValue)
                {
                    androidData.RepeatSeconds = android.Notification.RepeatInterval.Value.Seconds;
                }

                JsOnLocalNotificationReceived?.Invoke(androidData);
            };
#elif UNITY_IOS
            iOSNotificationCenter.OnNotificationReceived += ios =>
            {
                var iOSData = new BFNotifitionData
                {
                    Id = int.Parse(ios.Identifier),
                    Title = ios.Title,
                    Body = ios.Body,
                    Subtitle = ios.Subtitle,
                    Data = ios.Data,
                    delayMilliseconds = 0,
                    Group = ios.CategoryIdentifier,
                    BadgeNumber = ios.Badge,
                    ShowInForeground = ios.ShowInForeground,
                    Scheduled = true,
                    RepeatSeconds = 0,
                    ChannelId = ""
                };

                JsOnLocalNotificationReceived?.Invoke(iOSData);
            };

            iOSNotificationCenter.OnRemoteNotificationReceived += ios =>
            {
                var iOSData = new BFNotifitionData
                {
                    Id = int.Parse(ios.Identifier),
                    Title = ios.Title,
                    Body = ios.Body,
                    Subtitle = ios.Subtitle,
                    Data = ios.Data,
                    delayMilliseconds = 0,
                    Group = ios.CategoryIdentifier,
                    BadgeNumber = ios.Badge,
                    ShowInForeground = ios.ShowInForeground,
                    Scheduled = true,
                    RepeatSeconds = 0,
                    ChannelId = ""
                };

                JsOnRemoteNotificationReceived?.Invoke(iOSData);
            };
#endif

            return 0;
        }

        public static async Task<string> RequestAuthorization()
        {
#if UNITY_ANDROID
            var req = new PermissionRequest();
            while (req.Status == PermissionStatus.RequestPending)
            {
                await Task.Delay(1);
            }

            string res = "{\"Status\":" + req.Status + "}";
            return res;
#elif UNITY_IOS
            var authorizationOption = AuthorizationOption.Alert | AuthorizationOption.Badge;
            var req = new AuthorizationRequest(authorizationOption, true);
            while (!req.IsFinished)
            {
                await Task.Delay(1);
            };

            string res = "{\"Granted\":" + req.Granted + ", \"Error\":" + req.Error + ", \"DeviceToken\":" + req.DeviceToken + "}";
            return res;
#endif
            await Task.Delay(1);
            return "{}";
        }

        public static void ScheduleNotifition(int nid, BFNotifitionData notifitionData)
        {
#if UNITY_ANDROID
            var androidNotification = new AndroidNotification
            {
                Title = notifitionData.Title,
                Text = notifitionData.Body,
                IntentData = notifitionData.Data,
                FireTime = DateTime.Now.AddMilliseconds(notifitionData.delayMilliseconds),
                ShowInForeground = notifitionData.ShowInForeground,
                Number = notifitionData.BadgeNumber
            };

            if(notifitionData.RepeatSeconds > 0) {
                androidNotification.RepeatInterval = TimeSpan.FromSeconds(notifitionData.RepeatSeconds);
            }

            if(!string.IsNullOrEmpty(notifitionData.SmallIcon)) {
                androidNotification.SmallIcon = notifitionData.SmallIcon;
            }

            if(!string.IsNullOrEmpty(notifitionData.LargeIcon)) {
                androidNotification.LargeIcon = notifitionData.LargeIcon;
            }

            AndroidNotificationCenter.SendNotificationWithExplicitID(androidNotification, _channelId, nid);
#elif UNITY_IOS
            var nowDate = DateTime.Now.AddMilliseconds(notifitionData.delayMilliseconds);
            var timeTrigger = new iOSNotificationCalendarTrigger()
            {
                Hour = nowDate.Hour,
                Minute = nowDate.Minute,
                Second = nowDate.Second,
                Repeats = notifitionData.RepeatSeconds > 0
            };

            var iosNotifition = new iOSNotification()
            {
                Identifier = nid.ToString(),
                Title = notifitionData.Title,
                Body = notifitionData.Body,
                Subtitle = notifitionData.Subtitle,
                ShowInForeground = notifitionData.ShowInForeground,
                ForegroundPresentationOption = PresentationOption.Alert | PresentationOption.Sound,
                Data = notifitionData.Data,
                CategoryIdentifier = notifitionData.Group,
                ThreadIdentifier = "__BF_NOTIFITION_UTIL__",
                Badge = notifitionData.BadgeNumber,
                Trigger = timeTrigger,
            };

            iOSNotificationCenter.ScheduleNotification(iosNotifition);
#endif
        }

        public static void CancelNotification(int nid)
        {
#if UNITY_ANDROID
            AndroidNotificationCenter.CancelScheduledNotification(nid);
#elif UNITY_IOS
            iOSNotificationCenter.RemoveScheduledNotification(nid.ToString());
#endif
        }

        public static void DismissNotification(int nid)
        {
#if UNITY_ANDROID
            AndroidNotificationCenter.CancelDisplayedNotification(nid);
#elif UNITY_IOS
            iOSNotificationCenter.RemoveDeliveredNotification(nid.ToString());
#endif
        }

        public static void CancelAllScheduledNotifications()
        {
#if UNITY_ANDROID
            AndroidNotificationCenter.CancelAllScheduledNotifications();
#elif UNITY_IOS
            iOSNotificationCenter.RemoveAllScheduledNotifications();
#endif
        }

        public static void DismissAllDisplayedNotifications()
        {
#if UNITY_ANDROID
            AndroidNotificationCenter.CancelAllDisplayedNotifications();
#elif UNITY_IOS
            iOSNotificationCenter.RemoveAllDeliveredNotifications();
#endif
        }

        public static BFNotifitionData GetLastNotification()
        {
#if UNITY_ANDROID
            var android = AndroidNotificationCenter.GetLastNotificationIntent();
            if(android == null)
            {
                return null;
            }

            var androidData = new BFNotifitionData
            {
                Id = android.Id,
                Title = android.Notification.Title,
                Body = android.Notification.Text,
                Data = android.Notification.IntentData,
                delayMilliseconds = 0,
                Group = android.Notification.Group,
                SmallIcon = android.Notification.SmallIcon,
                LargeIcon = android.Notification.LargeIcon,
                BadgeNumber = 1,
                Scheduled = true,
                ChannelId = android.Channel
            };

            return androidData;
#elif UNITY_IOS

            var ios = iOSNotificationCenter.GetLastRespondedNotification();
            if(ios == null)
            {
                return null;
            }

            var iOSData = new BFNotifitionData
            {
                Id = int.Parse(ios.Identifier),
                Title = ios.Title,
                Body = ios.Body,
                Subtitle = ios.Subtitle,
                Data = ios.Data,
                delayMilliseconds = 0,
                Group = ios.CategoryIdentifier,
                BadgeNumber = ios.Badge,
                Scheduled = true,
                ChannelId = "",
            };

            return iOSData;
#endif
            return null;
        }

        public static void OnForeground()
        {
#if UNITY_IOS
            iOSNotificationCenter.ApplicationBadge = 0;
#endif
        }

        public static void OnBackground()
        {

        }
    }
}