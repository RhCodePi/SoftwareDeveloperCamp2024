using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class UserDAL : IUserDAL
    {
        List<User> _users = new List<User>();

        public UserDAL()
        {
            // initial city 
            User user1 = new User
            {
                Id = 1,
                Name = "Ahmet",
                Email= "Ahmet@gmail.com",
                Password= "euhausd",
            };

            User user2 = new User
            {
                Id = 2,
                Name = "Derin",
                Email= "Derin@gmail.com",
                Password= "sdeajiuos",
            };

            User user3 = new User
            {
                Id = 3,
                Name = "Abdullah",
                Email = "Abdullah@gmail.com",
                Password = "rkjsfkluhjis",
            };

            _users.AddRange(new List<User>() {user1, user2, user3});

        }


        public User GetUser(string username)
        {
            return _users.FirstOrDefault(x => x.Name ==  username);
        }

        public List<User> GetUsers()
        {
            return _users;
        }
    }
}
