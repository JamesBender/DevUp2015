using System;
using Common;

namespace WithoutNinject
{
    class Program
    {
        static void Main()
        {
            var loggingSync = new NormalLoggingSync();
            var component = new Logger(loggingSync);
            var simpleEngine = new SimpleBusinessEngine(component);

            simpleEngine.RunProcess();

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}