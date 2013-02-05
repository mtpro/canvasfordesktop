using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Course
    {
        private string name;
        private string id;

        // Create a Course with the given Name and ID
        public Course(string n, string i)
        {
            name = n;
            id = i;
        }

        public string toString()
        {
            return String.Format("{0}: {1}", name, id);
        }

        public string Name()
        {
            return name;
        }

        public string Id()
        {
            return id;
        }
    }
}
