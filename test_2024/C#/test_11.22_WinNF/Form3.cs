using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_11._22_WinNF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkGR())
                MessageBox.Show(record(), txtName.Text + "的推荐信息");

        }

        string msg;

        private bool checkGR()
        {
            bool check = true;
            if (txtName.Text.Trim() == "" || txtAge.Text.Trim() == "")
            {
                check = false;
                MessageBox.Show("用户名和年龄必须填写");
            }
            return check;
        }

        private string record()
        {
            msg = "";
            msg += txtName.Text.Trim();
            if (radMale.Checked)
                msg += ", 男";
            else
                msg += ", 女";
            msg += ", " + txtAge.Text.Trim() + "岁, ";
            msg += "文化程度：";
            if (radxx.Checked)
                msg += "小学";
            else if (radzx.Checked)
                msg += "中学";
            else
                msg += "大学";
            string fruits = "";
            foreach (Control ctl in groupBox1.Controls)
            {
                CheckBox chk = (CheckBox)ctl;
                if (chk.Checked == true)
                    fruits += "<" + chk.Text + ">";
            }
            if (fruits != "")
                fruits = "，爱吃的水果：" + fruits;
            msg += fruits;
            msg += "。\n";
            return msg;
        }
    }
}
