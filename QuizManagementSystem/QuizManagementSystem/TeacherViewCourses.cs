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
    public partial class TeacherViewCourses : Form
    {
        public TeacherViewCourses()
        {
            InitializeComponent();
            viewTeacherCoursetsdataGridView.BackgroundColor = Color.MediumPurple;
            viewTeacherCoursetsdataGridView.ForeColor = Color.Black;
            viewTeacherCoursetsdataGridView.BorderStyle = BorderStyle.Fixed3D;
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
            viewTeacherCoursetsdataGridView.DataSource = dt;
            obj.con.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            TeacherMainMenu tmm = new TeacherMainMenu();
            this.Hide();
            tmm.Show();
        }

       

        private void SearchTeachersCoursespictureBox_Click(object sender, EventArgs e)
        {
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Username,Department, CourseName from Teachers where CourseName ='" + SearchTeacherCoursetextBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewTeacherCoursetsdataGridView.DataSource = dt;
            obj.con.Close();
        }

      
    }
}
