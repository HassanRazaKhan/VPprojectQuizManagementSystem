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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignUplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s = new SignUp();
            this.Hide();
            s.Show();
        }
       
        
        private void SignInbutton_Click(object sender, EventArgs e)
        {

          if(UsernametextBox.Text != null && PasswardtextBox.Text != null)
            {
                try
                {
                    Connection obj = new Connection();
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT (*) FROM SignUpTable where Username ='" + UsernametextBox.Text + "' and Passward ='" + PasswardtextBox.Text + "'", obj.con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if(dt.Rows[0][0].ToString()=="1")
                    {
                        TeacherMainMenu tmm = new TeacherMainMenu();
                        this.Hide();
                        tmm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Passward is incorrect");
                    }
                    obj.con.Close();
                    MessageBox.Show("Successfully Login");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          else
            {
                MessageBox.Show("No empty fields are allowed");

            }
            
        }
    }
}
