using KeyWorkerService.Application;
using KeyWorkerService.Application.UseCases.Local;
using KeyWorkerService.Domain.Interfaces;
using KeyWorkerService.Domain.Models.LocalContext;
using KeyWorkerService.Infrastructure;
using KeyWorkerService.Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
        IConfiguration configuration = hostContext.Configuration;

        var workerSettings = new WorkerSettings();
        hostContext.Configuration.Bind(nameof(WorkerSettings), workerSettings);
        services.AddSingleton(workerSettings);

        services.AddSingleton<IEntryPointService, EntryPointService>();
        services.AddSingleton<IUsuario, UsuarioUseCase>();
        services.AddScoped<DefaultContext>();
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
