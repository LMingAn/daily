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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int money = 0, yibai = 0, wushi = 0, ershi = 0, shi = 0, wu = 0, yi = 0;
            money = Convert.ToInt32(txtMoney.Text);
            yibai = money / 100;
            money -= 100 * yibai;
            wushi = money / 50;
            money -= 50 * wushi;
            ershi = money / 20;
            money -= 20 * ershi;
            shi = money / 10;
            money -= 10 * shi;
            wu = money / 5;
            money -= 5 * wu;
            yi = money;
            txt100.Text = yibai.ToString();
            txt50.Text = wushi.ToString();
            txt20.Text = ershi.ToString();
            txt10.Text = shi.ToString();
            txt5.Text = wu.ToString();
            txt1.Text = yi.ToString();
        }
    }
}
