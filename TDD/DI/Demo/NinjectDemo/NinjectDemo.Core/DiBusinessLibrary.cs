using System;
using NinjectDemo.Core.Database;
using NinjectDemo.Core.WsProxies;

namespace NinjectDemo.Core
{
    public interface IDiBusinessLibrary
    {
        bool DoStuff();
    }

    public class DiBusinessLibrary : IDiBusinessLibrary
    {
        private readonly IDbProvider _dbProvider;
        private readonly IProxy _proxy;
        private readonly ILoggingComponent _logger;

        public DiBusinessLibrary(IDbProvider dbProvider, IProxy proxy, ILoggingComponent logger)
        {
            _dbProvider = dbProvider;
            _proxy = proxy;
            _logger = logger;
        }
        public bool DoStuff()
        {
            var person = _dbProvider.GetPerson(42);
            var blalance = _proxy.GetBalance("lmnop");
//            if(blalance != 100)
//                throw new ArgumentException();

            _logger.WriteToLog(string.Format("Got the balance of {0} for person 42", blalance));
            _logger.WriteToLog(string.Format("Got the balance of {0} for person 42", blalance));

            return true;
        } 
    }
}