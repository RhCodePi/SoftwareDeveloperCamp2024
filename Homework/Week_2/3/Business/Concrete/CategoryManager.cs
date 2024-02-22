using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Mapper;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetByCategoryName(string name)
        {

            return _categoryDAL.GetByCategoryName(name);
        }
        public Category AddCategory(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
                throw new Exception("Invalid Category Entering");

            var result = CategoryMapper.GetCategory(categoryDTO);

            _categoryDAL.AddCategory(result);

            return result;
        }

        public Category GetByCategoryId(int id)
        {
            var result = _categoryDAL.GetByCategoryId(id);

            if (result == null)
                throw new Exception("Category not found");

            return result;
        }

        public Category AddCourseToCategory(int categoryId, Course course)
        {
            var result = _categoryDAL.GetByCategoryId(categoryId);

            result.Courses.Add(course);

            return result;
        }

    }
}
