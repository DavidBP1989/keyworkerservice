using KeyWorkerService.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace KeyWorkerService.Infrastructure
{
    public class ServiceScopeFactoryLocator : IServiceLocator
    {
        private IServiceScope? _scope;
        public IServiceScopeFactory _factory { get; }
        public ServiceScopeFactoryLocator(IServiceScopeFactory scopeFactory)
        {
            _factory = scopeFactory;
        }

        IServiceScope IServiceLocator.CreateScope()
        {
            _scope = _factory.CreateScope();
            return _scope;
        }

        void IDisposable.Dispose()
        {
            _scope?.Dispose();
            _scope = null;
        }
    }
}
