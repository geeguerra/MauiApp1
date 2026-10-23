using MauiApp1.Services;
using MauiApp1.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();

 #endif           //registrar View
            builder.Services.AddTransient<LocalViewModel>();

            //registrar ViewModels
            builder.Services.AddTransient<LocalViewModel>();

            //registrar Services 
            builder.Services.AddSingleton<IGeoService, GeoService>();


            return builder.Build();
        }
    }
}
