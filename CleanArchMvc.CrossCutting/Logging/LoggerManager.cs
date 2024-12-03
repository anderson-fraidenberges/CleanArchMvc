using Serilog;


namespace CleanArchMvc.CrossCutting.Logging
{
    public class LoggerManager : ILoggerManager
    {
        private static readonly ILogger _logger = Log.Logger;

        public void LogInfo(string message) => _logger.Information(message);
        public void LogWarn(string message) => _logger.Warning(message);
        public void LogError(string message) => _logger.Error(message);
        public void LogDebug(string message) => _logger.Debug(message);
    }

}