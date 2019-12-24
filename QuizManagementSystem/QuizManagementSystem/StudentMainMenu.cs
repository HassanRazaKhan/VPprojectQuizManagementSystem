using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuizManagementSystem
{
    public partial class StudentMainMenu : Form
    {
        public StudentMainMenu()
        {
            InitializeComponent();
        }

       
       

        private void label13_Click(object sender, EventArgs e)
        {
            StartQuizForm sqf = new StartQuizForm();
            this.Hide();
            sqf.Show();
        }

        private void ViewTeacherspictureBox_Click(object sender, EventArgs e)
        {

            ViewTeachersForm vtf = new ViewTeachersForm();
            this.Hide();
            vtf.Show();
        }

        private void StartQuizpictureBox_Click(object sender, EventArgs e)
        {
            StartQuizForm sqf = new StartQuizForm();
            this.Hide();
            sqf.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            ViewTeachersForm vtf = new ViewTeachersForm();
            this.Hide();
            vtf.Show();
        }

        private void StudentsViewCoursespictureBox_Click(object sender, EventArgs e)
        {
            StudentViewCourses svc = new StudentViewCourses();
            this.Hide();
            svc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StudentViewCourses svc = new StudentViewCourses();
            this.Hide();
            svc.Show();
        }

        private void StudentsViewResultspictureBox_Click(object sender, EventArgs e)
        {
            StudentViewResults svr = new StudentViewResults();
            this.Hide();
            svr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            StudentViewResults svr = new StudentViewResults();
            this.Hide();
            svr.Show();
        }

        private void StudentsEditRecordspictureBox_Click(object sender, EventArgs e)
        {
            StudentEditRecordForm ser = new StudentEditRecordForm();
            this.Hide();
            ser.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            StudentEditRecordForm ser = new StudentEditRecordForm();
            this.Hide();
            ser.Show();
        }

        private void StudentsSignOutpictureBox_Click(object sender, EventArgs e)
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

      
    

