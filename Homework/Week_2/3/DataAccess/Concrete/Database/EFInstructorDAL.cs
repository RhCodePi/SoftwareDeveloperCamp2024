using DataAccess.Abstract;
using Entities.Concrete.Models;
using Entities.Concrete.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Database
{
    public class EFInstructorDAL : IInstructorDAL
    {
        private CoursedbContext _dbContext;

        public EFInstructorDAL(CoursedbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Instructor AddInstructor(Instructor instructor)
        {
            _dbContext.Instructors.Add(instructor);
            _dbContext.SaveChanges();
            return instructor;
        }

        public Instructor DeleteInstructor(Instructor instructor)
        {
            _dbContext.Instructors.Remove(instructor);
            _dbContext.SaveChanges();
            return instructor;
        }

        public List<Instructor> GetAll()
        {
            return _dbContext.Instructors.ToList();
        }

        public Instructor GetInstructorById(int id)
        {
            return _dbContext.Instructors.FirstOrDefault(i => i.IdInstructor == id);
        }

        public Instructor GetInstructorByName(string name)
        {
            return _dbContext.Instructors.FirstOrDefault(i => i.Name == name);
        }
    }
}
