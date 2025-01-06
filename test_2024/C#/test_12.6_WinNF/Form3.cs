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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3 = 0;
            n1 = Convert.ToInt32(num1.Text);
            n2 = Convert.ToInt32(num2.Text);
            if (radSum.Checked)
                n3 = n1 + n2;
            else if (radSub.Checked)
                n3 = n1 - n2;
            else if (radMul.Checked)
                n3 = n1 * n2;
            else if (radExc.Checked)
            {
                if (n2 == 0)
                {
                    MessageBox.Show("除数为0，请重新输入！");
                    return;
                }
                else
                    n3 = n1 / n2;
            }
            num3.Text = n3.ToString();
        }
    }
}
