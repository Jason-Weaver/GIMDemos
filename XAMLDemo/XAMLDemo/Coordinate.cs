using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLDemo
{
    public struct Coordinate
    {
        private readonly double _latitude;
        private readonly double _longitude;

        // Wrap Variables
        public double Latitude { get { return _latitude; } }
        public double Longitude { get { return _longitude; } }

        public Coordinate(double lat, double lon)
        {
            _latitude = lat;
            _longitude = lon;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Latitude, Longitude);
        }

        public override bool Equals(object coord)
        {
            // Equality of value, and not reference, based
            if (coord is Coordinate)
            {
                return (Latitude == ((Coordinate)coord).Latitude) && (Longitude == ((Coordinate)coord).Longitude);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 2105055860;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Latitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Longitude.GetHashCode();
            return hashCode;
        }
    }
}
