using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Models
{
    public class Wagon
    {
        public int Id { get; set; }
        public string Name{get; set;}
        public int NumWheels{get; set;}
        public bool IsCovered{get; set;}
        public List<Passenger> Passengers{get; set;}

        //public Wagon(string name, int numWheels, bool isCovered)
        //{
        //    Name = name;
        //    NumWheels = numWheels;
        //    IsCovered = isCovered;
        //    Passengers = new List<Passenger>();
        //}
    }
}
