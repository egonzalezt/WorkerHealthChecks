// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WorkerHealthChecks.Extensions;
using WorkerHealthChecks.Sample;
using WorkerHealthChecks.Sample.Workers;

var builder = new HostBuilder()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<IdleWorker>();
        services.AddHealthChecksServices();
        services.AddSingleton((serviceProvider) =>
        {
            var apiUri = new Uri("https://localhost:7209/swagger/index.html");
            return new ApiHealthCheck(serviceProvider.GetRequiredService<IHttpClientFactory>(), apiUri);
        });

        services.AddHttpClient();

        services.AddLogging((loggingBuilder) => loggingBuilder
            .SetMinimumLevel(LogLevel.Trace)
            .AddConsole()
        );

        services.AddHealthChecks().AddCheck<ApiHealthCheck>("api_check");
    });

await builder.RunConsoleAsync();