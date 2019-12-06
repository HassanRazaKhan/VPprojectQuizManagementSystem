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
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Hassan Raza Khan\Source\Repos\HassanRazaKhan\VPprojectQuizManagementSystem\QuizManagementSystem\QuizManagementSystem\ProjectDatabase.mdf';Integrated Security=True";

    }
}
