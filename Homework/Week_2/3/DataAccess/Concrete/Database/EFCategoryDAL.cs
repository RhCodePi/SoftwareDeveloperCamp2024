using DataAccess.Abstract;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Database
{
    public class EFCategoryDAL : ICategoryDAL
    {
        private CoursedbContext _dbContext;

        public EFCategoryDAL(CoursedbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetByCategoryName(string categoryName)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.Categories == categoryName);
        }

        public Category GetByCategoryId(int id)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.IdCategory == id);
        }
    }
}
