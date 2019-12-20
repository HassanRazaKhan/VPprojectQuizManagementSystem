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

namespace QuizManagementSystem
{
    public partial class StudentViewCourses : Form
    {
        public StudentViewCourses()
        {
            InitializeComponent();
            viewStudentsCoursetsdataGridView.BackgroundColor = Color.MediumPurple;
            viewStudentsCoursetsdataGridView.ForeColor = Color.Black;
            viewStudentsCoursetsdataGridView.BorderStyle = BorderStyle.Fixed3D;
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select  Username,Department, CourseName from Teachers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewStudentsCoursetsdataGridView.DataSource = dt;
            obj.con.Close();


        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StudentMainMenu smm = new StudentMainMenu();
            this.Hide();
            smm.Show();
        }

        private void SearchTeacherCourseButton_Click(object sender, EventArgs e)
        {
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Username,Department, CourseName from Teachers where CourseName ='" + SearchStudentsCoursetextBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewStudentsCoursetsdataGridView.DataSource = dt;
            obj.con.Close();
        }
    }
}
