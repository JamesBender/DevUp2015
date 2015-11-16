using System;
using Common;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class NamedDependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();            
            Bind<IDomComponent>().To<Logger>().Named("Simple");
            Bind<IDomComponent>().To<OffLineLoggingComponent>().Named("DistLogger");
        }
    }
}