using Microsoft.Extensions.Logging;

namespace DropTest
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif


#if MACCATALYST
            builder.ConfigureMauiHandlers(handlers =>
            {
                IMauiHandlersCollection mauiHandlersCollection = handlers.AddHandler(typeof(DropTest.Platforms.MacCatalyst.FileDropBox), typeof(DropTest.Platforms.MacCatalyst.FileDropBoxHandler));
            });
#endif
            return builder.Build();
        }
    }
}
