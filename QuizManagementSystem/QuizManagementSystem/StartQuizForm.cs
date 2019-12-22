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
        private void StartQuizbutton_Click(object sender, EventArgs e)
        {
            if (EnterQuizIDtextBox.Text != null && StartQuizCourseNamecomboBox.Text.ToString() != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    Connection obj = new Connection();
                    obj.con.ConnectionString = obj.locate;

                    SqlConnection myconn;
                    SqlCommand sqlCmd;
                  
                     query=("Select * FROM Questions where QuizId ='" + EnterQuizIDtextBox.Text + "' and CourseName ='" + StartQuizCourseNamecomboBox.Text.ToString() + "'");
              
                   myconn = new SqlConnection(obj.locate);
                    sqlCmd = new SqlCommand(query, myconn);
                    DataTable dt = new DataTable();
                    myconn.Open();
                    
                   
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    { 
                       
                        
                        while(dr.Read())
                        {
                            QuestionHeadingLabel.Visible = true;
                            QuestionLabel.Visible = true;
                            AoptionradioButton.Visible = true;
                            BoptionRadioButton.Visible = true;
                            CoptionRadioButton.Visible = true;
                            DoptionRadioButton.Visible = true;
                            QuestionLabel.Text =dr.GetString(2);
                            AoptionradioButton.Text = dr.GetString(3);
                            BoptionRadioButton.Text = dr.GetString(4);
                            CoptionRadioButton.Text = dr.GetString(5);
                            DoptionRadioButton.Text = dr.GetString(6);
                        
                      }
                        dr.Close();
                    }
                   
                    myconn.Close();

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

       

        private void NextQuestionbutton_Click(object sender, EventArgs e)
        {
            if (EnterQuizIDtextBox.Text != null && StartQuizCourseNamecomboBox.Text.ToString() != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    Connection obj = new Connection();
                    obj.con.ConnectionString = obj.locate;

                    SqlConnection myconn;
                    SqlCommand sqlCmd;

                     query = ("Select * FROM Questions where QuizId ='" + EnterQuizIDtextBox.Text + "' and CourseName ='" + StartQuizCourseNamecomboBox.Text.ToString() + "'where QuizId >'" + query + "'");

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
    }
}
            


       


            
    



