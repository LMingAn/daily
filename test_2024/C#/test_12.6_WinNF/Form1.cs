using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_12._6_WinNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled ==  false)
            {
                timer1.Enabled = true;
                btnAuto.Text = "停止";
                picTraffic.Image = Image.FromFile("red.ico");
                lblTime.Text = "30";
            }
            else
            {
                timer1.Enabled = false;
                btnAuto.Text = "开始";
                i = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            switch (i)
            {
                case 27:
                    picTraffic.Image = Image.FromFile("yel.ico");
                    break;
                case 30:
                    picTraffic.Image = Image.FromFile("gre.ico");
                    lblTime.Text = "30";
                    break;
                case 57:
                    picTraffic.Image = Image.FromFile("yel.ico");
                    break;
                case 60:
                    picTraffic.Image = Image.FromFile("red.ico");
                    lblTime.Text = "30";
                    i = 0;
                    break;
            }
        }
    }
}
