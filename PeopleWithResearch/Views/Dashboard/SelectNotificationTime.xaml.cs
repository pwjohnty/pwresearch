using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Maui.Controls.PlatformConfiguration;
//using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Devices;

namespace PeopleWithResearch
{
    public partial class SelectNotificationTime : Mopups.Pages.PopupPage
    {
        public ObservableCollection<string> HoursList { get; set; }
        public DateTime updatedDateTime = new DateTime();
        public ObservableCollection<user> userpassed = new ObservableCollection<user>();
        public UserManager usermanager;

        public SelectNotificationTime()
        {
            InitializeComponent();

           // Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);

          //  On<iOS>().SetUseSafeArea(false);

            usermanager = UserManager.DefaultManager;

            detailslbl.Text = "Hi " + Helpers.Settings.FirstName + "! We want to make sure our reminders fit perfectly into your schedule. Could you please let us know what time you'd prefer to receive your weekly reminder notification?";


            getuserdetails();


            HoursList = new ObservableCollection<string>();

            // Populate the list with hours
            foreach (int hour in Enumerable.Range(0, 24))
            {
                HoursList.Add($"{hour:D2}:00");
            }

            listView.ItemsSource = HoursList;

        }

        async void getuserdetails()
        {
            try
            {
                userpassed = await usermanager.getUserInfo(Helpers.Settings.UserKey);
            }
            catch (Exception ex)
            {

            }
        }

        void listView_ItemTapped(System.Object sender, Syncfusion.Maui.ListView.ItemTappedEventArgs e)
        {
            try
            {
                //time listview tapped

                var item = e.DataItem as string;


                //set the activationDT time with the hour they selected

                var convertdate = DateTime.Parse(Helpers.Settings.CreatedAtDateOnly);



                // Create a TimeSpan with the selected hour
                var ts = TimeSpan.Parse(item);
                var selectedTime = new TimeSpan(ts.Hours, 0, 0);

                // Set the time part of the currentDate
                updatedDateTime = convertdate.Date + selectedTime;



            }
            catch (Exception ex)
            {

            }
        }

        async void btnsubmit_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {

                if (listView.SelectedItems.Count == 0)
                {
                    //return
                    Vibration.Vibrate();
                    return;
                }
                else
                {
                    // Convert updatedDateTime to DateTimeOffset
                    var updatedDateTimeOffset = new DateTimeOffset(updatedDateTime);

                    // Format updatedDateTimeOffset to the desired string format
                    var formattedDateTimeOffset = updatedDateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss.fff zzz");


                    //update the user table and update settings

                    Preferences.Set("createdat", formattedDateTimeOffset);


                    userpassed[0].ActivationDT = formattedDateTimeOffset;
                    await usermanager.AddUser(userpassed[0]);

                    Application.Current.MainPage = new NavigationPage(new MainDashboard());
                    Navigation.RemovePage(this);
                }


            }
            catch (Exception ex)
            {

            }
        }
    }
}

