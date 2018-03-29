using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:9011/MyService/Calc/");
            //Create ServiceHost
            ServiceHost host
                = new ServiceHost(typeof(EventsLib.CalcService), httpUrl);
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(EventsLib.ICalcService)
                , new WSDualHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();

            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();

        }
    }
}
