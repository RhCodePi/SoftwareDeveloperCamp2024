using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDAL
    {
        Category AddCategory(Category category);
        List<Category> GetAll();
        Category GetByCategoryName(string categoryName);
        Category GetByCategoryId(int id);
    }
}
