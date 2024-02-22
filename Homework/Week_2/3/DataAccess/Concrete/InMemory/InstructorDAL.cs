using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InstructorDAL : IInstructorDAL
    {
        List<Instructor> _instructors = new List<Instructor>();

        public InstructorDAL()
        {
            Instructor instructor1 = new Instructor()
            {
                IdInstructor = 1,
                Name = "Engin Demirog",
            };

            Instructor instructor2 = new Instructor()
            {
                IdInstructor= 2,
                Name = "Halit Enes Kalayci",
            };

            _instructors.AddRange(new List<Instructor>() { instructor1, instructor2 });
        }
        public Instructor AddInstructor(Instructor instructor)
        {
            _instructors.Add(instructor);

            return instructor;
        }

        public Instructor DeleteInstructor(Instructor instructor)
        {
            _instructors.Remove(instructor);
            return instructor;
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructors.FirstOrDefault(i => i.IdInstructor == id);
        }

        public Instructor GetInstructorByName(string name)
        {
            return _instructors.FirstOrDefault(i => i.Name == name);
        }

        
    }
}
