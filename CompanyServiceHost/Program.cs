using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyServiceHost
{
    class Program
    {
        static void Main()
        {
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(CompanyService.CompanyService)))
            {
                host.Open();
                Console.WriteLine("Host started in @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }


        }
    }
}
