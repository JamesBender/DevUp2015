using System;

namespace Common
{
    public interface ILoggingSink
    {
        string LoggingResult();
    }

    public class NormalLoggingSync : ILoggingSink
    {
        public string LoggingResult()
        {
            return "Normal Logging";
        }
    }

    public class DistributedLoggingSync : ILoggingSink
    {
        public string LoggingResult()
        {
            return "Distributed Logging";
        }
    }
}