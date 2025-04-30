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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            getdata();
        }
        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS; initial catalog=BLOODDB; integrated security=true");
        private void getdata()
        {
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DonorTable", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //label12.Text = dt.Rows[0][0].ToString();

            //SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from TransferTable", con);
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);
            //label13.Text = dt1.Rows[0][0].ToString();

            //SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from EmployeeTable", con);
            //DataTable dt2 = new DataTable();
            //sda2.Fill(dt2);
            //label14.Text = dt2.Rows[0][0].ToString();

            //SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from BloodTable", con);
            //DataTable dt3 = new DataTable();
            //sda3.Fill(dt3);
            //int btstock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            //label11.Text = "" + btstock;
        }
            //    //O+
            //    SqlDataAdapter sda4 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "O+" + "'", con);
            //    DataTable dt4 = new DataTable();
            //    sda4.Fill(dt4);
            //    label23.Text = dt4.Rows[0][0].ToString();
            //    double zeroplus=(Convert.ToDouble(dt4.Rows[0][0].ToString()) / btstock ) *100;
            //    progressBar2.Value = Convert.ToInt32(zeroplus);
            //    //O-
            //    SqlDataAdapter sda5 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "O-" + "'", con);
            //    DataTable dt5 = new DataTable();
            //    sda5.Fill(dt5);
            //    label29.Text = dt5.Rows[0][0].ToString();
            //    double zerominus = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar4.Value = Convert.ToInt32(zerominus);
            //    //AB+
            //    SqlDataAdapter sda6 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "AB+" + "'", con);
            //    DataTable dt6 = new DataTable();
            //    sda6.Fill(dt6);
            //    label24.Text = dt6.Rows[0][0].ToString();
            //    double abplus = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar3.Value = Convert.ToInt32(abplus);
            //    //AB-
            //    SqlDataAdapter sda7 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "AB-" + "'", con);
            //    DataTable dt7 = new DataTable();
            //    sda7.Fill(dt7);
            //    label30.Text = dt7.Rows[0][0].ToString();
            //    double abminus = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar5.Value = Convert.ToInt32(abminus);
            //    //A+
            //    SqlDataAdapter sda8 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "A+" + "'", con);
            //    DataTable dt8 = new DataTable();
            //    sda8.Fill(dt8);
            //    label31.Text = dt8.Rows[0][0].ToString();
            //    double aplus = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar1.Value = Convert.ToInt32(aplus);
            //    //A-
            //    SqlDataAdapter sda9 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "A-" + "'", con);
            //    DataTable dt9 = new DataTable();
            //    sda9.Fill(dt9);
            //    label33.Text = dt9.Rows[0][0].ToString();
            //    double aminus = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar7.Value = Convert.ToInt32(aminus);
            //    //B+
            //    SqlDataAdapter sda10 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "B+" + "'", con);
            //    DataTable dt10 = new DataTable();
            //    sda10.Fill(dt10);
            //    label32.Text = dt10.Rows[0][0].ToString();
            //    double bplus = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar6.Value = Convert.ToInt32(bplus);
            //    //B-
            //    SqlDataAdapter sda11 = new SqlDataAdapter("select BStock from BloodTable where BGroup='" + "B-" + "'", con);
            //    DataTable dt11 = new DataTable();
            //    sda11.Fill(dt11);
            //    label34.Text = dt11.Rows[0][0].ToString();
            //    double bminus = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / btstock) * 100;
            //    progressBar8.Value = Convert.ToInt32(bminus);

            //    con.Close();
            //}

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

        private void label35_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
