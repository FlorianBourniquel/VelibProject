using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IncrDecr
{
    [ServiceContract]
    interface IIncDecrServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void IncrFinished(int val);

        [OperationContract(IsOneWay = true)]
        void DecrFinished(int val);
    }
}
