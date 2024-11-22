using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_11._8_WinNF
{
    public partial class Form5 : Form
    {
        string yhm, mm, sf;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void radJS_CheckedChanged(object sender, EventArgs e)
        {
            sf = radJS.Text;
        }

        private void radGLY_CheckedChanged(object sender, EventArgs e)
        {
            if (radGLY.Checked)
            {
                sf = radGLY.Text;
            }
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            yhm = txtUser.Text.Trim();
            mm = txtPwd.Text.Trim();
            if (yhm == "xs" && mm == "xs" && sf == "学生")
            {
                pnlLogin.Visible = false;
                pnlBook.Visible = false;
                pnlRead.Visible = true;
            }
            else if (yhm == "js" && mm == "js" && sf == "教师")
            {
                pnlLogin.Visible = false;
                pnlBook.Visible = false;
                pnlRead.Visible = false;
            }
            else if (yhm == "gly" && mm == "gly" && sf == "管理员")
            {
                pnlLogin.Visible = false;
                pnlBook.Visible = false;
                pnlRead.Visible = false;
            }
            else
                MessageBox.Show("用户名或密码或身份错误", "登陆失败");

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            yhm = mm = "";
            sf = radXS.Text;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            tpBook.Visible = false;
            tpRead.Visible = false;
            txtPwd.Text = txtUser.Text = "";
            radXS.Checked = true;
            tabMIS.SelectedTab = tpLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            tpBook.Visible = false;
            tpRead.Visible = false;
            txtPwd.Text = txtUser.Text = "";
            radXS.Checked = true;
            tabMIS.SelectedTab = tpLogin;
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radXS_CheckedChanged(object sender, EventArgs e)
        {
            sf = radXS.Text;
        }
    }
}
