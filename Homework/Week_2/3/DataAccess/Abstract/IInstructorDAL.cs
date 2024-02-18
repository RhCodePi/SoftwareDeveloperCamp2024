using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDAL
    {
        Instructor GetInstructorByName(string name);
        Instructor GetInstructorById(int id);
        List<Instructor> GetAll();
    }
}
