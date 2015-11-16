using NUnit.Framework;
using NinjectDemo.Core;
using NinjectDemo.Core.Database;
using NinjectDemo.Core.Entites;
using NinjectDemo.Core.WsProxies;
using Telerik.JustMock;

namespace NinjectDemo.UnitTests
{
    [TestFixture]
    public class BusinessLibraryTests
    {
        [Test]
        public void ShouldTestBusinessLogicIsolation()
        {
            var dbProviderMock = Mock.Create<IDbProvider>();
            var loggerMock = Mock.Create<ILoggingComponent>();
            var proxyMock = Mock.Create<IProxy>();

            var personToTestWith = new Person();
            const int personId = 42;
            const string accountNumber = "lmnop";


            Mock.Arrange(() => dbProviderMock.GetPerson(personId)).Returns(personToTestWith);

            var businessLibrary = new DiBusinessLibrary(dbProviderMock, proxyMock, loggerMock);

            businessLibrary.DoStuff();

            Mock.Assert(() => dbProviderMock.GetPerson(personId), Occurs.Once());
            Mock.Assert(() => proxyMock.GetBalance(accountNumber), Occurs.Once());
            Mock.Assert(() => loggerMock.WriteToLog(Arg.IsAny<string>()), Occurs.Exactly(2));            
        }

        [Test]
        public void TestSomething()
        {
            var board = new char[3,3]{{' ',' ',' '}, {' ',' ',' '},{' ',' ',' '}};

            Assert.Pass();
        }
    }
}