using KeyWorkerService.Domain.DTOs.Local;
using KeyWorkerService.Domain.Models.LocalContext;

namespace KeyWorkerService.Application.UseCases.Local
{
    public class UsuarioUseCase : IUsuario
    {
        private readonly DefaultContext _context;
        public UsuarioUseCase(DefaultContext context)
        {
            _context = context;
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            return _context.Usuarios.Select(x => new UsuarioDTO
            {
                Age = x.Age,
                Name = x.Name
            }).ToList();
        }

        public void InsertUsuario(UsuarioDTO usuario)
        {
            _context.Add(new Usuario
            {
                Name = usuario.Name,
                Age = usuario.Age
            });
            _context.SaveChanges();
        }
    }
}
