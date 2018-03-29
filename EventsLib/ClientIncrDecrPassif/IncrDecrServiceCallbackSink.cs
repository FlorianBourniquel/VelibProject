using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientIncrDecrPassif
{
    class IncrDecrServiceCallbackSink: ServiceIncrDecr.IIncrDecrServiceCallback 
    {

        public void IncrFinished(int val)
        {
            Console.WriteLine("Incr ...: {0}", val);
        }

        public void DecrFinished(int val)
        {
            Console.WriteLine("Decr ...: {0}", val);
        }
    }
}

