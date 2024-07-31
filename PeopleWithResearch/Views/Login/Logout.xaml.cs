using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace PeopleWithResearch
{
    public partial class Logout : ContentPage
    {
      //  public INotificationHubService notificationHubService;
        public string HubName;

        public Logout()
        {
            InitializeComponent();


            //notificationHubService = DependencyService.Get<INotificationHubService>();
            //HubName = Constants.NotificationHubName;




            logoutuser();




        }

        public Logout(string withdrawn)
        {
            InitializeComponent();

         //   Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);

            //notificationHubService = DependencyService.Get<INotificationHubService>();
            //HubName = Constants.NotificationHubName;


            logoutuserwithdrawnmessage();

        }

        void logoutuser()
        {
            try
            {
                //notificationHubService.AddTag("NEWONEFORTEST");
               // notificationHubService.ClearTags();


                //clear the user info
                //App.Current.Properties.Clear();
                Preferences.Set("usertitle", "");
                Preferences.Set("firstname", "");
                Preferences.Set("surname", "");
                Preferences.Set("gender", "");
                Preferences.Set("email", "");
                Preferences.Set("password", "");
                Preferences.Set("addresslineone", "");
                Preferences.Set("addresslinetwo", "");
                Preferences.Set("town", "");
                Preferences.Set("city", "");
                Preferences.Set("postcode", "");
                Preferences.Set("phonenumber", "");
                Preferences.Set("mostrecentdiagkey", "");
                Preferences.Set("userpasswordhash", "");
                Preferences.Set("hassymptomssetting", "");
                Preferences.Set("announcementids", "");
                Preferences.Set("height", "");
                Preferences.Set("weight", "");
                // Preferences.Set("update", "");
                Preferences.Set("id", "");
                Preferences.Set("launchvideo", "");
                Preferences.Set("advertID", "");
                Preferences.Set("userpreferences", "");
                Preferences.Set("signupcode", "");
                Preferences.Set("dashsettings", "");
                Preferences.Set("additionalconsent", "");
                Preferences.Set("createdat", "");
                Preferences.Set("usergpid", "");
                //Preferences.Set("walkthrough", "");
                //Application.Current.MainPage = new RootPage(true, false, false);

                var mainPage = new MainPage();
                NavigationPage.SetHasNavigationBar(mainPage, false);
                Application.Current.MainPage = new NavigationPage(mainPage);


             //   Application.Current.MainPage = new NavigationPage(new MainPage());


            }
            catch (Exception ex)
            {

            }
        }

        async void logoutuserwithdrawnmessage()
        {
            try
            {

                withdrawnstack.IsVisible = true;

                await Task.Delay(2000);

                //notificationHubService.AddTag("NEWONEFORTEST");
              //  notificationHubService.ClearTags();


                //clear the user info
                //App.Current.Properties.Clear();
                Preferences.Set("usertitle", "");
                Preferences.Set("firstname", "");
                Preferences.Set("surname", "");
                Preferences.Set("gender", "");
                Preferences.Set("email", "");
                Preferences.Set("password", "");
                Preferences.Set("addresslineone", "");
                Preferences.Set("addresslinetwo", "");
                Preferences.Set("town", "");
                Preferences.Set("city", "");
                Preferences.Set("postcode", "");
                Preferences.Set("phonenumber", "");
                Preferences.Set("mostrecentdiagkey", "");
                Preferences.Set("userpasswordhash", "");
                Preferences.Set("hassymptomssetting", "");
                Preferences.Set("announcementids", "");
                Preferences.Set("height", "");
                Preferences.Set("weight", "");
                // Preferences.Set("update", "");
                Preferences.Set("id", "");
                Preferences.Set("launchvideo", "");
                Preferences.Set("advertID", "");
                Preferences.Set("userpreferences", "");
                Preferences.Set("signupcode", "");
                Preferences.Set("dashsettings", "");
                Preferences.Set("additionalconsent", "");
                Preferences.Set("createdat", "");
                Preferences.Set("usergpid", "");
                //Preferences.Set("walkthrough", "");
                //Application.Current.MainPage = new RootPage(true, false, false);
                Application.Current.MainPage = new NavigationPage(new MainPage());


            }
            catch (Exception ex)
            {

            }
        }
    }
}

