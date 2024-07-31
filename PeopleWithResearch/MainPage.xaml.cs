﻿using Microsoft.AppCenter.Analytics;
using System.Collections.ObjectModel;

namespace PeopleWithResearch
{
    //public ObservableCollection<User> checkuser = new ObservableCollection<User>();

    public partial class MainPage : ContentPage
    {
        UserManager usermanager;
        public ObservableCollection<user> checkuser = new ObservableCollection<user>();
        public AdvertManager advertmanager;
        public ObservableCollection<advert> checksignupcodes = new ObservableCollection<advert>();
        initialQuestionsManager initialquestionsmanager;
        public ObservableCollection<initialQuestions> questions = new ObservableCollection<initialQuestions>();
        public ObservableCollection<initialQuestionsAnswers> questionanswers = new ObservableCollection<initialQuestionsAnswers>();
        public ObservableCollection<initialQuestions> completedquestions = new ObservableCollection<initialQuestions>();
        initialQuestionsAnswersManager initialquestionsanswersmanager;
        FeatureManager featuresmanager;
        public ObservableCollection<features> FeaturesForReg = new ObservableCollection<features>();

        public MainPage()
        {
            InitializeComponent();
            try
            {
                usermanager = UserManager.DefaultManager;
                advertmanager = AdvertManager.DefaultManager;
                initialquestionsmanager = initialQuestionsManager.DefaultManager;
                initialquestionsanswersmanager = initialQuestionsAnswersManager.DefaultManager;
                featuresmanager = FeatureManager.DefaultManager;

                // Get Metrics
                var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
                // Height (in pixels)
                var height = mainDisplayInfo.Height;
                //iphone 8 or below
                if (height <= 1334)
                {
                    mainimg.HeightRequest = 150;
                    mainimg.WidthRequest = 150;
                }

                Checkifappisupdated();

                Checkifuserisloggedin();

            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                System.Diagnostics.Debug.WriteLine($"DashboardPage initialization error: {ex.Message}");
            }
        }

        public async Task Checkifuserisloggedin()
        {
            try
            {
                var id = Helpers.Settings.UserKey;
                if (string.IsNullOrEmpty(Helpers.Settings.Email))
                {
                    //do nothing
                }
                else
                {
                    if (Helpers.Settings.SignUp == "IID32")
                    {
                        await Navigation.PushAsync(new NotificationQuestionGP(), false);
                    }
                    else
                    {
                        await Navigation.PushAsync(new MainDashboard(), false);
                    }
                    Navigation.RemovePage(this);
                }
            }
            catch (Exception ex)
            {

            }
        }



        public async Task Checkifappisupdated()
        {
            try
            {
                //  await SharedNotificationService.AddTagsAsync(new string[] { "NewMarkTag" });

                var versionCheckService = new VersionCheckService();
                await versionCheckService.CheckForUpdate();


            }
            catch (Exception ex)
            {

            }
        }


        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            try
            {
                //paste button tapped

                if (Clipboard.HasText)
                {
                    // await Clipboard.SetTextAsync("67dc4fde-57c1-403e-8165-01c47794a548");

                    var text = await Clipboard.GetTextAsync();

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        return;
                    }

                    text = text.TrimEnd();

                    pasteentry.Text = text;
                    clearbtn.IsVisible = true;

                    if (text == "IID3" || text == "IID32")
                    {
                        await Navigation.PushAsync(new RegisterWithDetailsPage(text), false);
                        return;
                    }


                    pastebtn.IsVisible = false;
                    loginlbl.IsVisible = false;
                    loginbtn.IsVisible = false;
                    reglbl.IsVisible = false;
                    regbtn.IsVisible = false;



                    checkingstack.IsVisible = true;

                    //check sign up code

                    //check sign up userid pasted

                    checkuser = await usermanager.getUserInfo(text);

                    if (checkuser == null)
                    {
                        loaderlabel.Text = "Invalid Research Code";
                        tickloader.Source = ImageSource.FromFile("error.png");
                        tickloader.IsVisible = true;
                        loader.IsVisible = false;
                        tryagainbutton.IsVisible = true;
                        // Analytics.TrackEvent("MainPage - Invalid Research Code");
                        return;

                    }

                    if (checkuser.Count != 0)
                    {
                        await Task.Delay(2000);
                        loaderlabel.Text = "Validating your user code to ensure a secure and efficient login experience";


                        //tick1.Opacity = 1;
                        //label1.Opacity = 1;
                    }
                    else
                    {
                        //code is not in system
                        loaderlabel.Text = "Invalid Research Code";
                        tickloader.Source = ImageSource.FromFile("error.png");
                        tickloader.IsVisible = true;
                        loader.IsVisible = false;
                        tryagainbutton.IsVisible = true;
                        return;
                        //tick1.Source = ImageSource.FromFile("error.png");
                        //tick1.Opacity = 1;
                        //label1.Opacity = 1;
                        //label1.Text = "Research Code not found";
                        //loader.IsVisible = false;
                        //tryagainbutton.IsVisible = true;
                        //loaderlabel.Text = "Please try a different Research Code";
                        //tick2.IsVisible = false;
                        //label2.IsVisible = false;
                        //tick3.IsVisible = false;
                        //label3.IsVisible = false;

                    }

                    //check if there is any duplicates 


                    if (checkuser.Count > 1)
                    {
                        //means their is more than one of the user in the db
                    }
                    else
                    {
                        if (checkuser[0].RegStatus == "Onboarding")
                        {
                            //check user epid
                            var checkepid = await usermanager.getUserInfoEPIDandGPID(checkuser[0].Epid, checkuser[0].Gpid);

                            if (checkepid.Count > 1)
                            {
                                //show second error

                                if (checkepid.Any(x => x.RegStatus == "Active"))
                                {
                                    loaderlabel.Text = "Details associated to this research code are already in use. Please login to continue. If you believe this is an error, please contact: support@peoplewith.com";
                                    tickloader.Source = ImageSource.FromFile("error.png");
                                    tickloader.IsVisible = true;
                                    loader.IsVisible = false;
                                    tryagainbutton.IsVisible = true;
                                    return;
                                    //tick2.Source = ImageSource.FromFile("error.png");
                                    //tick2.Opacity = 1;
                                    //label2.Opacity = 1;
                                    //label2.Text = "Multiple EPID codes found";
                                    //tick3.IsVisible = false;
                                    //label3.IsVisible = false;
                                    //return;
                                }


                            }


                            ///get the reg layout and structure
                            ///


                            //check if the signup equals iid32 so change it to iid3
                            if (checkuser[0].Signupid == "IID32")
                            {
                                checkuser[0].Signupid = "IID3";
                                checkuser[0].Changesignupid = "IID32";
                            }


                            FeaturesForReg = await featuresmanager.GetSpecficAd(checkuser[0].Signupid);





                            loaderlabel.Text = "Checking for any duplications in our system";

                            checksignupcodes = await advertmanager.GetSpecficAd(checkuser[0].Signupid);

                            //check if they any additional questions

                            questions = await initialquestionsmanager.getinitialQuestions(checksignupcodes[0].AdvertID);


                            if (questions.Count != 0)
                            {
                                //get the answers for the questions
                                foreach (var item in questions)
                                {
                                    var getanswers = await initialquestionsanswersmanager.getinitialAnswers(item.Id);


                                    foreach (var it in getanswers)
                                    {
                                        questionanswers.Add(it);
                                    }
                                }




                            }

                            // Analytics.TrackEvent("MainPage - Success on copy and paste code");
                            loaderlabel.Text = "Success";
                            loader.IsVisible = false;
                            tickloader.IsVisible = true;


                            bottomstack.IsVisible = true;
                            btnmain.IsVisible = true;

                            //tick2.Opacity = 1;
                            //label2.Opacity = 1;

                            //tick3.Opacity = 1;
                            //label3.Opacity = 1;


                            //loader.IsVisible = false;
                            //loaderlabel.IsVisible = false;

                        }
                        else
                        {
                            loaderlabel.Text = "User already exists";
                            tickloader.Source = ImageSource.FromFile("error.png");
                            tickloader.IsVisible = true;
                            loader.IsVisible = false;
                            tryagainbutton.IsVisible = true;
                            // Analytics.TrackEvent("MainPage - User Already Exists");
                            return;
                        }


                    }
                }


            }
            catch (Exception ex)
            {
                //Analytics.TrackEvent("CRASH - MainPage - paste button - " + ex.StackTrace.ToString());
            }
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new RegisterWithDetailsPage(), false);

                // Analytics.TrackEvent("Register with details Clicked");
            }
            catch (Exception ex)
            {

            }
        }

        async void TapGestureRecognizer_Tapped_Login(System.Object sender, System.EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new LoginPage());

                Analytics.TrackEvent("Login Clicked");
                //await Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
                // await Navigation.PushAsync(new RegisterPage(checkuser[0], questions, questionanswers, FeaturesForReg), true);
            }
            catch (Exception ex)
            {
                var s = ex.StackTrace.ToString();
                var ss = "sdnsk";
            }
        }

        void tryagainbutton_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {

                checkingstack.IsVisible = false;
                loader.IsVisible = true;
                tryagainbutton.IsVisible = false;
                tickloader.IsVisible = false;
                tickloader.Source = ImageSource.FromFile("tick.png");
                loaderlabel.Text = "Checking code...";
                pastebtn.IsVisible = true;
                loginlbl.IsVisible = true;
                loginbtn.IsVisible = true;
                reglbl.IsVisible = true;
                regbtn.IsVisible = true;
                clearbtn.IsVisible = false;
                btnmain.IsVisible = false;

                pasteentry.Text = "";

            }
            catch (Exception ex)
            {

            }
        }

        async void btnmain_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new RegisterPage(checkuser[0], questions, questionanswers, FeaturesForReg), false);

                Analytics.TrackEvent("Registration Signup Start Clicked");
            }
            catch (Exception ex)
            {
                //DisplayAlert("Error", ex.Message.ToString(), "OK");
                //DisplayAlert("Error", ex.StackTrace.ToString(), "OK");
            }
        }

        void clearbtn_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {

                checkingstack.IsVisible = false;
                loader.IsVisible = true;
                tryagainbutton.IsVisible = false;
                tickloader.IsVisible = false;
                tickloader.Source = ImageSource.FromFile("tick.png");
                loaderlabel.Text = "Checking code...";
                pastebtn.IsVisible = true;
                loginlbl.IsVisible = true;
                loginbtn.IsVisible = true;
                reglbl.IsVisible = true;
                regbtn.IsVisible = true;
                clearbtn.IsVisible = false;
                btnmain.IsVisible = false;

                pasteentry.Text = "";


            }
            catch (Exception ex)
            {

            }
        }

    }

}
