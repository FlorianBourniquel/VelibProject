using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSoapVelib
{
    [DataContract]
    public class Ville
    {
        public string name { get; set; }
        public List<string> cities { get; set; }
        public string commercial_name { get; set; }
        public string country_code { get; set; }
    }
}