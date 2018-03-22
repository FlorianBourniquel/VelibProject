using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MathsLibrary
{
    [ServiceContract]
    public interface IMathsOperations
    {
        [OperationContract]
        int Add(int num1, int num2);
        [OperationContract]
        int Multiply(int num1, int num2);
        [OperationContract]
        [FaultContract(typeof(CustomFaultDetails))]
        int Divide(int num1, int num2);
    }

    [DataContract]
    internal class CustomFaultDetails
    {
        [DataMember]
        public int errorId { get; set; }
        [DataMember]
        public string error { get; set; }
    }
}
