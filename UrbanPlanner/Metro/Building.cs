using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Metro
{
    class Building
    {
        //private fields
        private string _designer = "Katherine Victoria Fry";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { 
            get 
            {
                return Width * Depth * (3 * Stories);
            } 
        }
        public string Name { get; set; }

        public Building(string address)
        {
            _address = address;
            Name = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
            Console.WriteLine(_address);
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

        public void buildingInfo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(_owner);
            Console.WriteLine(_address);
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}
