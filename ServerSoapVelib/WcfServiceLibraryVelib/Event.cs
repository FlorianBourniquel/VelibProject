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
        private static Dictionary<Tuple<string,string>,List<Action<Station>>> sub = new Dictionary<Tuple<string, string>, List<Action<Station>>>();

        public void SubscribeStationEvent(string ville,string stationName, int deltaSeconde)
        {
           
            Action<Station> call = delegate { };
            IEvent subEven = OperationContext.Current.GetCallbackChannel<IEvent>();
            call += subEven.StationUpdate;
            List <Action < Station >> list = null;
            if (sub.ContainsKey(new Tuple<string, string>(ville,stationName)))
            {
                if (sub.TryGetValue(new Tuple<string, string>(ville,stationName),out list))
                {
                    list.Add(call);
                    sub[new Tuple<string, string>(ville, stationName)] =list;
                }
            }
            else
            {
                list = new List<Action<Station>>();
                list.Add(call);
                sub.Add(new Tuple<string, string>(ville, stationName),list);
            }
            
        }


        public void TriggerUpdate()
        {
           
            List<Action<Station>> list = null;

  
            foreach (KeyValuePair<Tuple<string, string>, List<Action<Station>>> entry in sub)
            {
                Station station = velib.GetInformationStation(entry.Key.Item1, entry.Key.Item2, 0);
                foreach (Action<Station> action in entry.Value)
                {
                    action(station);
                }
            }



        }
    }
    
}
