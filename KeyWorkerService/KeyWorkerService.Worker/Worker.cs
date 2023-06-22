using KeyWorkerService.Application;
using KeyWorkerService.Application.UseCases.Local;

namespace KeyWorkerService.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IEntryPointService _EntryPointService;
        private readonly WorkerSettings _workerSettings;

        public IServiceProvider ServiceProvider { get; }

        //public Worker(ILogger<Worker> logger, IEntryPointService entryPointService, WorkerSettings workerSettings, iservicesc IServiceProvider serviceProvider)
        //{
        //    _logger = logger;
        //    _EntryPointService = entryPointService;
        //    _workerSettings = workerSettings;
        //    ServiceProvider = serviceProvider;
        //}

        private readonly IUsuario _usuario;
        public Worker(ILogger<Worker> logger, IUsuario usuario)
        {
            _logger = logger;
            _usuario = usuario;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //_logger.LogInformation("Running all services");

                //using (var scope = ServiceProvider.CreateScope())
                //{
                //    var scopedProcessingService = scope.ServiceProvider.GetRequiredService<IScopedProcessingService>
                //}

                //List<Task> tasks = new()
                //{
                //    _EntryPointService.CargaCatalogoUnicoEnQliksense(_workerSettings.CargaCatalogoUnicoEnQliksense_DelayMilliseconds, stoppingToken),
                //    _EntryPointService.AnotherService(_workerSettings.AnotherServiceExample_DelayMilliseconds, stoppingToken)
                //};

                //await Task.WhenAll(tasks);


                var x  = _usuario.GetAll();
                _logger.LogInformation($"x: {x}");


                _logger.LogInformation("delay 1000");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}