namespace KeyWorkerService.Domain.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> GetAll<T>() where T: class;
    }
}
