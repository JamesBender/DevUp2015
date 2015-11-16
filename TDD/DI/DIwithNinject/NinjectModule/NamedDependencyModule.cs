using System;
using Common;
using Ninject.Core;
using Ninject.Modules;

namespace NinjectModules
{
    public class NamedDependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IComponent>().To<Logger>().Named("Simple");
        }
    }
}