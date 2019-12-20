using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem
{
    public partial class TeacherEditRecords : Form
    {
        public TeacherEditRecords()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            TeacherMainMenu tmm = new TeacherMainMenu();
            this.Hide();
            tmm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherEditRecords_Load(object sender, EventArgs e)
        {

        }

        private void Conformbutton_Click(object sender, EventArgs e)
        {
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (EnterOldUsernametextBox.Text.Length > 0)
            {
                cmd.CommandText = "UPDATE Teachers SET Username ='" + TeacherEditUsernametextBox.Text + "',Passward ='" + TeacherEditPasswardtextBox.Text + "',Email ='" + TeacherEditEmailtextBox.Text + "',Department ='" + TeacherEditDepartmenttextBox.Text + "', CourseName ='" + TeacherEditCoursetextBox.Text + "'WHERE Username='" + EnterOldUsernametextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Successfully Updated!");
                TeacherEditUsernametextBox.Text = "";
                TeacherEditEmailtextBox.Text = "";
                TeacherEditPasswardtextBox.Text = "";
                TeacherEditDepartmenttextBox.Text = "";
            }
            else
                MessageBox.Show("Not Updated!");


            TeacherMainMenu mainMenu = new TeacherMainMenu();
            this.Hide();
            mainMenu.Show();
            obj.con.Close();
        }
    }
}
