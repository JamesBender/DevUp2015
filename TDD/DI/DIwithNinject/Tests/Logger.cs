using System;
using System.Diagnostics;

namespace Tests
{
    public interface ILogger
    {
        void Log();
    }

    public class Logger : ILogger
    {
        public void Log()
        {
            const string logMsg = "logged";
            Console.WriteLine(logMsg);
            Debug.WriteLine(logMsg);
        }
    }
}