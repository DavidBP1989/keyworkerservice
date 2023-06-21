using KeyWorkerService.Domain.Interfaces;

namespace KeyWorkerService.Application
{
    public class EntryPointService : IEntryPointService
    {
        private readonly ILoggerAdapter<EntryPointService> _logger;
        public EntryPointService(ILoggerAdapter<EntryPointService> logger)
        {
            _logger = logger;
        }

        public async Task AnotherService(int delay, CancellationToken cancellationToken)
        {
            _logger.LogInformation("another service");
            await Task.Delay(delay, cancellationToken);
        }

        public async Task CargaCatalogoUnicoEnQliksense(int delay, CancellationToken cancellationToken)
        {
            _logger.LogInformation("catalogo unico");
            await Task.Delay(delay, cancellationToken);
        }
    }
}
