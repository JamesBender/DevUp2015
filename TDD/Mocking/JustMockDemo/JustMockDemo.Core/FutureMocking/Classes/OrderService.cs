using System;

namespace JustMockDemo.Core.FutureMocking.Classes
{
    public class OrderService
    {
        private CustomerService _customerService;

        public OrderService()
        {
            _customerService = new CustomerService();
        }

        public string GetCustomerName(Guid customerId)
        {
            var customer = _customerService.GetCustomer(customerId);
            return customer.Name;
        }
    }
}