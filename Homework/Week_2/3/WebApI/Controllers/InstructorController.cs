using Business.Abstract;
using Entities.Concrete.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController
    {
        private IInstructorManager _instructorManager;

        public InstructorController(IInstructorManager instructorManager)
        {
            _instructorManager = instructorManager;
        }

        [HttpGet("/instructor/name/")]
        public IActionResult GetInstructorByName(string name)
        {
            try
            {
                var result = _instructorManager.GetInstructorByName(name);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex);
                throw;
            }
        }

        [HttpGet("/instructor/id")]
        public IActionResult GetInstructorById(int id)
        {
            try
            {
                var result = _instructorManager.GetInstructorById(id);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpPost("/instructor/add/")]
        public IActionResult AddInstructor(InstructorDTO instructorDto)
        {
            try
            {
                var result = _instructorManager.AddInstructor(instructorDto);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpDelete("/instructor/delete/")]
        public IActionResult DeleteInstructor(int id)
        {
            try
            {
                var result = _instructorManager.DeleteInstructor(id);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
                throw;
            }
        }

        [HttpGet("/instructor/getall")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _instructorManager.GetAll();

                return new OkObjectResult(result);
            }catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

    }
}
