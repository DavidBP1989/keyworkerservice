using KeyWorkerService.Domain.DTOs.Local;

namespace KeyWorkerService.Application.UseCases.Local
{
    public interface IUsuario
    {
        IEnumerable<UsuarioDTO> GetAll();
        void InsertUsuario(UsuarioDTO usuario);
    }
}
