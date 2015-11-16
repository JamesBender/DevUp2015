using NinjectDemo.Core.Database;
using NinjectDemo.Core.WsProxies;

namespace NinjectDemo.Core
{
    public class StaticDependencyBusinessLibrary
    {
        private readonly IDbProvider _dbProvider;
        private readonly IProxy _proxy;
        private readonly ILoggingComponent _logger;

        public StaticDependencyBusinessLibrary()
        {
            _logger = new LoggingComponent();
            _dbProvider = new SqlProvider(_logger);
            _proxy = new TestProxy();            
        }

        public void DoStuff()
        {
            var person = _dbProvider.GetPerson(42);
            var blalance = _proxy.GetBalance("lmnop");

            _logger.WriteToLog(string.Format("Got the balance of {0} for person 42", blalance));
        }
    }
}