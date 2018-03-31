using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSoapVelib
{
    [DataContract]
    public class Station
    {
        public int number { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Position position { get; set; }
        public bool banking { get; set; }
        public bool bonus { get; set; }
        public string status { get; set; }
        public string contract_name { get; set; }
        public int bike_stands { get; set; }
        public int available_bike_stands { get; set; }
        public int available_bikes { get; set; }
        public long last_update { get; set; }

        public override string ToString()
        {
            return $"{nameof(number)}: {number}, {nameof(name)}: {name}, {nameof(address)}: {address}, {nameof(position)}: {position}, {nameof(banking)}: {banking}, {nameof(bonus)}: {bonus}, {nameof(status)}: {status}, {nameof(contract_name)}: {contract_name}, {nameof(bike_stands)}: {bike_stands}, {nameof(available_bike_stands)}: {available_bike_stands}, {nameof(available_bikes)}: {available_bikes}, {nameof(last_update)}: {last_update}";
        }
    }
}