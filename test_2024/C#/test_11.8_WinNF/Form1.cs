using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_11._8_WinNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double x, y, yy, z;
            x = double.Parse(txtYF.Text);
            if (x < 300)
                y = 0;
            else if (x < 800)
                y = 0.1;
            else if (x < 1000)
                y = 0.15;
            else if (x < 5000)
                y = 0.18;
            else
                y = 0.2;
            yy = x * y;
            z = x - yy;
            txtYF2.Text = x.ToString();
            txtYH.Text = yy.ToString();
            txtSF.Text = z.ToString();
        }
    }
}
