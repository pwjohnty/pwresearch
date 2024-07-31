using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using Mopups.Hosting;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Maui.FreakyControls.Extensions;


namespace PeopleWithResearch
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureMopups()
             //   .UseMauiCompatibility() // Add this line to enable compatibility features
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            // Register your dependencies here
            //  builder.Services.AddSingleton<CheckNotifications, CheckNotifications>();

#if DEBUG
            builder.Logging.AddDebug();
            builder.InitializeFreakyControls();
            builder.ConfigureSyncfusionCore();
#endif

            //   AppCenter.Start("ios=d5fb9d36-7848-4df4-a558-3caa07b9ba34;" +
            //"android=4c013131-145c-4b84-a201-5298e7780f33;",
            // typeof(Analytics), typeof(Crashes));
            //   AppCenter.LogLevel = Microsoft.AppCenter.LogLevel.Verbose;
            //   AppCenter.SetUserId(Helpers.Settings.UserKey);
            // Register Application as a singleton
            //builder.Services.AddSingleton<Application>(App.Current);
            builder.InitializeFreakyControls(useSkiaSharp: true);
            return builder.Build();
        }
    }
}
