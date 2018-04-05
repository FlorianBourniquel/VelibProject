using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryVelib
{
    [ServiceContract(CallbackContract = typeof(IEvent))]
    interface ISubEvent
    {
        [OperationContract]
        void SubscribeStationEvent(string ville,string stationName, int deltaSeconde);

        [OperationContract]
        void UnsubscribeStationEvent(string ville, string stationName, int deltaSeconde);

        void TriggerUpdate();
    }
}
