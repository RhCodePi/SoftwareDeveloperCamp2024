using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // The pharmacy does not need the modern control system, provides masks for those who want them.
    public class PharmacyManager<T> : BaseCustomManager
        where T : LocalControlManager, new()
    {
        private T instance;

        public T Instance { 
            get {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            } 
        }

        public override void GiveMask(Person person)
        {
            if(Instance.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " applied for a mask and was accepted. ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " a person does not exist. ");
            }
        }
    }
}
