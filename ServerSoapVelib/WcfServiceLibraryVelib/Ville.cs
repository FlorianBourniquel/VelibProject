using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfServiceLibraryVelib
{
    [DataContract]
    public class Ville
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public List<string> cities { get; set; }
        [DataMember]
        public string commercial_name { get; set; }
        [DataMember]
        public string country_code { get; set; }
        [DataMember]
        public DateTime dateCache { get; set; }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(cities)}: {cities}, {nameof(commercial_name)}: {commercial_name}, {nameof(country_code)}: {country_code}, {nameof(dateCache)}: {dateCache}";
        }
    }
}