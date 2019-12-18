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

        private void StartQuizbutton_Click(object sender, EventArgs e)
        {
            if (EnterQuizIDtextBox.Text != null && CourseNametextBox.Text != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    Connection obj = new Connection();
                    obj.con.ConnectionString = obj.locate;

                    SqlConnection myconn;
                    SqlCommand sqlCmd;
                  
                    string query=("Select * FROM Questions where QuizId ='" + EnterQuizIDtextBox.Text + "' and CourseName ='" + CourseNametextBox.Text + "'");
                   myconn = new SqlConnection(obj.locate);
                    sqlCmd = new SqlCommand(query, myconn);
                    DataTable dt = new DataTable();
                    myconn.Open();
                    
                    //if (dt.Rows[0][0].ToString() == "1")
                    //{
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    { 
                       
                        
                        while(dr.Read())
                        {
                            QuestiontextBox.Text =dr.GetString(2);
                            OptionAtextBox.Text = dr.GetString(3);
                            OptionBtextBox.Text = dr.GetString(4);
                            OptionCtextBox.Text = dr.GetString(5);
                            OptionDtextBox.Text = dr.GetString(6);
                        
                      }
                        dr.Close();
                    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Quiz Id or Course Name is incorrect");
                    //}
                    myconn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
            


       


            
    



