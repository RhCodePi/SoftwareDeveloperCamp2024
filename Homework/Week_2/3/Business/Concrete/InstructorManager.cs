using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Mapper;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorManager
    {
        private IInstructorDAL _instructorDAl;

        public InstructorManager(IInstructorDAL instructorDAl)
        {
            _instructorDAl = instructorDAl;
        }

        public Instructor AddInstructor(InstructorDTO instructorDto)
        {
            if (instructorDto == null)
                throw new Exception("Invalid instructor entring");

            var instructor = InsturctorMapper.GetInstructor(instructorDto);

            _instructorDAl.AddInstructor(instructor);

            return instructor;
        }

        public Instructor DeleteInstructor(int id)
        {
            var result = _instructorDAl.GetInstructorById(id);

            if(result == null)
            {
                Console.WriteLine("Invalid instructor");
                throw new Exception("Instructor not found.");
            }
            _instructorDAl.DeleteInstructor(result);

            return result;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDAl.GetAll();
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorDAl.GetInstructorById(id);
        }

        public Instructor GetInstructorByName(string name)
        {
            return _instructorDAl.GetInstructorByName(name);
        }
    }
}
