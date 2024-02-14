using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Classes
{
    public class CityDAL
    {
        private List<City> cities = new List<City>();

        public CityDAL()
        { 
            // initial city 
            City city1 = new City
            {
                Id = 1,
                Name = "Istanbul",
                PlateCode = "34",
                Region = Region.Marmara,
            };

            City city2 = new City
            {
                Id = 2,
                Name = "Ankara",
                PlateCode = "06",
                Region = Region.CentralAnatolia,
            };

            City city3 = new City
            {
                Id = 3,
                Name = "Edirne",
                PlateCode = "22",
                Region = Region.Marmara,
            };

            City city4 = new City
            {
                Id = 4,
                Name = "Çanakkale",
                PlateCode = "18",
                Region = Region.Marmara,
            };

            City city5 = new City
            {
                Id = 5,
                Name = "Bursa",
                PlateCode = "16",
                Region = Region.Marmara,
            };

            cities.AddRange(new List<City>() { city1, city2, city3, city4, city5});
        }

        public City GetCity(string name)
        {
            return cities.FirstOrDefault(x => x.Name == name);
        }

        public List<City> GetCityList()
        {
            return cities;
        }
    } 
}
