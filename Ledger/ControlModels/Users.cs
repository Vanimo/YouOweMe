using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ledger.ControlModels
{
    internal class Users
    {
        Dictionary<Guid, User> _users = new Dictionary<Guid, User>();

        public Users()
        {

        }

        public User AddUser(string fullName)
        {
            var user = new User(fullName);
            _users.Add(user.Guid, user);

            return user;
        }

        public User GetUser(Guid guid)
        {
            return _users[guid];
        }
    }
}
