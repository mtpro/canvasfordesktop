using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Module
    {
        private string id;
        private string position;
        private string name;

        // Create a Module with the given ID, Position, and Name
        public Module(string i, string p, string n)
        {
            id = i;
            position = p;
            name = n;
        }

        public string Id()
        {
            return id;
        }

        public string Position()
        {
            return position;
        }

        public string Name()
        {
            return name;
        }

    }
}
