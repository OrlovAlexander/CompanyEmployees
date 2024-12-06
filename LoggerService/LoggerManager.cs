using Contracts;
using NLog;

namespace LoggerService;

public class LoggerManager : ILoggerManager
{
    private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

    /// <inheritdoc />
    public void LogInfo(string message) => Logger.Info(message);

    /// <inheritdoc />
    public void LogWarn(string message) => Logger.Warn(message);

    /// <inheritdoc />
    public void LogDebug(string message) => Logger.Debug(message);

    /// <inheritdoc />
    public void LogError(string message) => Logger.Error(message);
}
