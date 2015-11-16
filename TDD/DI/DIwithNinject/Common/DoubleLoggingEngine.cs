using System;
using Ninject;

namespace Common
{
    public class DoubleLoggingEngine : SimpleBusinessEngine
    {
        public DoubleLoggingEngine(IDomComponent primaryLogger)
            : base(primaryLogger)
        {
        }

        [Inject, SpecialLogger]
        public IDomComponent SecondLogger { get; set; }

        public override string RunProcess()
        {
            base.RunProcess();
            var returnValue =
                string.Format("Transaction run | {0} | logged in second logger.", SecondLogger.Execute());
            Console.WriteLine(returnValue);
            return returnValue;
        }
    }
}