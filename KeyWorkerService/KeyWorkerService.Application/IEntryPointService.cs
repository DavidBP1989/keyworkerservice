namespace KeyWorkerService.Application
{
    public interface IEntryPointService
    {
        Task CargaCatalogoUnicoEnQliksense(int delay, CancellationToken cancellationToken);
        Task AnotherService(int delay, CancellationToken cancellationToken);
    }
}
