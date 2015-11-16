using System;
using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;
 
namespace JustMockLiteDemo.BasicMocking
{
    [TestFixture]
    public class CustomerBillingServiceTests
    {
        [Test]
        public void ShouldBeAbleToGetTotalAmountDueForClient()
        {
            //Arrange
            var customerDataServiceMock = Mock.Create<ICustomerDataService>();
            var customer = Mock.Create<Customer>();
            var customerId = Guid.NewGuid();

            customer.Arrange(x => x.GetMowingCharge()).Returns(10);
            customer.Arrange(x => x.GetWateringCharge()).Returns(15);
            customer.Arrange(x => x.GetWeedingCharge()).Returns(25);
            var expectedTotal = 50;

            customerDataServiceMock.Arrange(x => x.GetCustomer(customerId)).Returns(customer);
            
            var customerBillingService = new CustomerBillingService(customerDataServiceMock);

            //Act
            var result = customerBillingService.GetCustomerCurrentAmountDue(customerId);

            //Assert
            Assert.AreEqual(expectedTotal, result);
        }
    }
}