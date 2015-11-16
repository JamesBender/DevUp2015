using System;

namespace JustMockLiteDemo.BasicMocking
{
    public interface ICustomerDataService
    {
        Customer GetCustomer(Guid customerId);
    }
}