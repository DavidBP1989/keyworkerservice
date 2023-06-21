using KeyWorkerService.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace KeyWorkerService.Infrastructure
{
    public class LoggerAdapter<T> : ILoggerAdapter<T>
    {
        private readonly ILogger _logger;
        public LoggerAdapter(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }
    }
}
