using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TPFinalHaasEric.Extensions;

namespace TPFinalHaasEric;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        host.RunMigrationsAsync().GetAwaiter();
        host.SeedInitialData().GetAwaiter();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureApplicationServices();
    }
}