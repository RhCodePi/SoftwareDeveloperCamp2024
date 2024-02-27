using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Mapper
{
    public static class CategoryMapper
    {
        public static CreatedCategoryResponse GetResponseFromRequest(CreateCategoryRequest createCategoryRequest)
        {
            return new CreatedCategoryResponse()
            {
                Categories = createCategoryRequest.Categories,
            };
        }

        public static CreateCategoryRequest GetRequestFromResponse(CreatedCategoryResponse createdCategoryResponse )
        {
            return new CreateCategoryRequest()
            {
                Categories = createdCategoryResponse.Categories,
            };
        }

        public static Category GetCategoryFromRequest(CreateCategoryRequest createdCategoryRequest)
        {
            return new Category()
            {
                Categories = createdCategoryRequest.Categories,
            };
        }

        public static CreateCategoryRequest GetRequestFromCategory(Category category)
        {
            return new CreateCategoryRequest()
            {
                Categories = category.Categories,
            };
        }

        public static GetAllCategoryResponse GetAllFromCourse(Category category)
        {
            return new GetAllCategoryResponse()
            {
                IdCategory = category.IdCategory,
                Categories = category.Categories,
            };
        }

        public static CreatedCategoryResponse GetResponseFromCategory(Category category)
        {
            return new CreatedCategoryResponse
            {
                IdCategory = category.IdCategory,
                Categories = category.Categories
            };
        }

        public static Category GetCategoryFromResponse(CreatedCategoryResponse createdCategoryResponse)
        {
            return new Category
            {
                IdCategory = createdCategoryResponse.IdCategory,
                Categories = createdCategoryResponse.Categories,
            };
        }


    }
}
