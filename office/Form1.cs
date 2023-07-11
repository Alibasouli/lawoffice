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
    public partial class Form1 : Form
    {
        sql sql = new sql();
        public bool login;
        public FirstPage firstPage;
        CustomerLanding customer = new CustomerLanding();
        LawyerLanding lawyer = new LawyerLanding();
        signUp signUp = new signUp();
        public Form1()
        {
            InitializeComponent();
            signUp.Form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 255, 255, 255);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp.Show();
            this.Hide();
        }

        private void Back_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstPage.Show();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (login)
            {
                linkLabel1.Visible = true;
                label3.Text = "Customers";
            }
            else
            {
                linkLabel1.Visible = false;
                label3.Text = "Lawyers";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query;
            string username = userName_TB.Text;
            string password = password_TB.Text;
            string pass = "";
            if (login)
                query = "SELECT Password FROM Customers WHERE Username='" + username + "'";
            else
                query = "SELECT Password FROM Lawyers WHERE Username='" + username + "'";
            SqlDataReader reader = sql.querySelect(query);
            while (reader.Read())
            {
                pass = reader["Password"].ToString();
            }
            if (password == pass)
            {
                if (login)
                    customer.Show();
                else
                    lawyer.Show();
                userName_TB.Text = password_TB.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("username or password is incorrect");
            }
            sql.Close();



        }

      
    }
}
