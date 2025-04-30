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
    public partial class bloodtransfer : Form
    {
        public bloodtransfer()
        {
            InitializeComponent();
            fillpatient();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");
        private void fillpatient()
        {
            //con.Open();
            //SqlCommand cms = new SqlCommand("select PNum from PatientTable", con);
            //SqlDataReader rdr;
            //rdr = cms.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("PNum", typeof(int));
            //dt.Load(rdr);
            //comboBox1.ValueMember = "PNum";
            //comboBox1.DataSource = dt;
            //con.Close();
        }
        private void getsdata()
        {
            //string query = "select * from PatientTable where PNum='" + comboBox1.SelectedValue.ToString() + "'";
            //SqlCommand cms = new SqlCommand(query, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(cms);
            //sda.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    textBox1.Text = (dr["PName"].ToString());
            //    comboBox2.Text = (dr["PBGroup"].ToString());
            //}
            //con.Close();
        }
        int stock;
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
            //    stock = Convert.ToInt32(dr["BStock"].ToString());
            //}
            //con.Close();
        }
        private void updatestock()
        {
            //int newstock = stock - 1;
            //try
            //{
            //    string query = "update BloodTable set BStock=" + newstock + "where BGroup='" + comboBox2.Text + "'";
            //    con.Open();
            //    SqlCommand cms = new SqlCommand(query, con);
            //    cms.ExecuteNonQuery();
            //    con.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                //try
                //{
                //    string query = "insert into TransferTable values('" + textBox1.Text + "','" + comboBox2.Text + "')";
                //    con.Open();
                //    SqlCommand cms = new SqlCommand(query, con);
                //    cms.ExecuteNonQuery();
                //    MessageBox.Show("SUCESSFULLY TRANSFER");
                //    con.Close();
                //    getstock(comboBox1.Text);
                //    updatestock();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            bloodstock bs = new bloodstock();
            bs.Show();
            this.Hide();
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

        private void label3_Click_1(object sender, EventArgs e)
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

        private void label5_Click_1(object sender, EventArgs e)
        {
            bloodstock bs = new bloodstock();
            bs.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void label13_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getsdata();
            getstock(comboBox2.Text);
            if (stock > 0)
            {
                button2.Visible = true;
                label12.Text = "Available Stock";
                label12.Visible = true;
            }
            else
            {
                label12.Text = "Unavailable Stock";
                label12.Visible = true;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            donor d1 = new donor();
            d1.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            viewpatient vp = new viewpatient();
            vp.Show();
            this.Hide();
        }

        private void label5_Click_2(object sender, EventArgs e)
        {
            bloodstock bs = new bloodstock();
            bs.Show();
            this.Hide();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            bloodtransfer bt = new bloodtransfer();
            bt.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void label13_Click_1(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
