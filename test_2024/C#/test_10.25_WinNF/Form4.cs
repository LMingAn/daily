using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_10._25_WinNF
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnRedLeaf1_Click(object sender, EventArgs e)
        {
            Pic.ImageIndex = 0;
        }

        private void btnFruit1_Click(object sender, EventArgs e)
        {
            Pic.ImageIndex = 1;
        }

        private void btnFlower1_Click(object sender, EventArgs e)
        {
            Pic.ImageIndex = 2;
        }

        private void btnGirl1_Click(object sender, EventArgs e)
        {
            Pic.ImageIndex = 3;
        }

        private void btnUmbrella1_Click(object sender, EventArgs e)
        {
            Pic.ImageIndex = 4;
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            Pic.ImageIndex = 5;
        }
    }
}
