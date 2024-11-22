using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_11._8_WinNF
{
    public partial class Form3 : Form
    {
        string yhm, mm, sf;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {

        }

        private void btnBro_Click(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void radXS_CheckedChanged(object sender, EventArgs e)
        {
            sf = radXS.Text;
            chk2.Checked = chk3.Checked = chk4.Checked = chk5.Checked = false;
        }

        private void radJS_CheckedChanged(object sender, EventArgs e)
        {
            sf = radJS.Text;
            chk2.Checked = true;
            chk3.Checked = chk4.Checked = chk5.Checked = false;
        }

        private void radGLY_CheckedChanged(object sender, EventArgs e)
        {
            if (radGLY.Checked)
            {
                sf = radGLY.Text;
                chk2.Checked = chk3.Checked = chk4.Checked = chk5.Checked = true;
            }
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlRecord.Visible = false;
            txtPwd.Text = txtUser.Text = "";
            radXS.Checked = true;
            tabMIS.SelectedTab = tpLogin;
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRecord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            yhm = txtUser.Text.Trim();
            mm = txtPwd.Text.Trim();
            if (yhm == "xs" && mm == "xs" && sf == "学生")
            {
                tabMIS.SelectedTab = tpRecord;
                pnlRecord.Visible = true;
                btnBro.Enabled = btnIns.Enabled = btnDel.Enabled = btnMod.Enabled = false;
                pnlLogin.Visible = false;
            }
            else if (yhm == "js" && mm == "js" && sf == "教师")
            {
                tabMIS.SelectedTab = tpRecord;
                pnlRecord.Visible = true;
                btnBro.Enabled = true;
                btnIns.Enabled = btnDel.Enabled = btnMod.Enabled = false;
                pnlLogin.Visible = false;
            }
            else if (yhm == "gly" && mm == "gly" && sf == "管理员")
            {
                tabMIS.SelectedTab = tpRecord;
                pnlRecord.Visible = true;
                pnlLogin.Visible = false;
                btnBro.Enabled = btnIns.Enabled = btnDel.Enabled = btnMod.Enabled = true;
            }
            else
                MessageBox.Show("用户名或密码或身份错误", "登陆失败");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            yhm = mm = "";
            sf = radXS.Text;
        }
    }
}
