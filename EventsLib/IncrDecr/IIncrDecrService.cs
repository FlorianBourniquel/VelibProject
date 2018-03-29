using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace  IncrDecr

{
    [ServiceContract(CallbackContract = typeof(IIncDecrServiceEvents))]
    public interface IIncrDecrService
    {
        [OperationContract]
        void Decr();

        [OperationContract]
        void Incr();

        [OperationContract]
        void SubscribeIncrEvent();

        [OperationContract]
        void SubscribeDecrEvent();
    }
}
