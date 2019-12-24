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
            if (StudentLoginradioButton.Checked)
            {
                if (UsernametextBox.Text != null && PasswardtextBox.Text != null)
                {
                    try
                    {
                        Connection obj = new Connection();
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT (*) FROM Students where Username ='" + UsernametextBox.Text + "' and Passward ='" + PasswardtextBox.Text + "'", obj.con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            StudentMainMenu smm = new StudentMainMenu();
                            this.Hide();
                            smm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username or Passward is incorrect");
                        }
                        obj.con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
          if(TeacherLoginradioButton.Checked)
            {
                if (UsernametextBox.Text != null && PasswardtextBox.Text != null)
                {
                    try
                    {
                        Connection obj = new Connection();
                        obj.con.ConnectionString = obj.locate;
                        obj.con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT (*) FROM Teachers where Username ='" + UsernametextBox.Text + "' and Passward ='" + PasswardtextBox.Text + "'", obj.con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
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

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
            
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsernametextBox_Enter(object sender, EventArgs e)
        {
            if(UsernametextBox.Text=="Username")
            {
                UsernametextBox.Text = "";
                UsernametextBox.ForeColor = Color.Black;
            }

        }

        private void UsernametextBox_Leave(object sender, EventArgs e)
        {
            if (UsernametextBox.Text == "")
            {
                UsernametextBox.Text = "Username";
                UsernametextBox.ForeColor = Color.Gray;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Loginpanel.Visible = true;
            Loginpanel.BackColor = Color.FromArgb(100, 100, 100, 100);
        }

        private void Loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
