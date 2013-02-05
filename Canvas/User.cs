using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class User
    {
        private string id;
        private string name;
        private string sortable_name;
        private string login_id;
        private string email;
        private string last_login;

        // Create a User with the given ID and Name
        public User(string i, string n)
        {
            id = i;
            name = n;
        }

        // Create a User with the given ID, Name and Sortable Name
        public User(string i, string n, string s)
        {
            id = i;
            name = n;
            sortable_name = s;
        }

        public string toString()
        {
            return String.Format("{0}: {1}", name, id);
        }

        public string Name()
        {
            return name;
        }

        public string Sortable_Name()
        {
            return sortable_name;
        }

        public string Id()
        {
            return id;
        }
    }
}
