using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryVelib
{
    class EventArgs
    {
        public string stationName { get; set; }
        public string ville { get; set; }
        public int deltaSeconde { get; set; }
        public IEvent CallbEvent { get; set; }

        public EventArgs(string stationName, string ville, int deltaSeconde, IEvent callbEvent)
        {
            this.stationName = stationName;
            this.ville = ville;
            this.deltaSeconde = deltaSeconde;
            CallbEvent = callbEvent;
        }

        protected bool Equals(EventArgs other)
        {
            return string.Equals(stationName, other.stationName) && string.Equals(ville, other.ville) && deltaSeconde == other.deltaSeconde && Equals(CallbEvent, other.CallbEvent);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EventArgs) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (stationName != null ? stationName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ville != null ? ville.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ deltaSeconde;
                hashCode = (hashCode * 397) ^ (CallbEvent != null ? CallbEvent.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(EventArgs left, EventArgs right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EventArgs left, EventArgs right)
        {
            return !Equals(left, right);
        }
    }
}
