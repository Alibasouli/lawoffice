using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace office
{
    public partial class CustomerLanding : Form
    {
        sql sql = new sql();
        public CustomerLanding()
        {
            InitializeComponent();
        }
        public void refresh(string d)
        {
            string query = "";
            comboBox1.Items.Clear();
            query = "SELECT * FROM Schedull WHERE date='" + d + "'";
            SqlDataReader reader = sql.querySelect(query);
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["time"].ToString());
            }
            sql.Close();
        }

        private void CustomerLanding_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = (day_CB.SelectedItem.ToString() + "/" + month_CB.SelectedItem + "/" + year_CB.SelectedItem);
            refresh(date);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = (day_CB.SelectedItem.ToString() + "/" + month_CB.SelectedItem + "/" + year_CB.SelectedItem);
            string q = "UPDATE Schedull SET book='1' WHERE date='"+date+"' AND time='"+comboBox1.Text+"'";
            sql.queryCommand(q);
            sql.Close();
            string q2 = "SELECT date, time FROM Schedull WHERE book='1'";
            SqlDataReader reader = sql.querySelect(q2);
            listBox1.Items.Clear();
            while (reader.Read())
            {
                string a = reader["date"].ToString() +"   "+ reader["time"].ToString();
                listBox1.Items.Add(a);
            }
            sql.Close();
        }
    
    }
}
