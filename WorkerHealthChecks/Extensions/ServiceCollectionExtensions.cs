namespace WorkerHealthChecks.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

public static class ServiceCollectionExtensions
{
    public static void AddHealthChecksServices(this IServiceCollection services)
    {
        services.AddSingleton<SystemStatusMonitor>();
        services.AddSingleton<IHealthCheckNotifier, HealthCheckNotifier>();
        services.AddSingleton<IHealthCheckPublisher, HealthCheckPublisher>();
    }
}
