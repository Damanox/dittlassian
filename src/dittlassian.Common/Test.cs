using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;


namespace dittlassian.DI
{
    public class ColoredConsoleLoggerProvider : ILoggerProvider
    {
        public ColoredConsoleLoggerProvider()
        {
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new Items();
        }
        public void Dispose()
        {
        }
    }
    public class Items : ILogger
    {
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            return;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }
    }
}
