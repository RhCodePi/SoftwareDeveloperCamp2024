using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;
using System.Runtime.InteropServices;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }
        public List<Person> GetPeople()
        {
            return null;
        }
    }
}
