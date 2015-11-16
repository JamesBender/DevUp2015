using System.Configuration;
using Ninject.Modules;
using NinjectDemo.Core.Database;
using NinjectDemo.Core.WsProxies;

namespace NinjectDemo.Core
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingComponent>().To<LoggingComponent>();
            Bind<IDbProvider>().To<OracleProvider>();
            Bind<IProxy>().To<TestProxy>();
            Bind<IDiBusinessLibrary>().To<DiBusinessLibrary>();
        }
    }
}