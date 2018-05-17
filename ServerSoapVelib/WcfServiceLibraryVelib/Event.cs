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
        private static Velib velib = new Velib();
        private static Dictionary<Tuple<string,string>,Action<Station>> sub = new Dictionary<Tuple<string, string>, Action<Station>>();

        public void SubscribeStationEvent(string ville,string stationName, int deltaSeconde)
        {
           
            Action<Station> call = delegate { };
            IEvent subEven = OperationContext.Current.GetCallbackChannel<IEvent>();
            call += subEven.StationUpdate;
            Action < Station > action = null;
            if (sub.ContainsKey(new Tuple<string, string>(ville,stationName)))
            {
                if (sub.TryGetValue(new Tuple<string, string>(ville,stationName),out action))
                {
                    action += subEven.StationUpdate;
                    sub[new Tuple<string, string>(ville, stationName)] = action;
                }
            }
            else
            {
                sub.Add(new Tuple<string, string>(ville, stationName),call);
            }
            
        }


        public void TriggerUpdate()
        {
           foreach (KeyValuePair<Tuple<string, string>, Action<Station>> entry in sub)
            {
                Station station = velib.GetInformationStation(entry.Key.Item1, entry.Key.Item2, 0);
                entry.Value(station);
            }
        }
    }
    
}
