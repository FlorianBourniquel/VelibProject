using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientIncrDecr
{
    class Program
    {
        static void Main(string[] args)
        {
            IncrDecrServiceCallbackSink objsink = new IncrDecrServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);

            ServiceIncrDecr.IncrDecrServiceClient objClient = new ServiceIncrDecr.IncrDecrServiceClient(iCntxt);
            objClient.SubscribeDecrEvent();
            objClient.SubscribeIncrEvent();

            objClient.Incr();
            objClient.Incr();

            objClient.Decr();

            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
