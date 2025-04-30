using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
            calculate();
            blood();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");
        private void calculate()
        {
            //con.Open();
            //string query = "select * from DonorTable";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //con.Close();
        }
        private void blood()
        {
            //con.Open();
            //string query = "select * from BloodTable";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //dataGridView2.DataSource = ds.Tables[0];
            //con.Close();
        }
        int oldstock;
        private void getstock(string bg)
        {
            //con.Open();
            //string query = "select * from BloodTable where BGroup='" + bg + "'";
            //SqlCommand cms = new SqlCommand(query, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(cms);
            //sda.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    oldstock = Convert.ToInt32(dr["BStock"].ToString());
            //}
            //con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            comboBox1.SelectedItem = row.Cells[6].Value.ToString();
            getstock(comboBox1.Text);
        }
        private void Reset()
        {
            textBox1.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Select A Donor");
            }
            else
            {
                //try
                //{
                //    int stock = oldstock + 1;
                //    string query = "update BloodTable set BStock=" + stock + "where BGroup='" + comboBox1.Text + "'" ;
                //    con.Open();
                //    SqlCommand cms = new SqlCommand(query, con);
                //    cms.ExecuteNonQuery();
                //    MessageBox.Show("DONATION SUCESSFULLY DONE");
                //    con.Close();
                //    Reset();
                //    blood();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            donor d1 = new donor();
            d1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Donate d = new Donate();
            d.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            viewdonor vd = new viewdonor();
            vd.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            viewpatient vp = new viewpatient();
            vp.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            bloodstock bs = new bloodstock();
            bs.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            bloodtransfer bt = new bloodtransfer();
            bt.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
