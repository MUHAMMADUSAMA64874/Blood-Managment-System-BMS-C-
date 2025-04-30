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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
            calculate();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");

        private void label8_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();

        }
        private void calculate()
        {
            //con.Open();
            //string query = "select * from EmployeeTable";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //con.Close();
        }
        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            key = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                //try
                //{
                //    string query = "insert into EmployeeTable values('" + textBox1.Text + "','" + textBox2.Text + "')";
                //    con.Open();
                //    SqlCommand cms = new SqlCommand(query, con);
                //    cms.ExecuteNonQuery();
                //    MessageBox.Show("EMPLOYEE SUCESSFULLY SAVED");
                //    dataGridView1.Update();
                //    con.Close();
                //    reset();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

            }
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            if (textBox1.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Employee to Delete");
            }
            else
            {
                //try
                //{
                //    string query = "Delete from EmployeeTable where ENum=" + key + "";
                //    con.Open();
                //    SqlCommand cms = new SqlCommand(query, con);
                //    cms.ExecuteNonQuery();
                //    MessageBox.Show("EMPLOYEE SUCESSFULLY DELETED");
                //    con.Close();
                //    calculate();
                //    reset();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Select a Employee To Edit");
            }
            else
            {
                //try
                //{
                //    string query = "update EmployeeTable set EId='" + textBox1.Text + "',EPass=" + textBox2.Text + " where ENum=" + key + "";
                //    con.Open();
                //    SqlCommand cms = new SqlCommand(query, con);
                //    cms.ExecuteNonQuery();
                //    MessageBox.Show("PATIENT SUCESSFULLY UPDATED");
                //    con.Close();
                //    calculate();
                //    reset();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            employee e1 = new employee();
            e1.Show();
            this.Hide();
        }
    }
}
