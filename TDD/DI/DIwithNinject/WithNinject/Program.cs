using System;
using Common;
using MyNinjectModules;
using Ninject;

namespace WithNinject
{
    class Program
    {
        static void Main()
        {
            SimpleBusinessEngine simpleEngine;
            IKernel kernel;

            #region Example 1

//            kernel = new StandardKernel(new DistributedLoggingModule());
//
//            simpleEngine = kernel.Get<SimpleBusinessEngine>();
//            simpleEngine.RunProcess();

            #endregion

            #region Example 2

//            var connectedKernel =
//                new StandardKernel(new ConditionalLoggingModule(true));
//            var disconnectedKernel = 
//                new StandardKernel(new ConditionalLoggingModule(false));
//
//            simpleEngine = connectedKernel.Get<SimpleBusinessEngine>();
//            simpleEngine.RunProcess();
//            simpleEngine = disconnectedKernel.Get<SimpleBusinessEngine>();
//            simpleEngine.RunProcess();

            #endregion

            #region Example 3

//            kernel = new StandardKernel(new CtorAndMethodModule());
//
//            var ctorEngine = kernel.Get<CtorEndMethodEngine>();
//
//            ctorEngine.RunProcess();
            
            #endregion

            #region Example 4

            kernel = new StandardKernel(new NamedDependencyModule());

            var namedEngine = kernel.Get<NamedLoggerEngine>();
            namedEngine.RunProcess();

            #endregion

            #region Example 5

//            kernel = new StandardKernel(new DuplexLoggingModule());
//
//            simpleEngine = kernel.Get<DoubleLoggingEngine>();
//            simpleEngine.RunProcess();

            #endregion

            #region Example 6

            kernel = new StandardKernel(new ContextModule());

            var childA = kernel.Get<ChildEngineA>();
            var childB = kernel.Get<ChildEngineB>();

            childA.RunProcess();
            childB.RunProcess();

            #endregion

            Console.ReadKey();
        }
    }
}
