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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string msg = txtName1.Text + "的年龄是" + txtAge1.Text + "岁";
            MessageBox.Show(msg, "姓名和年龄", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
