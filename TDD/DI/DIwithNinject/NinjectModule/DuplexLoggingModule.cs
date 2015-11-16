using System;
using Common;
using Ninject.Core;
using Ninject.Modules;

namespace NinjectModules
{
    public class DuplexLoggingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<DoubleLoggingEngine>().ToSelf();

            Bind<IComponent>().To<OffLineLoggingComponent>();

            Bind<IComponent>().To<SpecialLoggingComponent>().WhenMemberHas<SpecialLogger>();

        }
    }
}