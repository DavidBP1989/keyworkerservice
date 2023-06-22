using KeyWorkerService.Domain.Interfaces;

namespace KeyWorkerService.Infrastructure.DataContext.Local
{
    public class DefaultContextRepository : IRepository
    {
        private readonly DefaultContext _context;
        public DefaultContextRepository(DefaultContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }
    }
}
