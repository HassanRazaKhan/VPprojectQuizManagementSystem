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

      

        private void CreateQuizpictureBox_Click(object sender, EventArgs e)
        {
            CreateQuizForm cqf = new CreateQuizForm();
            this.Hide();
            cqf.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            CreateQuizForm cqf = new CreateQuizForm();
            this.Hide();
            cqf.Show();
        }

        private void ViewStudentspictureBox_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vs = new ViewStudentsForm();
            this.Hide();
            vs.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vs = new ViewStudentsForm();
            this.Hide();
            vs.Show();
        }

        private void ViewCoursespictureBox_Click(object sender, EventArgs e)
        {
            TeacherViewCourses tvc = new TeacherViewCourses();
            this.Hide();
            tvc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TeacherViewCourses tvc = new TeacherViewCourses();
            this.Hide();
            tvc.Show();
        }

        private void ViewResultspictureBox_Click(object sender, EventArgs e)
        {
            TeacherViewResults tvr = new TeacherViewResults();
            this.Hide();
            tvr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            TeacherViewResults tvr = new TeacherViewResults();
            this.Hide();
            tvr.Show();
        }

        private void TeacherEditRecordspictureBox_Click(object sender, EventArgs e)
        {
            TeacherEditRecords ter = new TeacherEditRecords();
            this.Hide();
            ter.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TeacherEditRecords ter = new TeacherEditRecords();
            this.Hide();
            ter.Show();
        }

        private void TeacherSignOutpictureBox_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

       
    }
}
