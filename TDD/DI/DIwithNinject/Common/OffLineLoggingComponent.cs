using System;

namespace Common
{
    public class OffLineLoggingComponent : IDomComponent
    {
        public string Execute()
        {
            return "logged off line.";
        }
    }
}