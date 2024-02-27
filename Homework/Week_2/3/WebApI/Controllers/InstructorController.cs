using Business.Abstract;
using Business.Dtos.Requests.InstructorRequests;
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

        [HttpGet("/instructor/get/name/")]
        public IActionResult GetInstructorByName(string name)
        {
            try
            {
                var result = _instructorManager.GetInstructorByName(name);

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
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
        public IActionResult AddInstructor(CreateInstructorRequest createInstructorRequest)
        {
            try
            {
                var result = _instructorManager.AddInstructor(createInstructorRequest);

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
