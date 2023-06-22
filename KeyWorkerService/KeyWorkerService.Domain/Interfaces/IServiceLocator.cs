using Microsoft.Extensions.DependencyInjection;

namespace KeyWorkerService.Domain.Interfaces
{
    public interface IServiceLocator : IDisposable
    {
        IServiceScope CreateScope();
    }
}
