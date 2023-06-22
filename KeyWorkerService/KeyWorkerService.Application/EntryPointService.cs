using KeyWorkerService.Application.UseCases.Local;
using KeyWorkerService.Domain.Interfaces;

namespace KeyWorkerService.Application
{
    public class EntryPointService : IEntryPointService
    {
        private readonly ILoggerAdapter<EntryPointService> _logger;
        private readonly IUsuario _usuario;
        public EntryPointService(ILoggerAdapter<EntryPointService> logger)
        {
            _logger = logger;
            //_usuario = usuario;
        }

        public async Task AnotherService(int delay, CancellationToken cancellationToken)
        {
            _logger.LogInformation("another service");
            //_usuario.InsertUsuario(new Domain.DTOs.Local.UsuarioDTO
            //{
            //    Name = "David",
            //    Age = 3
            //});
            await Task.Delay(delay, cancellationToken);
        }

        public async Task CargaCatalogoUnicoEnQliksense(int delay, CancellationToken cancellationToken)
        {
            _logger.LogInformation("catalogo unico");
            
            await Task.Delay(delay, cancellationToken);
        }
    }
}
