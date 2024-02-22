using Business.Abstract;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController
    {
        private ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("/categories/name")]
        public IActionResult GetCategoryByName(string categoryName)
        {
            try
            {
                var result = _categoryManager.GetByCategoryName(categoryName);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {

                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpGet("/categories/getall")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _categoryManager.GetAll();

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpPost("/categories/add")]
        public IActionResult AddCategory(CategoryDTO categoryDTO)
        {
            try
            {
                var result = _categoryManager.AddCategory(categoryDTO);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }
    }
}
