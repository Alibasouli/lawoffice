using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace office
{
    class sql
    {
        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ali\source\repos\office\office\LawOffice_DB.mdf;Integrated Security=True");
        public void queryCommand(string q)
        {
            c.Open();
            SqlCommand command = new SqlCommand(q, c);
            command.ExecuteNonQuery();

        }
        public SqlDataReader querySelect(string q)
        {
            
            c.Open();
            SqlCommand command = new SqlCommand(q, c);
            SqlDataReader reader = command.ExecuteReader();
            return (reader);

        }
        public void Close()
        {
            c.Close();
        }

    }
}
