using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan
{
    public class Wagon
    {
        public string Name;
        public int NumWheels;
        public bool IsCovered;
        public List<Passenger> Passengers;

        public Wagon(string name, int numWheels, bool isCovered)
        {
            Name = name;
            NumWheels = numWheels;
            IsCovered = isCovered;
            Passengers = new List<Passenger>();
        }
    }
}
