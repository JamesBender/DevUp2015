using System;
using Ninject;

namespace Common
{
    public class NamedLoggerEngine : IBusinessEngine
    {
        private readonly IDomComponent _simpleLogger;
        private readonly IDomComponent _distLogger;

        public NamedLoggerEngine([Named("Simple")] IDomComponent simpleLogger, 
            [Named("DistLogger")] IDomComponent distLogger)
        {
            _simpleLogger = simpleLogger;
            _distLogger = distLogger;
        }

        public string RunProcess()
        {
            Console.WriteLine("Simple logger says {0}", _simpleLogger.Execute());
            Console.WriteLine("Dist logger says {0}", _distLogger.Execute());
            return "done";
        }
    }
}