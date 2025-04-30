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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            timer1.Start();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                login l = new login();
                l.Show();
                this.Hide();
            }
        }
    }
}
