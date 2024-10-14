using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        override public string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
