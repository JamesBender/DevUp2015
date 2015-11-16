using System;
using System.Linq;
using NinjectDemo.Core;

namespace Ninject.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var staticLibrary = new StaticDependencyBusinessLibrary();
            //staticLibrary.DoStuff();
            
            Console.WriteLine("============================================");

            var kernel = new StandardKernel(new DomainModule());
            //var kernel = new StandardKernel(new ConditionalModule());
            var diLibrary = kernel.Get<IDiBusinessLibrary>();
            diLibrary.DoStuff();

            Console.WriteLine();
            Console.WriteLine("Done, press any key to continue.");
            Console.ReadKey();
        }
    }
}
