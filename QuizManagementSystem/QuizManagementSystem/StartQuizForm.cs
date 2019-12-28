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
using System.Data.SqlTypes;

namespace QuizManagementSystem
{
    
    public partial class StartQuizForm : Form
    {
        public int count = 0;
        private int nextQs;
        public StartQuizForm()
        {
            InitializeComponent();
            
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            StudentMainMenu smm = new StudentMainMenu();
            this.Hide();
            smm.Show();
        }
        private void StartQuizForm_Load(object sender, EventArgs e)
        {
            StartQuiztimer.Start();
            StartQuiztimer.Enabled = true;
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.projectDatabaseDataSet.Teachers);
            QuestionHeadingLabel.Visible = false;
            QuestionLabel.Visible = false;
            AoptionradioButton.Visible = false;
            BoptionRadioButton.Visible = false;
            CoptionRadioButton.Visible = false;
            DoptionRadioButton.Visible = false;
        }
        string query;
        string correctOption;
        private void StartQuizbutton_Click(object sender, EventArgs e)
        {
            string inputAnswer = "";
            
            if (EnterQuizIDtextBox.Text != null && StartQuizCourseNamecomboBox.Text.ToString() != null)
            {
                
                try
                {
                    QuestionLabel.Text = "";
                    AoptionradioButton.Text = "";
                    BoptionRadioButton.Text = "";
                    CoptionRadioButton.Text = "";
                    DoptionRadioButton.Text = "";
                    this.nextQs = Convert.ToInt32(this.EnterQuizIDtextBox.Text);
                    showQuestions(false,inputAnswer);
                  MarksLabel.Text= Convert.ToString( this.count);
                    this.EnterQuizIDtextBox.Visible = false;
                    this.StartQuizCourseNamecomboBox.Visible = false;
                    this.StartQuizbutton.Visible = false;
                    this.EnterQuizIDlabel.Text = "Quiz ID: " + this.EnterQuizIDtextBox.Text;
                    this.CoureNamelabel.Text = "Course Name: " + this.StartQuizCourseNamecomboBox.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Quiz ID or Course Name is incorrect");
            }
        }

       private  void showQuestions(bool flag,string input)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand();
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;

            SqlConnection myconn;
            SqlCommand sqlCmd;
            if(flag==false)
              query = ("Select * FROM Questions where QuizId ='" + Convert.ToString(this.nextQs) + "' and CourseName ='" + StartQuizCourseNamecomboBox.Text.ToString() + "'");
            else
                query = ("Select * FROM Questions where QuizId >'" + Convert.ToString(this.nextQs) + "' and CourseName ='" + StartQuizCourseNamecomboBox.Text.ToString() + "'");
            myconn = new SqlConnection(obj.locate);
            sqlCmd = new SqlCommand(query, myconn);
            DataTable dt = new DataTable();
            this.EnterQuizIDtextBox.Text = Convert.ToString(this.nextQs);
            myconn.Open();

            
            using (SqlDataReader dr = sqlCmd.ExecuteReader())
            {


                while (dr.Read())
                {
                    
                    QuestionHeadingLabel.Visible = true;
                    QuestionLabel.Visible = true;
                    AoptionradioButton.Visible = true;
                    BoptionRadioButton.Visible = true;
                    CoptionRadioButton.Visible = true;
                    DoptionRadioButton.Visible = true;
                    QuestionLabel.Text = dr.GetString(2);
                    if (input == dr.GetString(3))
                        count += 1;
                    else if (input == dr.GetString(4))
                        count += 1;
                    else if (input == dr.GetString(5))
                        count += 1;
                    else if (input == dr.GetString(6))
                        count += 1;
                    AoptionradioButton.Text = dr.GetString(3);
                    BoptionRadioButton.Text = dr.GetString(4);
                    CoptionRadioButton.Text = dr.GetString(5);
                    DoptionRadioButton.Text = dr.GetString(6);

                }
                dr.Close();
            }

            myconn.Close();
           
        }

        private void NextQuestionbutton_Click(object sender, EventArgs e)
        {
            string inputAnswer = "";
            if (AoptionradioButton.Checked == true)
                inputAnswer = AoptionradioButton.Text;
            else if (BoptionRadioButton.Checked == true)
                inputAnswer = BoptionRadioButton.Text;
            else if (CoptionRadioButton.Checked == true)
                inputAnswer = CoptionRadioButton.Text;
            else if (DoptionRadioButton.Checked == true)
                inputAnswer = DoptionRadioButton.Text;
            

            if (EnterQuizIDtextBox.Text != null && StartQuizCourseNamecomboBox.Text.ToString() != null)
            {
                try
                {
                    QuestionLabel.Text = "";
                    AoptionradioButton.Text = "";
                    BoptionRadioButton.Text = "";
                    CoptionRadioButton.Text = "";
                    DoptionRadioButton.Text = "";
                    this.nextQs += 1;
                    showQuestions(false, inputAnswer);
                    MarksLabel.Text = Convert.ToString(this.count);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Quiz ID or Course Name is incorrect");
            }
        }

        private void SumbitQuizbutton_Click(object sender, EventArgs e)
        {
            string inputAnswer = "";
            if (AoptionradioButton.Checked == true)
                inputAnswer = AoptionradioButton.Text;
            else if (BoptionRadioButton.Checked == true)
                inputAnswer = BoptionRadioButton.Text;
            else if (CoptionRadioButton.Checked == true)
                inputAnswer = CoptionRadioButton.Text;
            else if (DoptionRadioButton.Checked == true)
                inputAnswer = DoptionRadioButton.Text;
            else;
            SqlCommand cmd = new SqlCommand();
            Connection obj = new Connection();
            obj.con.ConnectionString = obj.locate;

            SqlConnection myconn;
            SqlCommand sqlCmd;

            query = ("Select * FROM Questions where CorrectAnswer ='" + inputAnswer + "'");
            myconn = new SqlConnection(obj.locate);
            sqlCmd = new SqlCommand(query, myconn);
            DataTable dt = new DataTable();

            myconn.Open();


            using (SqlDataReader dr = sqlCmd.ExecuteReader())
            {


                while (dr.Read())
                {

                    QuestionHeadingLabel.Visible = true;
                    QuestionLabel.Visible = true;
                    AoptionradioButton.Visible = true;
                    BoptionRadioButton.Visible = true;
                    CoptionRadioButton.Visible = true;
                    DoptionRadioButton.Visible = true;
                    QuestionLabel.Text = dr.GetString(2);
                    AoptionradioButton.Text = dr.GetString(3);
                    BoptionRadioButton.Text = dr.GetString(4);
                    CoptionRadioButton.Text = dr.GetString(5);
                    DoptionRadioButton.Text = dr.GetString(6);

                }
                dr.Close();
            }

            myconn.Close();
        }

        private void StartQuiztimer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int A = ran.Next(0, 255);
            int R = ran.Next(0, 255);
            int G = ran.Next(0, 255);
            int B = ran.Next(0, 255);
            StartQuizbutton.ForeColor = Color.FromArgb(A, R, G, B);
        }
    }
    
}
            


       


            
    



