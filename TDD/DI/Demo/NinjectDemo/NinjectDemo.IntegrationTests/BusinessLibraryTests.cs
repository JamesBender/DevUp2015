using NUnit.Framework;
using Ninject;
using NinjectDemo.Core;

namespace NinjectDemo.IntegrationTests
{
    [TestFixture]
    public class BusinessLibraryTests
    {
        [Test]
        public void ShouldTestBusinessLibraryInIntegration()
        {
            var kernel = new StandardKernel(new DomainModule());
            var businessLibrary = kernel.Get<IDiBusinessLibrary>();

            var result = businessLibrary.DoStuff();

            Assert.IsTrue(result);
        }
    }
}