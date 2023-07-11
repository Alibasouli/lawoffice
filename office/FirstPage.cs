using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace office
{
    public partial class FirstPage : Form
    {
        Form1 Form1 = new Form1();
        
        public FirstPage()
        {
            InitializeComponent();
            Form1.firstPage = this;
        }

        private void Customer_BT_Click(object sender, EventArgs e)
        {
            Form1.login = true;
            Form1.Show();
            this.Hide();
            
        }

        private void Lawyer_BT_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            Form1.Show();
            this.Hide();
        }
    }
}
