using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Canvas
{
    public partial class MainWindow : Form
    {
        private string AccessToken;
        private const string AccessTokenFilename = "AccessToken";
        Course[] courses;
        Module[] modules;
        Assignment[] assignments;
        User[] classmates;
        User[] instructors;
        User loggedInUser;
        Course activeCourse;
        Module activeModule;
        Assignment activeAssignment;
        CanvasConnector client;
        int currentStudentPage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            AccessToken = TokenFileExists() ? ReadTokenFile() : GetAccessTokenAndWrite();
            client = new CanvasConnector(AccessToken);

            // Try to grab the courses
            try
            {
                courses = client.ListCourses();
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                // Probably tried to parse a non-json object
                // ...which means Canvas changed API or AccessToken was wrong
                MessageBox.Show("Canvas did not accept your access token. You will need to reenter it.",
                                "Invalid Access Token");
                File.Delete(AccessTokenFilename);

                this.Close();
            }

            foreach (Course c in courses)
            {
                CoursesListBox.Items.Add(c.toString());
            }

            loggedInUser = client.GetUser();

            this.Text = String.Format("Logged in as {0}", loggedInUser.Name());
        }

        private string GetAccessTokenAndWrite()
        {
            AccessTokenEntryWindow entry = new AccessTokenEntryWindow();
            entry.ShowDialog();
            File.WriteAllLines(AccessTokenFilename, new string[] {
                                entry.SecretKey });
            return entry.SecretKey;
        }

        private Boolean TokenFileExists()
        {
            return File.Exists(AccessTokenFilename);
        }

        private String ReadTokenFile()
        {
            using (StreamReader sr = File.OpenText(AccessTokenFilename))
            {
                return sr.ReadLine();
            }
        }

        private void CoursesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideEverything();
            activeCourse = courses[CoursesListBox.SelectedIndex];
            UpdateCourseInfo(sender, e);
        }

        private void UpdateCourseInfo(Object sender, EventArgs e)
        {
            GetCourseInfo();

            // send em all, then await em all.
            // Update ActiveCourseLabel and Show it
            CourseInfoGroupBox.Show();
            ActiveCourseLabel.Text = activeCourse.Name();
            ActiveCourseLabel.Show();
            
            // Update Instructors label and Show it
            string InstructorsStr= "Instructors: ";
            instructors = client.GetInstructors(activeCourse.Id());
            foreach (User instr in instructors)
            {
                InstructorsStr += instr.Name();
            }
            InstructorLabel.Text = InstructorsStr;
            InstructorLabel.Show();

            // Update Module Contents and Show it
            ModuleComboBox.Items.Clear();
            modules = client.GetModules(activeCourse.Id());
            foreach (Module mod in modules)
            {
                ModuleComboBox.Items.Add(mod.Name());
            }
            SelectModuleLabel.Show();
            ModuleComboBox.Show();

            // TODO: Update Module Items for the activeModule
            // // //
            // // //
            // // //

            // Update Assignments information
            assignments = client.GetAssignments(activeCourse.Id());
            foreach (Assignment ass in assignments)
            {
                AssignmentListBox.Items.Add(ass.Name());
            }
            AssignmentGroupBox.Show();
            AssignmentListBox.Show();
            STATIC_AssignmentCourseLabel.Show();
            STATIC_AssignmentDueLabel.Show();
            STATIC_AssignmentGradingLabel.Show();
            STATIC_AssignmentIDLabel.Show();

            // Update Classmates
            currentStudentPage = 1;
            for (int i = 1; i <= 7; ++i)
            {
                ClassmatesPageComboBox.Items.Add("Page " + i);
            }

            classmates = client.GetStudents(activeCourse.Id(), 0);
            foreach (User classmate in classmates)
            {
                ClassmatesListBox.Items.Add(classmate.Sortable_Name());
            }
            ClassmatesLabel.Show();
            ClassmatesListBox.Show();
            ClassmatesPageComboBox.Show();
        }

        private void HideEverything()
        {
            ActiveCourseLabel.Hide();
            InstructorLabel.Hide();
            SelectModuleLabel.Hide();
            ModuleComboBox.Items.Clear();
            ModuleComboBox.Hide();
            AssignmentIDLabel.Hide();
            AssignmentCourseLabel.Hide();
            AssignmentDueLabel.Hide();
            AssignmentGradingLabel.Hide();
            AssignmentListBox.Items.Clear();
            AssignmentListBox.Hide();
            ClassmatesListBox.Items.Clear();
            ClassmatesListBox.Hide();
            ActiveClassmateLabel.Hide();
            ClassmatesPageComboBox.Hide();
        }

        private void AssignmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeAssignment = assignments[AssignmentListBox.SelectedIndex];

            AssignmentIDLabel.Text = activeAssignment.Id();
            AssignmentIDLabel.Update();
            AssignmentIDLabel.Show();

            AssignmentCourseLabel.Text = activeAssignment.Course_Id();
            AssignmentCourseLabel.Show();

            AssignmentDueLabel.Text = activeAssignment.Due_At();
            AssignmentDueLabel.Show();

            AssignmentGradingLabel.Text = activeAssignment.Grading_Type();
            AssignmentGradingLabel.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ClassmatesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            User classmate = classmates[ClassmatesListBox.SelectedIndex];
            ActiveClassmateLabel.Text = String.Format("User {0}: ID {1}",
                                                classmate.Name(),
                                                classmate.Id());
            ActiveClassmateLabel.Show();
        }

        private void ClassmatesPageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStudentPage = 1 + ClassmatesPageComboBox.SelectedIndex;
            classmates = client.GetStudents(activeCourse.Id(), currentStudentPage);
            ClassmatesListBox.Items.Clear();
            foreach (User classmate in classmates)
            {
                ClassmatesListBox.Items.Add(classmate.Sortable_Name());
            }
        }

        private void GetCourseInfo()
        {
            
            
            

            
            
            
            
        }

    }
}
