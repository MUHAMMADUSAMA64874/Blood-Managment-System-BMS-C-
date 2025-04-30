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
    public partial class bloodstock : Form
    {
        public bloodstock()
        {
            InitializeComponent();
            blood();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");
        private void blood()
        {
            //con.Open();
            //string query = "select * from BloodTable";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            bloodtransfer bt = new bloodtransfer();
            bt.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            donor d1 = new donor();
            d1.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void label6_Click_1(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
