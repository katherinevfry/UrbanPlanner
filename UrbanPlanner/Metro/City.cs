using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Metro
{
    class City
    {
        //private fields
        private string _mayor;
        private DateTime _dateFounded;

        //public properties
        public string Name { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();
  

        public City(string name)
        {
            Name = name;
        }

        public void FoundCity()
        {
            _dateFounded = DateTime.Today;
        }

        public void ElectMayor(string mayor)
        {
            _mayor = mayor;
        }


        public void AddBuilding(Building buildingName)
        {

            Buildings.Add(buildingName);
        }

        public void CityInfo()
        {
            Console.WriteLine($"City Name: {Name}");
            Console.WriteLine($"Mayor: {_mayor}");
            Console.WriteLine($"Date Founded: {_dateFounded}");
        }

  
    }
}
