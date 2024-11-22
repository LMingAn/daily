using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_10._11_WinNF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtString.Text.ToUpper());
            MessageBox.Show(txtString.Text.ToLower());
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
