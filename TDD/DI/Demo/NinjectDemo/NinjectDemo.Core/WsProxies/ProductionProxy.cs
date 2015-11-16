using System;
using System.Threading;

namespace NinjectDemo.Core.WsProxies
{
    public class ProductionProxy : IProxy
    {
        public int GetBalance(string accountNumbr)
        {
            Thread.Sleep(2000);
            Console.WriteLine("ProductionProxy: getting balance");
            return 1000;
        }
    }
}