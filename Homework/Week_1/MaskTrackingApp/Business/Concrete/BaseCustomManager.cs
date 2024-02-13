using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public abstract class BaseCustomManager : ISupplierService
    {
        /*private IApplicantService _applicantService;

        public BaseCustomManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }*/

        public virtual void GiveMask(Person person)
        {/*
            if(_applicantService.CheckPerson(person))
                Console.WriteLine(person.FirstName + " " + person.LastName + " applied for a mask and was accepted. ");
            else
                Console.WriteLine(person.FirstName + " " + person.LastName + " a person does not exist. ");*/
        }
    }
}
