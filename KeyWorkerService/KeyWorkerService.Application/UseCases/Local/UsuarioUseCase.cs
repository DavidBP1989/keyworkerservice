using KeyWorkerService.Domain.DTOs.Local;
using KeyWorkerService.Domain.Interfaces;
using KeyWorkerService.Domain.Models.LocalContext;
using Microsoft.Extensions.DependencyInjection;

namespace KeyWorkerService.Application.UseCases.Local
{
    public class UsuarioUseCase : IUsuario
    {
        //private readonly IServiceLocator _context;
        //public UsuarioUseCase(IServiceLocator context)
        //{
        //    _context = context;
        //}
        private readonly IServiceLocator _service;
        public UsuarioUseCase(IServiceLocator service)
        {
            _service = service;
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            //using var scope = _context.CreateScope();
            //var repository = scope.ServiceProvider.getser();
            //return _context.Usuarios.Select(x => new UsuarioDTO
            //{
            //    Age = x.Age,
            //    Name = x.Name
            //}).ToList();
            using var scope = _service.CreateScope();
            var repository = scope.ServiceProvider.GetService<IRepository>();
            return repository.GetAll<Usuario>().Select(x => new UsuarioDTO
            {
                Age = x.Age,
                Name = x.Name
            });
        }

        public void InsertUsuario(UsuarioDTO usuario)
        {
            //_context.Add(new Usuario
            //{
            //    Name = usuario.Name,
            //    Age = usuario.Age
            //});
            //_context.SaveChanges();
        }
    }
}
