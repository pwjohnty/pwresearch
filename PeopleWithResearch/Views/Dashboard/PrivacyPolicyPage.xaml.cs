using System.Collections.ObjectModel;

namespace PeopleWithResearch;

public partial class PrivacyPolicyPage : ContentPage
{

    PrivacyManager manager;

    public ObservableCollection<privacyPolicy> privacy = new ObservableCollection<privacyPolicy>();

    public PrivacyPolicyPage()
    {
        InitializeComponent();


        manager = PrivacyManager.DefaultManager;


        getpolicy();

    }

    async void getpolicy()
    {
        try
        {
            privacy = await manager.GetprivacyPolicySignupID();



            if (privacy != null)
            {
                titlelabel.Text = privacy[0].Title;
                bodylabel.Text = privacy[0].Content;


            }

        }
        catch (Exception ex)
        {

        }

    }
}