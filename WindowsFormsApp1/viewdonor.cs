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
    public partial class viewdonor : Form
    {
        public viewdonor()
        {
            InitializeComponent();
            VD();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");
        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            comboBox3.SelectedIndex = -1;
            textBox4.Text = "";
        }
        private void VD()
        {
            //DataTable dt = new DataTable();
            //string query = "select * from DonorTable";
            //dt = SERVER.VIEWDATAGRID(query);
            //dataGridView1.DataSource= dt;
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            comboBox1.SelectedItem = row.Cells[3].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[5].Value.ToString();
            comboBox3.SelectedItem = row.Cells[6].Value.ToString();
            if (textBox1.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            donor d1 = new donor();
            d1.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || comboBox3.SelectedIndex == -1 || textBox4.Text == "")
            {
                MessageBox.Show("Please Select a DONOR To Edit");
            }
            else
            {
                try
                {
                    string query = "update DonorTable set DName='" + textBox1.Text + "',DAge=" + textBox2.Text + ",DGender='" + comboBox1.SelectedItem.ToString() + "',DPhone='" + textBox3.Text + "',DAddress='" + textBox4.Text + "',DBGroup='" + comboBox3.SelectedItem.ToString() + "' where DNum=" + key + "";
                    SERVER.UPDATE(query);
                    MessageBox.Show("DONOR SUCESSFULLY UPDATED");
                    Reset();
                    VD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Donor to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from DonorTable where DNum=" + key + "";
                    SERVER.DELTED(query, key);              
                    MessageBox.Show("DONOR SUCESSFULLY DELETED");
                    Reset();
                    VD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}