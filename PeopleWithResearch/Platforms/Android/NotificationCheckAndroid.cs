using Android.App;
using Android.Content.PM;
using YourAppName.Droid.Services;
using YourAppName;
//using Xamarin.Forms;
using PeopleWithResearch;
using System;
using Application = Android.App.Application;
using Android.Content;

[assembly: Dependency(typeof(NotificationCheckAndroid))]

namespace YourAppName.Droid.Services
{
    public class NotificationCheckAndroid : CheckNotifications
    {
        public bool GetApplicationNotificationSettings()
        {

            NotificationManager manager = (NotificationManager)Application.Context.GetSystemService(Android.Content.Context.NotificationService);
            return manager.AreNotificationsEnabled();

        }
    }
}