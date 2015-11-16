using System.Configuration;
using Ninject.Activation;
using Ninject.Modules;
using NinjectDemo.Core.Database;
using NinjectDemo.Core.WsProxies;

namespace NinjectDemo.Core
{
    public class ConditionalModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoggingComponent>().To<LoggingComponent>();
                        
            var environment = ConfigurationManager.AppSettings["environment"];

            if (environment == "test")
            {
                Bind<IDbProvider>().To<SqlProvider>();
            }
            else
            {
                Bind<IDbProvider>().To<OracleProvider>();
            }

            Bind<IProxy>().ToProvider<ProxyProvider>();
            Bind<IDiBusinessLibrary>().To<DiBusinessLibrary>();
        }
    }

    public class ProxyProvider : Provider<IProxy>
    {
        protected override IProxy CreateInstance(IContext context)
        {
            var environment = ConfigurationManager.AppSettings["environment"];
            
            if (environment == "test")
            {
                return new TestProxy();
            }
            return new ProductionProxy();
        }
    }
}