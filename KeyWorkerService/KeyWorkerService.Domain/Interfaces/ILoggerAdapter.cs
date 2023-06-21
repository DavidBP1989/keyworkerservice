namespace KeyWorkerService.Domain.Interfaces
{
    public interface ILoggerAdapter<T>
    {
        void LogInformation(string message, params object[] args);
    }
}
