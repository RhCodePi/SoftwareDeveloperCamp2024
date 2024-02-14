using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class UserManager : IUserManager
    {
        private IUserDAL userDAL;

        public UserManager(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }



        public User GetUser(string username)
        {
           return userDAL.GetUser(username);
        }

        public List<User> GetUsers()
        {
            return userDAL.GetUsers();
        }
    }
}
