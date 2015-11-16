using JustMockDemo.Core.Automocking.Classes;
using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.AutoMock;
 
namespace JustMockDemo.Core.Automocking
{
    [TestFixture]
    public class AutomockingTests
    {
        [Test]
        public void WithoutAutomocking()
        {
            //Arrange
            var firstDep = Mock.Create<IFirstDependency>();
            var secondDep = Mock.Create<ISecondDependency>();

            var newInstance = new ClassUnderTest(firstDep, secondDep);

            var expectedResult = "Hello";

            Mock.Arrange(() => secondDep.GetString()).Returns(expectedResult);

            //Act
            var result = newInstance.StringMethod();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WithAutomocking()
        {
            //Arrange
            var container = new MockingContainer<ClassUnderTest>();
            var expectedResult = "Hello";

            container
                .Arrange<ISecondDependency>(x => x.GetString())
                .Returns(expectedResult);

            //Act
            var result = container.Instance.StringMethod();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}