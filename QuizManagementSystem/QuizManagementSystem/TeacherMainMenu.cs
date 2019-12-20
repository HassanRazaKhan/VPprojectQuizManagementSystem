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
    public partial class TeacherMainMenu : Form
    {
        public TeacherMainMenu()
        {
            InitializeComponent();
        }

        private void CreateQuizbutton_Click(object sender, EventArgs e)
        {
            CreateQuizForm cqf = new CreateQuizForm();
            this.Hide();
            cqf.Show();
        }

        private void ViewStudentsbutton_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vs = new ViewStudentsForm();
            this.Hide();
            vs.Show();
        }

        private void TeacherViewCoursesbutton_Click(object sender, EventArgs e)
        {
            TeacherViewCourses tvc = new TeacherViewCourses();
            this.Hide();
            tvc.Show();

        }

        private void TeacherViewResultsbutton_Click(object sender, EventArgs e)
        {
            TeacherViewResults tvr = new TeacherViewResults();
            this.Hide();
            tvr.Show();
        }

        private void TeacherEditRecordbutton_Click(object sender, EventArgs e)
        {
            TeacherEditRecords ter = new TeacherEditRecords();
            this.Hide();
            ter.Show();
        }

        private void TeacherSignOutbutton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void TeacherMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
