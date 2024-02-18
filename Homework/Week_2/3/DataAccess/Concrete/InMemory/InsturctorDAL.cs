using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InsturctorDAL : IInstructorDAL
    {
        List<Instructor> _instructors = new List<Instructor>();

        public InsturctorDAL()
        {
            Instructor instructor1 = new Instructor()
            {
                Id = 1,
                Name = "Engin Demirog",
            };

            Instructor instructor2 = new Instructor()
            {
                Id= 2,
                Name = "Halit Enes Kalayci",
            };

            _instructors.AddRange(new List<Instructor>() { instructor1, instructor2 });
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructors.FirstOrDefault(i => i.Id == id);
        }

        public Instructor GetInstructorByName(string name)
        {
            return _instructors.FirstOrDefault(i => i.Name == name);
        }
    }
}
