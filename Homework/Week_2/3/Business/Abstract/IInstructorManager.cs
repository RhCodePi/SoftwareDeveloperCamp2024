using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.InstructorResponses;

namespace Business.Abstract
{
    public interface IInstructorManager
    {
        CreatedInstructorResponse DeleteInstructor(int id);
        CreatedInstructorResponse AddInstructor(CreateInstructorRequest createInstructorRequest);
        List<GetAllInstructorResponse> GetAll();
        CreatedInstructorResponse GetInstructorById(int id);
        CreatedInstructorResponse GetInstructorByName(string name);
    }
}
