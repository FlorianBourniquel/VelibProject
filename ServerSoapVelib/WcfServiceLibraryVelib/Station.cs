using System;
using System.Runtime.Serialization;

namespace WcfServiceLibraryVelib
{
    [DataContract]
    public class Station
    {
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public Position position { get; set; }
        [DataMember]
        public bool banking { get; set; }
        [DataMember]
        public bool bonus { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string contract_name { get; set; }
        [DataMember]
        public int bike_stands { get; set; }
        [DataMember]
        public int available_bike_stands { get; set; }
        [DataMember]
        public int available_bikes { get; set; }
        [DataMember]
        public long last_update { get; set; }
        [DataMember]
        public DateTime dateCache { get; set; }

        public override string ToString()
        {
            return $"{nameof(number)}: {number}, {nameof(name)}: {name}, {nameof(address)}: {address}, {nameof(position)}: {position}, {nameof(banking)}: {banking}, {nameof(bonus)}: {bonus}, {nameof(status)}: {status}, {nameof(contract_name)}: {contract_name}, {nameof(bike_stands)}: {bike_stands}, {nameof(available_bike_stands)}: {available_bike_stands}, {nameof(available_bikes)}: {available_bikes}, {nameof(last_update)}: {last_update}, {nameof(dateCache)}: {dateCache}";
        }
    }
}