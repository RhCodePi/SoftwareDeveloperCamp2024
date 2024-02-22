using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        Category AddCategory(CategoryDTO categoryDTO);
        List<Category> GetAll();
        Category GetByCategoryName(string name);
        Category GetByCategoryId(int id);
    }
}
