using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Assignment
    {
        private string id;
        private string name;
        private string description;
        private string due_at;
        private string course_id;
        private string grading_type;

        public Assignment(string i, string n, string d, string d_a, string cid, string g_t)
        {
            id = i;
            name = n;
            description = d;
            due_at = d_a;
            course_id = cid;
            grading_type = g_t;
        }

        public string Id()
        {
            return id;
        }

        public string Name()
        {
            return name;
        }

        public string Due_At()
        {
            return due_at;
        }

        public string Course_Id()
        {
            return course_id;
        }

        public string Grading_Type()
        {
            return grading_type;
        }
    }
}
