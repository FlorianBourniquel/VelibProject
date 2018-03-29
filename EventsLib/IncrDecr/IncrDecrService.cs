using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IncrDecr
{
    public class IncrDecrService : IIncrDecrService
    {
        private static int cpt = 0;
        static Action<int> m_Event1 = delegate { };
        static Action<int> m_Event2 = delegate { };

        public void Decr()
        {
            cpt--;
            m_Event2(cpt);
        }

        public void Incr()
        {
            cpt++;
            m_Event1(cpt);
        }

        public void SubscribeIncrEvent()
        {
            IIncDecrServiceEvents subscriber =
                OperationContext.Current.GetCallbackChannel<IIncDecrServiceEvents>();
            m_Event1 += subscriber.IncrFinished; ;
        }

        public void SubscribeDecrEvent()
        {
            IIncDecrServiceEvents subscriber =
                OperationContext.Current.GetCallbackChannel<IIncDecrServiceEvents>();
            m_Event2 += subscriber.DecrFinished; ;
        }
    }
}
