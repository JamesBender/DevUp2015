using Common;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class DistributedLoggingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingSink>().To<DistributedLoggingSync>();
            Bind<IDomComponent>().To<Logger>();
            Bind<SimpleBusinessEngine>().ToSelf();
        }
    }    
}
