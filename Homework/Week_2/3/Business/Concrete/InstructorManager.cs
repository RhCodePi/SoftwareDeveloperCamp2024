using Business.Abstract;
using Business.Dtos.Mapper;
using Business.Dtos.Requests.InstructorRequests;
using Business.Dtos.Responses.InstructorResponses;
using DataAccess.Abstract;


namespace Business.Concrete
{
    public class InstructorManager : IInstructorManager
    {
        private IInstructorDAL _instructorDAl;

        public InstructorManager(IInstructorDAL instructorDAl)
        {
            _instructorDAl = instructorDAl;
        }

        public CreatedInstructorResponse AddInstructor(CreateInstructorRequest createInstructorRequest)
        {
            if (createInstructorRequest == null)
                throw new Exception("Invalid instructor entring");

            var instructor = InstructorMapper.GetInstructorFromRequest(createInstructorRequest);

            _instructorDAl.AddInstructor(instructor);

            var response = InstructorMapper.GetResponseFromInstructor(instructor);

            return response;
        }

        public CreatedInstructorResponse DeleteInstructor(int id)
        {
            var instructor = _instructorDAl.GetInstructorById(id);

            if(instructor == null)
            {
                Console.WriteLine("Invalid instructor");
                throw new Exception("Instructor not found.");
            }

            _instructorDAl.DeleteInstructor(instructor);

            var response = InstructorMapper.GetResponseFromInstructor(instructor);

            return response;
        }

        public List<GetAllInstructorResponse> GetAll()
        {
            var instructors = _instructorDAl.GetAll();

            var response = instructors.Select(i => InstructorMapper.GetAllResponseFromInstructor(i)).ToList();

            return response;
        }

        public CreatedInstructorResponse GetInstructorById(int id)
        {
            var instructor = _instructorDAl.GetInstructorById(id);

            if(instructor == null)
            {
                throw new Exception("Instructor not exist");
            }

            var response = InstructorMapper.GetResponseFromInstructor(instructor);
            
            return response;
        }

        public CreatedInstructorResponse GetInstructorByName(string name)
        {
            var instructor = _instructorDAl.GetInstructorByName(name);

            if(instructor == null)
            {
                throw new Exception("Instructor not exist");
            }

            var response = InstructorMapper.GetResponseFromInstructor(instructor);

            return response;
        }
    }
}
