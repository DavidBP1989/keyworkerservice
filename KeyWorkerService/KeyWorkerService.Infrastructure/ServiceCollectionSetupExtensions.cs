using KeyWorkerService.Application.UseCases.Local;
using KeyWorkerService.Infrastructure.DataContext.Local;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KeyWorkerService.Infrastructure
{
    public static class ServiceCollectionSetupExtensions
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DefaultContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Local"))
            );
        }

        public static void AddUseCaseServices(this IServiceCollection services)
        {
            services.AddSingleton<IUsuario, UsuarioUseCase>();
        }
    }
}
