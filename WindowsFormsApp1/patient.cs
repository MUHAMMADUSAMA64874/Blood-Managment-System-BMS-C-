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
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");
        private void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "" || comboBox3.SelectedIndex == -1 || textBox4.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    string query =string.Format( "insert into PatientTable values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text   + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString()  + "','" + textBox4.Text + "')");
                    SERVER.INSERT(query);
                    MessageBox.Show("PATIENT SUCESSFULLY SAVED");
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            viewpatient viewpatient = new viewpatient();
            viewpatient.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            bloodtransfer bt = new bloodtransfer();
            bt.Show();
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

        private void label5_Click(object sender, EventArgs e)
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

        private void label16_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }
    }
}
