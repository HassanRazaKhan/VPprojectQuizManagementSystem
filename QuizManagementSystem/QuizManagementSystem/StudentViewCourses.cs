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
    public partial class StudentViewCourses : Form
    {
        public StudentViewCourses()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StudentMainMenu smm = new StudentMainMenu();
            this.Hide();
            smm.Show();
        }
    }
}
