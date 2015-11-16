using System;
using System.Threading;
using NinjectDemo.Core.Entites;

namespace NinjectDemo.Core.Database
{
    public interface IDbProvider
    {
        Person GetPerson(int personId);
    }

    public class SqlProvider : IDbProvider
    {
        private ILoggingComponent _logger;

        public SqlProvider(ILoggingComponent logger)
        {
            _logger = logger;
        }

        public Person GetPerson(int personId)
        {
            Thread.Sleep(3000);
            _logger.WriteToLog("SqlProvider: Getting a person") ;
            return new Person();
        }
    }

    public class OracleProvider : IDbProvider
    {
        private ILoggingComponent _logger;

        public OracleProvider(ILoggingComponent logger)
        {
            _logger = logger;
        }
        public Person GetPerson(int personId)
        {
            Thread.Sleep(3000);
            _logger.WriteToLog("OracleProvider: Getting a person");
            return new Person();
        }
    }

    public class DbProvider : IDbProvider
    {
        private ILoggingComponent _logger;

        public DbProvider(ILoggingComponent logger)
        {
            _logger = logger;
        }

        public Person GetPerson(int personId)
        {
            Thread.Sleep(3000);
            _logger.WriteToLog("SqlProvider: Getting a person");
            return new Person();
        }
    }
}