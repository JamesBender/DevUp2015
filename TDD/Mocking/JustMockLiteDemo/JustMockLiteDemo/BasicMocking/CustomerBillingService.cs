using System;
using JustMockLiteDemo.BasicMocking;

namespace JustMockLiteDemo.BasicMocking
{
    public class CustomerBillingService
    {
        private readonly ICustomerDataService _customerDataService;

        public CustomerBillingService(ICustomerDataService customerDataService)
        {
            _customerDataService = customerDataService;
        }

        public decimal GetCustomerCurrentAmountDue(Guid customerId)
        {
            var customer = _customerDataService.GetCustomer(customerId);

            var mowingCharge = customer.GetMowingCharge();
            var weedingCharge = customer.GetWeedingCharge();
            var wateringCharge = customer.GetWateringCharge();

            return mowingCharge + weedingCharge + wateringCharge;
        }
    }
}