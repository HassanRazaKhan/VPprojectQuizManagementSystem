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
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            TeacherMainMenu tmm = new TeacherMainMenu();
            this.Hide();
            tmm.Show();
        }
    }
}
