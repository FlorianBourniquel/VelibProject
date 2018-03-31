using System;
using System.Runtime.Serialization;

namespace WcfServiceLibraryVelib
{
    [DataContract]
    public class Position
    {
        [DataMember]
        public double lat { get; set; }
        [DataMember]
        public double lng { get; set; }

        public override string ToString()
        {
            return $"{nameof(lat)}: {lat}, {nameof(lng)}: {lng}";
        }
    }
}