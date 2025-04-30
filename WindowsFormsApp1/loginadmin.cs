using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginadmin : Form
    {
        public loginadmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("ENTER ADMIN PASSWORD");
            }
            else if (textBox2.Text == "123")
            {
                employee emp = new employee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONG PASSWORD");
                textBox2.Text = "";
            }
        }
    }
}
