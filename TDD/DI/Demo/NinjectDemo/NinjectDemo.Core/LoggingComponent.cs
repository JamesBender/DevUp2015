using System;
using System.Threading;

namespace NinjectDemo.Core
{
    public interface ILoggingComponent
    {
        void WriteToLog(string message);
    }

    public class LoggingComponent : ILoggingComponent
    {
        public void WriteToLog(string message)
        {
            Thread.Sleep(3000);
            Console.WriteLine(string.Format("Logger: {0}", message));
        }
    }
}