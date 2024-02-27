using Business.Abstract;
using Business.Dtos.Mapper;
using Business.Dtos.Requests.CategoryRequests;
using Business.Dtos.Responses.CategoryResponses;
using DataAccess.Abstract;
using Entities.Concrete.Models;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            var categories = _categoryDAL.GetAll();

            if(categories.Count <= 0)
            {
                throw new Exception("Categories are empty, please add new category");
            }

            var response = categories.Select(c => CategoryMapper.GetAllFromCourse(c)).ToList();

            return response;
        }

        public CreatedCategoryResponse GetByCategoryName(string name)
        {
            var category = _categoryDAL.GetByCategoryName(name);


            if(category == null) {
                throw new Exception("Category not found");
            }

            var response = CategoryMapper.GetResponseFromCategory(category);

            return response;
        }
        public CreatedCategoryResponse AddCategory(CreateCategoryRequest createCategoryRequest)
        {
            if (createCategoryRequest == null)
                throw new Exception("Invalid Category Entering");

            var category = CategoryMapper.GetCategoryFromRequest(createCategoryRequest);


            var response = CategoryMapper.GetResponseFromCategory(category);

            _categoryDAL.AddCategory(category);

            return response;
        }

        public CreatedCategoryResponse GetByCategoryId(int id)
        {
            var category = _categoryDAL.GetByCategoryId(id);

            if (category == null)
                throw new Exception("Category not found");


            var response = CategoryMapper.GetResponseFromCategory(category);


            return response;
        }

        public Category AddCourseToCategory(int categoryId, Course course)
        {
            var result = _categoryDAL.GetByCategoryId(categoryId);

            result.Courses.Add(course);

            return result;
        }

    }
}
