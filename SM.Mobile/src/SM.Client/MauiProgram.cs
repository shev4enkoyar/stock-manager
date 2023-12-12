using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace SM.Client;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        return MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .AddApplicationServices()
            .AddInfrastructureServices()
            .AddClientServices()
            .Build();
    }

    private static MauiAppBuilder AddInfrastructureServices(this MauiAppBuilder builder)
    {
        return builder;
    }

    private static MauiAppBuilder AddApplicationServices(this MauiAppBuilder builder)
    {
        return builder;
    }
}