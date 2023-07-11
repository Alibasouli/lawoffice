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
    public partial class scheduling : Form
    {
        sql sql = new sql();
        public scheduling()
        {
            InitializeComponent();
            
        }
        public void refresh(string d)
        {
            string query = "";
            comboBox3.Items.Clear();
            comboBox1.Text = day_CB.Text;
            comboBox2.Text = month_CB.Text;
            comboBox5.Text = year_CB.Text;
            query = "SELECT * FROM Schedull WHERE date='" + d + "'";
              SqlDataReader reader=sql.querySelect(query);
            while (reader.Read())
            {
                comboBox3.Items.Add(reader["time"].ToString());
            }
            sql.Close();
        }
        public void refresh2(string d)
        {
            string query = "";
            comboBox3.Items.Clear();
            query = "SELECT * FROM Schedull WHERE date='" + d + "'";
            SqlDataReader reader = sql.querySelect(query);
            while (reader.Read())
            {
                comboBox3.Items.Add(reader["time"].ToString());
            }
            sql.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string date = "";
                date = (day_CB.SelectedItem.ToString() + "/" + month_CB.SelectedItem + "/" + year_CB.SelectedItem);
                string q = "SELECT * FROM Schedull";
                SqlDataReader reader = sql.querySelect(q);
                string time = firsHour_CB.SelectedItem.ToString() + "-" + secendHour_CB.SelectedItem.ToString();
                string query = "INSERT INTO Schedull (date, time, start, finish)" +
                        "VALUES('" + date + "' ,'" + time + "' ,'" + firsHour_CB.Text + "' ,'" + secendHour_CB.Text + "')";
                while (reader.Read())
                {
                    if (int.Parse(firsHour_CB.Text) >= int.Parse(reader["start"].ToString()) && int.Parse(firsHour_CB.Text) <= int.Parse(reader["finish"].ToString()))
                    {
                        sql.Close();
                        MessageBox.Show("There is a overlap");
                        break;
                    }
                    else
                    {
                        sql.Close();
                        sql.queryCommand(query);
                        sql.Close();
                        refresh(date);
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("plz select correct date and time");
            }
        }

        private void firsHour_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            secendHour_CB.Items.Clear();
            int x = int.Parse(firsHour_CB.SelectedItem.ToString());
            for(int i =x+1;i<=18;i++)
            {
                secendHour_CB.Items.Add(i);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = (comboBox1.SelectedItem.ToString() + "/" + comboBox2.SelectedItem + "/" + comboBox5.SelectedItem);
            refresh2(date);
        }

        private void delete_BT_Click(object sender, EventArgs e)
        {
            
            string date = (comboBox1.SelectedItem.ToString() + "/" + comboBox2.SelectedItem + "/" + comboBox5.SelectedItem);
            string query = "DELETE FROM Schedull where date='"+date+"'"+"AND time='"+comboBox3.Text+"'";
        }
    }
}
