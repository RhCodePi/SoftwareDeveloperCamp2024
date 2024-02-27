using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        CreatedCategoryResponse AddCategory(CreateCategoryRequest categoryRequest);
        List<GetAllCategoryResponse> GetAll();
        CreatedCategoryResponse GetByCategoryName(string name);
        CreatedCategoryResponse GetByCategoryId(int id);
    }
}
