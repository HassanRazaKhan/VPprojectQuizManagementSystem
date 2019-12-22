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
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            viewStudentsdataGridView.BackgroundColor = Color.MediumPurple;
            viewStudentsdataGridView.ForeColor = Color.Black;
            viewStudentsdataGridView.BorderStyle = BorderStyle.Fixed3D;
              Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select  Username,Email,Department  from Students";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewStudentsdataGridView.DataSource = dt;
            obj.con.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            TeacherMainMenu tmm = new TeacherMainMenu();
            this.Hide();
            tmm.Show();
        }

      
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Username,Email,Department from Students where Username ='" + SearchStudenttextBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewStudentsdataGridView.DataSource = dt;
            obj.con.Close();
        }

        private void SearchStudenttextBox_Enter(object sender, EventArgs e)
        {
            if (SearchStudenttextBox.Text == "Search By Username")
            {
                SearchStudenttextBox.Text = "";
                SearchStudenttextBox.ForeColor = Color.Black;
            }
        }

        private void SearchStudenttextBox_Leave(object sender, EventArgs e)
        {
            if (SearchStudenttextBox.Text == "")
            {
                SearchStudenttextBox.Text = "Search By Username";
                SearchStudenttextBox.ForeColor = Color.Gray;
            }
        }
    }
}
