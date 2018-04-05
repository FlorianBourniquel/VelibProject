using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryVelib
{
    class Event : ISubEvent
    {
        private static readonly List<EventArgs> CallbackChannels = new List<EventArgs>();
        private static Velib velib = new Velib();

        public void SubscribeStationEvent(string ville,string stationName, int deltaSeconde)
        {
            EventArgs subscriber = new EventArgs(stationName,ville,deltaSeconde,OperationContext.Current.GetCallbackChannel<IEvent>());
            if (!CallbackChannels.Contains(subscriber))
            {
                CallbackChannels.Add(subscriber);
            }
        }

        public void UnsubscribeStationEvent(string ville, string stationName, int deltaSeconde)
        {
            EventArgs subscriber = new EventArgs(stationName, ville, deltaSeconde, OperationContext.Current.GetCallbackChannel<IEvent>());
            if (CallbackChannels.Contains(subscriber))
            {
                CallbackChannels.Remove(subscriber);
            }
        }

        public void TriggerUpdate()
        {
            foreach (var eventArg in CallbackChannels)
            {
                Station station = velib.GetInformationStation(eventArg.ville, eventArg.stationName, eventArg.deltaSeconde);
                try
                {
                    eventArg.CallbEvent.StationUpdate(station);
                }
                catch (TimeoutException e)
                {
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }
    }
}
