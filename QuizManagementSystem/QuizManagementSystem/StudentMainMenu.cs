using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem
{
    public partial class StudentMainMenu : Form
    {
        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void StudentSignOutbutton_Click(object sender, EventArgs e)
        {

            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void StudentEditRecordbutton_Click(object sender, EventArgs e)
        {
            StudentEditRecordForm ser = new StudentEditRecordForm();
            this.Hide();
            ser.Show();
        }

        private void StudentViewResultsbutton_Click(object sender, EventArgs e)
        {
            StudentViewResults svr = new StudentViewResults();
            this.Hide();
            svr.Show();
        }

        private void StudentViewCoursesbutton_Click(object sender, EventArgs e)
        {
            StudentViewCourses svc = new StudentViewCourses();
            this.Hide();
            svc.Show();
        }

        private void ViewTeachersbutton_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            this.Hide();
            vtf.Show();
        }

        private void StartQuizbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
