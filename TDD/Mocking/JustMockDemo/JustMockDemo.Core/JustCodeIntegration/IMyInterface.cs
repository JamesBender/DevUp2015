using System;

namespace JustMockDemo.Core.JustCodeIntegration
{
    public interface IMyInterface
    {
        bool Here(string customerId, Guid locationId);

        string There(string customerId, DateTime dateItHappened);

        decimal Everywhere(string customerId, int upperBound, int lowerBound);
    }
}