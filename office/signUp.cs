using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace office
{
    public partial class signUp : Form
    {
        sql sql = new sql();
        public Form1 Form1;
        public signUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lastName_TB.Text == "" || name_TB.Text == "" || address_TB.Text == "" ||
                 phoneNumber_TB.Text == "" || username_TB.Text == "" || password_TB.Text == "")
            {
                MessageBox.Show("plz fill in all the fields");
            }
            else
            {
                string id = "";
                string name = name_TB.Text;
                string lastname = lastName_TB.Text;
                string address = address_TB.Text;
                string phone = phoneNumber_TB.Text;
                string username = username_TB.Text;
                string password = password_TB.Text;
                string query = "INSERT INTO Customers (name ,lastName ,address ,PhoneNumber ,username ,Password )" +
                    "VALUES('" + name + "' ,'" + lastname + "' ,'" + address + "' ,'" + phone + "' ,'" + username + "' ,'" + password + "')";
                string query2 = "SELECT id FROM Customers WHERE Username='" + username + "'";
                SqlDataReader reader = sql.querySelect(query2);
                while (reader.Read())
                {
                    id = reader["id"].ToString();
                }
                if (id == "")
                {
                    sql.Close();
                    sql.queryCommand(query);
                    MessageBox.Show("user added successfully");
                    this.Hide();
                    Form1.Show();
                    Form1.userName_TB.Text = username_TB.Text;
                    Form1.password_TB.Text = password_TB.Text;
                }
                else
                {
                    MessageBox.Show("username already taken");
                }
                sql.Close();

            }
        }

        private void Back_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Show();

        }
    }
}
