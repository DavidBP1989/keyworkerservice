using KeyWorkerService.Application;
using KeyWorkerService.Application.UseCases.Local;
using KeyWorkerService.Domain.Interfaces;
using KeyWorkerService.Domain.Models.LocalContext;
using KeyWorkerService.Infrastructure;
using KeyWorkerService.Infrastructure.DataContext.Local;
using KeyWorkerService.Worker;
using Microsoft.EntityFrameworkCore;
using System;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        //services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
        //IConfiguration configuration = hostContext.Configuration;

        //var workerSettings = new WorkerSettings();
        //hostContext.Configuration.Bind(nameof(WorkerSettings), workerSettings);
        //services.AddSingleton(workerSettings);

        //services.AddSingleton<IEntryPointService, EntryPointService>();


        //var optionsBuilder = new DbContextOptionsBuilder<DefaultContext>();
        //optionsBuilder.UseSqlServer(configuration.GetConnectionString("Local"));
        //services.AddScoped<DefaultContext>(db => new DefaultContext(optionsBuilder.Options));

        //services.AddSingleton<IUsuario, UsuarioUseCase>();

        services.AddSingleton<IServiceLocator, ServiceScopeFactoryLocator>();

        services.AddDbContext(hostContext.Configuration);
        services.AddScoped<IRepository, DefaultContextRepository>();
        services.AddUseCaseServices();

        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
