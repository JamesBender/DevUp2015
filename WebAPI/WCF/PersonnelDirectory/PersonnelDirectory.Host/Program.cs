using System;
using System.ServiceModel.Web;
using PersonnelDirectory.WCF;

namespace PersonnelDirectory.Host
{
    class Program
    {
        static void Main()
        {
            var webServiceHost = new WebServiceHost(typeof(DirectoryService));

            webServiceHost.Open();
            Console.WriteLine("Simple HTTP Service Listening");
            Console.WriteLine("Press enter to stop service");
            Console.ReadLine();
        }
    }
}
