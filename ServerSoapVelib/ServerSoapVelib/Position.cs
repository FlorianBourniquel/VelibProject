using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerSoapVelib
{
    [DataContract]
    public class Position
    {
        public double lat { get; set; }
        public double lng { get; set; }

        public override string ToString()
        {
            return $"{nameof(lat)}: {lat}, {nameof(lng)}: {lng}";
        }
    }
}