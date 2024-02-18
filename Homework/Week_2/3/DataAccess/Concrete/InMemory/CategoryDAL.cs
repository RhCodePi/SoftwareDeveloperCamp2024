using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDAL : ICategoryDAL
    {
        List<Category> _categories = new List<Category>();

        public CategoryDAL()
        {
            Category category1 = new Category()
            {
                Id = 1,
                categories = Categories.CyberSecurity,              
            };

            Category category2 = new Category()
            {
                Id = 2,
                categories = Categories.Programming,
            };

            _categories.AddRange(new List<Category> { category1, category2});
        }


        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetByCategoryName(Categories categoryName)
        {
            return _categories.FirstOrDefault(c=> c.categories == categoryName);
        }
    }
}
