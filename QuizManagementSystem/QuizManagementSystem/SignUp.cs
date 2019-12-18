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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            if(StudentSignupradioButton.Checked)
            {
                if(SignupUsernametextBox.Text != null && SignupPasswardtextBox.Text != null && SignupEmailtextBox.Text != null && SignupDepartmenttextBox.Text != null)
            {
                    try
                    {
                        Connection obj = new Connection();
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        string insertUser = "insert into Students values ('" + SignupUsernametextBox.Text + "','" + SignupPasswardtextBox.Text + "','" + SignupEmailtextBox.Text + "','" + SignupDepartmenttextBox.Text + "')";
                        obj.cmd.Connection = obj.con;
                        obj.cmd.CommandText = insertUser;
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        MessageBox.Show("SignUp has been completed Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            else
                {
                    MessageBox.Show("Error!");
                }
                LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();
            }
            if(TeacherSignupradioButton.Checked)
            {
               
                if(SignupUsernametextBox.Text != null && SignupPasswardtextBox.Text != null && SignupEmailtextBox.Text != null && SignupDepartmenttextBox.Text != null)
            {
                    try
                    {
                        Connection obj = new Connection();
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        string insertUser = "insert into Teachers values ('" + SignupUsernametextBox.Text + "','" + SignupPasswardtextBox.Text + "','" + SignupEmailtextBox.Text + "','" + SignupDepartmenttextBox.Text + "')";
                        obj.cmd.Connection = obj.con;
                        obj.cmd.CommandText = insertUser;
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        MessageBox.Show("SignUp has been completed Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            else
                {
                    MessageBox.Show("Error!");
                }
                LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();
            }

        }

     
    }
}
