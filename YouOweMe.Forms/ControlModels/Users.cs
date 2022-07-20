using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouOweMe.Forms.ControlModels
{
    internal class Users
    {
        Dictionary<Guid, User> _users = new Dictionary<Guid, User>();

        public Users()
        {

        }

        public void AddUser(string fullName)
        {
            var user = new User(fullName);
            _users.Add(user.Id, user);
        }

        public User GetUser(Guid guid)
        {
            return _users[guid];
        }
    }
}
