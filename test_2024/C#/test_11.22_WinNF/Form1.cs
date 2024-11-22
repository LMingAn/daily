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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg;
            msg = txtName.Text.Trim();
            if (msg == "")//姓名
            {
                MessageBox.Show("姓名不能为空！", "提示");
                return;
            }
            if (radMale.Checked)//性别
                msg += ", 男";
            else
                msg += ", 女";
            if (txtAge.Text.Trim() != "")//年龄
                msg += ", " + txtAge.Text.Trim() + "岁";
            if (txtNativePlace.Text.Trim() != "")//籍贯
                msg += ", " + txtNativePlace.Text.Trim() + "人";
            msg += "\n";
            string hobby;
            hobby = "";
            if (chk1.Checked)
                hobby += "<" + chk1.Text + ">";
            if (chk2.Checked)
                hobby += "<" + chk2.Text + ">";
            if (chk3.Checked)
                hobby += "<" + chk3.Text + ">";
            if (chk4.Checked)
                hobby += "<" + chk4.Text + ">";
            if (chk5.Checked)
                hobby += "<" + chk5.Text + ">";
            if (chk6.Checked)
                hobby += "<" + chk6.Text + ">";
            if (hobby != "")
                hobby = "爱好" + hobby;
            else
                hobby = "无特殊爱好";
            msg += hobby;
            MessageBox.Show(msg, "信息确认");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.GetType().Name == "TextBox")
                {
                    ctl.Text = "";
                }
                if (ctl.GetType().Name == "RadioButton")
                {
                    RadioButton rad = (RadioButton)ctl;
                    rad.Checked = false;
                }
            }
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl.GetType().Name == "CheckBox")
                {
                    CheckBox chk = (CheckBox)ctl;
                    chk.Checked = false;
                }
            }
        }
    }
}
