using System;
using Common;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class ContextModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();

            Bind<IDomComponent>().To<Logger>().WhenInjectedInto<GrandParent>();
            Bind<IDomComponent>().To<OffLineLoggingComponent>()
                .WhenInjectedExactlyInto<ChildEngineB>();
        }
    }   
}