using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_10._11_WinNF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            int shu1, shu2, jieguo;
            shu1 = Convert.ToInt32(num1.Text);
            shu2 = Convert.ToInt32(num2.Text);
            jieguo = shu1 - shu2;
            num3.Text = jieguo.ToString();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int shu1, shu2, jieguo;
            shu1 = Convert.ToInt32(num1.Text);
            shu2 = Convert.ToInt32(num2.Text);
            jieguo = shu1 + shu2;
            num3.Text = jieguo.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int shu1, shu2, jieguo;
            shu1 = Convert.ToInt32(num1.Text);
            shu2 = Convert.ToInt32(num2.Text);
            jieguo = shu1 * shu2;
            num3.Text = jieguo.ToString();
        }

        private void exc_Click(object sender, EventArgs e)
        {
            int shu1, shu2, jieguo;
            shu1 = Convert.ToInt32(num1.Text);
            shu2 = Convert.ToInt32(num2.Text);
            jieguo = shu1 / shu2;
            num3.Text = jieguo.ToString();
        }

        private void num3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
