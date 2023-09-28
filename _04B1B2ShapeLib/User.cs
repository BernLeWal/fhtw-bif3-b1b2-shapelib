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

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name;  }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Password
        {
            get { return _password; }
        }

        // and add a header, too.
        // add a better documentation of User/EventHandler
        // added a second line of better documentation
        public void EventHandler(object? sender, EventArgs e)
        {
            Console.WriteLine($"User {Name} was informed by {sender} of {e}");
        }
    }
}
