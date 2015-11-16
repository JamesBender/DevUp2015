using System;
using System.Threading;

namespace NinjectDemo.Core.WsProxies
{
    public class TestProxy : IProxy
    {
        public int GetBalance(string accountNumbr)
        {
            Thread.Sleep(3000);
            Console.WriteLine("TestProxy: getting balance");
            return 1000;
        }
    }
}