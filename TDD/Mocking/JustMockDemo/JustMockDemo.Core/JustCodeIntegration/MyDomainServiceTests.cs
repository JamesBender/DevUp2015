using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace JustMockDemo.Core.JustCodeIntegration
{
    [TestFixture]
    public class MyDomainServiceTests
    {
        [Test]
        public void DemonstrateJustMockJustCodeIntegration()
        {
            IMyInterface myInterfaceMock = Mock.Create<IMyInterface>();
            myInterfaceMock.Arrange(x => x.Everywhere(Arg.AnyString, Arg.AnyInt, Arg.AnyInt)).Returns(0M);
            myInterfaceMock.Arrange(x => x.Here(Arg.AnyString, Arg.AnyGuid)).Returns(false);
            myInterfaceMock.Arrange(x => x.There(Arg.AnyString, Arg.IsAny<System.DateTime>())).Returns("");
        }
        
    }
}