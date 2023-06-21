using KeyWorkerService.Application;
using KeyWorkerService.Domain.Interfaces;
using KeyWorkerService.Infrastructure;
using KeyWorkerService.Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
        IConfiguration configuration = hostContext.Configuration;

        //var workerSettings = new WorkerSettings();
        //hostContext.Configuration.Bind(nameof(WorkerSettings), workerSettings);
        //services.AddSingleton(workerSettings);

        services.AddSingleton<IEntryPointService, EntryPointService>();

        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
