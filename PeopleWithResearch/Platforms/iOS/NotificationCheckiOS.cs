using PeopleWithResearch;
using UIKit;
//using Xamarin.Forms;
[assembly: Dependency(typeof(NotificationCheckiOS))]
class NotificationCheckiOS : CheckNotifications
{
    public bool GetApplicationNotificationSettings()
    {
        var settings = UIApplication.SharedApplication.CurrentUserNotificationSettings.Types;
        return settings != UIUserNotificationType.None;
    }
}