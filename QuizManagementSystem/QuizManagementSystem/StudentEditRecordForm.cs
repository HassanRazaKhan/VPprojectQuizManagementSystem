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
    public partial class StudentEditRecordForm : Form
    {
        public StudentEditRecordForm()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StudentMainMenu smm = new StudentMainMenu();
            this.Hide();
            smm.Show();
        }

        private void Conformbutton_Click(object sender, EventArgs e)
        {
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;
            obj.con.Open();
            SqlCommand cmd = obj.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (EnterOldUsernamStudentetextBox.Text.Length > 0)
            {
                cmd.CommandText = "UPDATE Students SET Username ='" + StudentsEditUsernametextBox.Text + "',Passward ='" + StudentsEditPasswardtextBox.Text + "',Email ='" + StudentsEditEmailtextBox.Text + "',Department ='" + StudentsEditDepartmenttextBox.Text + "'WHERE Username='" +EnterOldUsernamStudentetextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("Successfully Updated!");
                StudentsEditUsernametextBox.Text = "";
                StudentsEditPasswardtextBox.Text = "";
                StudentsEditEmailtextBox.Text = "";
                StudentsEditDepartmenttextBox.Text = "";
            }
            else
                MessageBox.Show("Not Updated!");


            StudentMainMenu mainMenu = new StudentMainMenu();
            this.Hide();
            mainMenu.Show();
            obj.con.Close();
        }

        private void StudentsEditUsernametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Username should only be Alphabatic with no space!");
            }
        }

        private void StudentsEditPasswardtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Passward should only be Alphanumeric!");
            }
        }

        private void StudentsEditDepartmenttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("UDepartment name should only be Alphabatic!");
            }
        }

        private void StudentsEditDepartmenttextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
