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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        public void progBar()
        {
            StartScreenprogressBar.Increment(1);
            Loadinglabel.Text = "Loading " + StartScreenprogressBar.Value.ToString() + "%";
            if (StartScreenprogressBar.Value == StartScreenprogressBar.Maximum)
            {
                StartScreeentimer.Stop();
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progBar();

        }
    }
}
