using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace HostIncrDecr
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(IncrDecr.IncrDecrService));
                host.Open();
                Console.WriteLine("Service is Hosted as http://localhost:9012/IncrDecr");
                Console.WriteLine("\nPress  key to stop the service.");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception eX)
            {
                Console.WriteLine("There was en error while Hosting Service [" + eX.Message + "]");
                Console.WriteLine("\nPress  key to close.");
                Console.ReadLine();
            }

        }
    }
}
