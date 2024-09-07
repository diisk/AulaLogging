using System.Collections.Concurrent;

namespace AulaLogging.Logging
{
    public class CustomLoggerProvider : ILoggerProvider
    {
        private readonly CustomLoggerproviderConfiguration customLoggerproviderConfiguration;
        private readonly ConcurrentDictionary<string, CustomLogger> loggers = new ConcurrentDictionary<string, CustomLogger>();
        public CustomLoggerProvider(CustomLoggerproviderConfiguration customLoggerproviderConfiguration) {
            this.customLoggerproviderConfiguration = customLoggerproviderConfiguration;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return loggers.GetOrAdd(categoryName, name => new CustomLogger(name,customLoggerproviderConfiguration));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
