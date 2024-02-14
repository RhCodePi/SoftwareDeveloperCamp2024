using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    /* Manager class using like that absoulute wrong,
     * cause getting data using with class,
     * this way using fact that dependicy  
    */
    public class CityManager
    {
        private CityDAL cityDAL;
        public CityManager(CityDAL cityDAL)
        {
            this.cityDAL = cityDAL; 
        }

        public City GetCity(string name)
        {
            return cityDAL.GetCity(name);
        }

        public List<City> GetAll()
        {
            return cityDAL.GetCityList();
        }

    }
}
