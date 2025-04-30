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

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");

        private void label4_Click(object sender, EventArgs e)
        {
            loginadmin ad = new loginadmin();
            ad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            {
                mainpage m = new mainpage();
                   m.Show();
                    this.Hide();
                 con.Close();
                //con.Open();
                //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTable where EId='" + textBox1.Text + "' and EPass='" + textBox2.Text + "'", con);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //if (dt.Rows[0][0].ToString() == "1")
                //{
                //    mainpage m = new mainpage();
                //    m.Show();
                //    this.Hide();
                //    con.Close();
                //}
                //else
                //{
                //    MessageBox.Show("WRONG USERNAME OR PASSWORD");
                //}
                //con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
