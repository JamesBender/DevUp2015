using System;

namespace JustMockDemo.Core.BasicMocking
{
    public interface ICustomerDataService
    {
        ICustomer GetCustomer(Guid customerId);
    }
}