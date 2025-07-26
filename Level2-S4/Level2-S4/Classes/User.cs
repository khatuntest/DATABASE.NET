using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2_S4.Classes
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public static string GetUsernameById(int id, List<User> users)
        {
            if(users == null || users.Count == 0)
            {
                throw new UserNotFoundException($"User with ID {id} Not Found");
            }
            for (int i=0; i<users.Count; i++)
            {
                if(users[i].ID == id && users[i].Name is not  null)
                {
                    return users[i].Name;
                }
            }
            throw new UserNotFoundException($"User with ID {id} Not Found");
        }
        public class UserNotFoundException : Exception
        {
            public UserNotFoundException (string message) : base(message) { }
        }
    }
}
