using DataAccess.Abstract;
using Entities.Concrete.Models;
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
                IdCategory = 1,
                Categories = Categories.CyberSecurity.ToString(),              
            };

            Category category2 = new Category()
            {
                IdCategory = 2,
                Categories = Categories.Programming.ToString(),
            };

            _categories.AddRange(new List<Category> { category1, category2});
        }

        public Category AddCategory(Category category)
        {
            _categories.Add(category);

            return category;
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetByCategoryName(string categoryName)
        {
            return _categories.FirstOrDefault(c=> c.Categories == categoryName);
        }

        public Category GetByCategoryId(int id)
        {
            return _categories.FirstOrDefault(c => c.IdCategory == id);
        }
    }
}
