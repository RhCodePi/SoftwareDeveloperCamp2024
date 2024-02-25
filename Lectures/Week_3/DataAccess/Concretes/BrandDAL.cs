using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class BrandDAL : IBrandDAL
    {
        private List<Brand> _brands;

        public BrandDAL()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand {Id = 1, Name = "Mercedes", CreatedDate = DateTime.Now});
            _brands.Add(new Brand { Id = 2, Name = "Audi", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { Id = 3, Name = "BMW", CreatedDate = DateTime.Now });
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
}
