using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Canvas
{
    class CanvasConnector
    {
        private string AccessToken;
        HttpClient client;
        Uri WebcoursesUri = new Uri("https://webcourses2c.instructure.com");

        public CanvasConnector(string token)
        {
            AccessToken = token;
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Use the Bearer authentication method, with AccessToken as its param
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            // Set base addr for future requests
            client.BaseAddress = WebcoursesUri;
        }

        // List the courses available to this account
        public Course[] ListCourses()
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get,
                Properties.Resources.API_LIST_COURSES);
            HttpResponseMessage resp = client.SendAsync(req).Result;
            JArray courses = JArray.Parse(resp.Content.ReadAsStringAsync().Result);
            Course[] courses_array = new Course[courses.Count];
            for (int i = 0; i < courses.Count; ++i)
            {
                Course c = new Course((string)courses[i]["name"],
                                      (string)courses[i]["id"]);
                courses_array[i] = c;
            }

            return courses_array;
        }

        // List the users associated with this account
        public User GetUser()
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get,
                Properties.Resources.API_GET_USER_PROFILE);
            HttpResponseMessage resp = client.SendAsync(req).Result;
            JObject user = JObject.Parse(resp.Content.ReadAsStringAsync().Result);

            return new User((string)user["id"], 
                            (string)user["name"]);
        }

        public User[] GetInstructors(string course_id)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get,
                String.Format(Properties.Resources.API_LIST_USERS_TEACHER, course_id));
            HttpResponseMessage resp = client.SendAsync(req).Result;
            JArray instrs = JArray.Parse(resp.Content.ReadAsStringAsync().Result);

            User[] instructors = new User[instrs.Count];
            for (int i = 0; i < instrs.Count; ++i)
            {
                instructors[i] = new User((string)instrs[i]["id"], 
                                          (string)instrs[i]["name"]);
            }
            return instructors;
        }

        // Get the modules available for this course
        public Module[] GetModules(string course_id)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get,
                String.Format(Properties.Resources.API_LIST_MODULES, course_id));
            HttpResponseMessage resp = client.SendAsync(req).Result;
            JArray mods = JArray.Parse(resp.Content.ReadAsStringAsync().Result);

            Module[] modules = new Module[mods.Count];
            for (int i = 0; i < mods.Count; ++i)
            {
                modules[i] = new Module((string)mods[i]["id"],
                                        (string)mods[i]["position"],
                                        (string)mods[i]["name"]);
            }

            return modules;
        }

        // Get the assignments available for this course
        public Assignment[] GetAssignments(string course_id)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get,
                String.Format(Properties.Resources.API_LIST_ASSIGNMENTS, course_id));
            HttpResponseMessage resp = client.SendAsync(req).Result;
            JArray ass = JArray.Parse(resp.Content.ReadAsStringAsync().Result);

            Assignment[] assignments = new Assignment[ass.Count];
            for (int i = 0; i < ass.Count; ++i)
            {
                assignments[i] = new Assignment((string)ass[i]["id"],
                                        (string)ass[i]["name"],
                                        (string)ass[i]["description"],
                                        (string)ass[i]["due_at"],
                                        (string)ass[i]["course_id"],
                                        (string)ass[i]["grading_type"]);
            }

            return assignments;
        }

        // Get the students in a course
        public User[] GetStudents(string course_id, int current_page)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get,
                String.Format(Properties.Resources.API_LIST_USERS_STUDENT, 
                                        course_id));
            HttpResponseMessage resp = client.SendAsync(req).Result;
            JArray users = JArray.Parse(resp.Content.ReadAsStringAsync().Result);

            User[] students = new User[users.Count];
            for (int i = 0; i < users.Count; ++i)
            {
                students[i] = new User((string)users[i]["id"],
                                        (string)users[i]["name"],
                                        (string)users[i]["sortable_name"]);
            }

            return students;
        }
    }
}
