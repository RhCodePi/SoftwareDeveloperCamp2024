using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
