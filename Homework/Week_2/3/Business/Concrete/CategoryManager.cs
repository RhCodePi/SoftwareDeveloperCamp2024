using Business.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private CategoryDAL _categoryDAL;

        public CategoryManager(CategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetByCategoryName(Categories name)
        {
            return _categoryDAL.GetByCategoryName(name);
        }
    }
}
