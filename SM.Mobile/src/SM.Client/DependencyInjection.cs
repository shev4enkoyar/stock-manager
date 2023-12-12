using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;

namespace SM.Client;

public static class DependencyInjection
{
    public static MauiAppBuilder AddClientServices(this MauiAppBuilder builder)
    {
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder;
    }
}