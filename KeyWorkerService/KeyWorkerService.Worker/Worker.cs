using KeyWorkerService.Application;

namespace KeyWorkerService.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IEntryPointService _EntryPointService;
        private readonly WorkerSettings _workerSettings;

        //public Worker(ILogger<Worker> logger, IEntryPointService entryPointService, WorkerSettings workerSettings)
        //{
        //    _logger = logger;
        //    _EntryPointService = entryPointService;
        //    _workerSettings = workerSettings;
        //}
        public Worker(ILogger<Worker> logger, IEntryPointService entryPointService)
        {
            _logger = logger;
            _EntryPointService = entryPointService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Running all services");
                //List<Task> tasks = new()
                //{
                //    _EntryPointService.CargaCatalogoUnicoEnQliksense(_workerSettings.CargaCatalogoUnicoEnQliksense_DelayMilliseconds, stoppingToken)
                //};

                //await Task.WhenAll(tasks);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}