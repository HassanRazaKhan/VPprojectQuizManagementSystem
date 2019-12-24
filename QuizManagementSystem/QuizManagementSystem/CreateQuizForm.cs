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
    public partial class CreateQuizForm : Form
    {
        public CreateQuizForm()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            TeacherMainMenu tmm = new TeacherMainMenu();
            this.Hide();
            tmm.Show();
        }

        private void CreateQuiz1button_Click(object sender, EventArgs e)
        {
            if (QuizIDtextBox.Text != null && CourseNamecomboBox.Text.ToString() != null && AddQuestiontextBox.Text != null && OptionAtextBox.Text != null && OptionCtextBox.Text != null && OptionDtextBox.Text != null && CorrectAnswertextBox.Text != null)
            {
                try
                {
                    Connection obj = new Connection();
                    obj.con.ConnectionString = obj.locate;
                    obj.con.Open();
                    string insertUser = "insert into Questions values ('" + QuizIDtextBox.Text + "','" + CourseNamecomboBox.Text.ToString() + "','" + AddQuestiontextBox.Text + "','" + OptionAtextBox.Text + "','" + OptionBtextBox.Text + "','" + OptionCtextBox.Text + "','" + OptionDtextBox.Text + "','" + CorrectAnswertextBox.Text + "')";
                    obj.cmd.Connection = obj.con;
                    obj.cmd.CommandText = insertUser;
                    obj.cmd.ExecuteNonQuery();
                    obj.con.Close();
                    MessageBox.Show("Quiz Created Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void CreateQuizForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.projectDatabaseDataSet.Teachers);
          

        }

        private void NextQuestionbutton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
