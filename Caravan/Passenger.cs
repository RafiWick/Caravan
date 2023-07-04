using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan
{
    public class Passenger
    {
        public string Name;
        public int Age;
        public string Destination;
        public Wagon Wagon;
        
        public Passenger(string name, int age, string destination, Wagon wagon)
        {
            Name = name;
            Age = age;
            Destination = destination;
            Wagon = wagon;
        }
    }
}
