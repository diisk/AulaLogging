
namespace AulaLogging.Logging
{
    public class CustomLogger : ILogger
    {
        private readonly string loggerName;
        private readonly CustomLoggerproviderConfiguration customLoggerproviderConfiguration;
        public CustomLogger(string loggerName, CustomLoggerproviderConfiguration customLoggerproviderConfiguration)
        {
            this.loggerName = loggerName;
            this.customLoggerproviderConfiguration = customLoggerproviderConfiguration;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string message = $"Log de excução {logLevel}: {eventId} - {formatter(state, exception)}";

            Console.WriteLine(message);
        }
    }
}
