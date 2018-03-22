using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                CustomFaultDetails ex = new CustomFaultDetails
                {
                    errorId = 123,
                    error = "Division par 0"
                };
                throw new FaultException<CustomFaultDetails>(ex,"Reason: Testing…..");

            }
            return (num1 / num2);
        }
    }
}
