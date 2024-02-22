using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Mapper
{
    public class CategoryMapper
    {
        public static Category GetCategory(CategoryDTO categoryDTO)
        {
            return new Category
            {
                Categories = categoryDTO.Categories,
            };
        }
    }
}
