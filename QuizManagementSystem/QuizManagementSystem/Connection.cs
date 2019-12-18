using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuizManagementSystem
{
    class Connection
    {

        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hassan Raza Khan\Source\Repos\HassanRazaKhan\VPprojectQuizManagementSystem\QuizManagementSystem\QuizManagementSystem\ProjectDatabase.mdf';Integrated Security=True";
        public SqlConnection con;
        public SqlCommand cmd = new SqlCommand();
        public Connection()
        {
            con = new SqlConnection(locate);
        }
       

    }
}
