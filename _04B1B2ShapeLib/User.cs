using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04B1B2ShapeLib
{
    public class User
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;

        public User(int id, string name, string email, string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
        }
    }
}
