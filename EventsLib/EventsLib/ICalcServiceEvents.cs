using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib
{
    [ServiceContract]
    interface ICalcServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void Calculated(int nOp, double dblNum1, double dblNum2, double dblResult);

        [OperationContract(IsOneWay = true)]
        void CalculationFinished();
    }
}
