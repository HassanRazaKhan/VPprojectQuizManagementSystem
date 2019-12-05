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
            
                TeacherMainMenu tmm = new TeacherMainMenu();
                this.Hide();
                tmm.Show();
            
        }
    }
}
