namespace PeopleWithResearch
{
    public partial class App : Application
    {
        public App()
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXlfdHRdRWFYVkVwXEU="); //NEW


            InitializeComponent();

            MainPage = new AppShell();
        }

        //public static async Task<Dictionary<string, string>> LoadAPIKeyAsync()
        //{
        //    Dictionary<string, string> APIKey = new Dictionary<string, string>();
        //    ////IOS////
        //    //    await SecureStorage.SetAsync("zumo-api-key", "iuwdbiuwdhhe2uh2eiuh2hd29h2e98h2u9h98hd98hhh29eh298h829h89h");
        //    //    var key = await SecureStorage.GetAsync("zumo-api-key");
        //    //    APIKey.Add("zumo-api-key", key);
        //    //    return APIKey;
        //    ////TEMP WORKAROUND DUE TO PACKAGE COMAPTBILITY ISSUE ON IOS////
        //    APIKey.Add("zumo-api-key", "iuwdbiuwdhhe2uh2eiuh2hd29h2e98h2u9h98hd98hhh29eh298h829h89h");
        //    return APIKey;
        //    ////
        //}
    }
}
