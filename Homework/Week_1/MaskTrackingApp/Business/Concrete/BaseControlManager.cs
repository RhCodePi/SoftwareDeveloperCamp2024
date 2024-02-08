using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public abstract class BaseControlManager : IPersonControlService
    {
        public virtual bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
