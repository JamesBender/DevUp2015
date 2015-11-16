using Common;
using Ninject.Core;
using Ninject.Modules;

namespace NinjectModules
{
    public class DistributedLoggingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<IComponent>().To<Logger>();
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }    
}
