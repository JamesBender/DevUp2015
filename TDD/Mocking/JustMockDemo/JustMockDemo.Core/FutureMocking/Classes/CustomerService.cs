using System;

namespace JustMockDemo.Core.FutureMocking.Classes
{
    public class CustomerService
    {
        public Customer GetCustomer(Guid customerId)
        {
            return new Customer { Id = Guid.NewGuid(), Name = "Static" };
        }
    }
}