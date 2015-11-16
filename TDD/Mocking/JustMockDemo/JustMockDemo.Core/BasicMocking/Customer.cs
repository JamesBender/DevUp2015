using System;

namespace JustMockDemo.Core.BasicMocking
{
    public interface ICustomer
    {
        decimal GetWateringCharge();

        decimal GetWeedingCharge();

        decimal GetMowingCharge();

        string Name { get; set; }
    }
}