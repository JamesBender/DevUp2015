using System;
using JustMockDemo.Core.FutureMocking.Classes;
using NUnit.Framework;
using Telerik.JustMock;

namespace JustMockDemo.Core.FutureMocking
{
    [TestFixture]
    public class FutureMockTest
    {
        [Test]
        public void ShouldBeAbleToGetCustomerName()
        {
            var expectedResult = "mocked";
            var expectedCustomer = new Customer { Name = expectedResult };
            var customerId = Guid.NewGuid();
            var mockedCustomerService = Mock.Create<CustomerService>();

            Mock.Arrange(() => mockedCustomerService.GetCustomer(customerId))
                .IgnoreInstance().Returns(expectedCustomer);

            var orderService = new OrderService();

            var result = orderService.GetCustomerName(customerId);

            Assert.AreEqual(expectedResult, result);
        }
    }
}