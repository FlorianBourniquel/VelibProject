using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsole.EventStation;

namespace ClientConsole
{
    class EventStationCallbackSink : EventStation.ISubEventCallback
    {
        public void StationUpdate(Station station)
        {
            if (station != null)
            {
                Console.WriteLine("Nombre de velos disponibles dans la station " + station.name + " :" + station.available_bikes);
            }
        }
    }
}
