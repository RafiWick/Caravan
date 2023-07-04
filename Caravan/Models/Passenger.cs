using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name{get;set;}
        public int Age{get;set;}
        public string Destination{get;set;}
        public Wagon Wagon{get;set;}

        //public Passenger(string name, int age, string destination, Wagon wagon)
        //{
        //    Name = name;
        //    Age = age;
        //    Destination = destination;
        //    Wagon = wagon;
        //}
    }
}
