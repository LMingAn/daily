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
    public partial class Form2 : Form
    {
        string[] spec, cour1, cour2, cour3, cour4, cour5;

        private void cboSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSpec.SelectedIndex)
            {
                case 0:
                    lstCourse.DataSource = cour1;
                    break;
                case 1:
                    lstCourse.DataSource = cour2;
                    break;
                case 2:
                    lstCourse.DataSource = cour3;
                    break;
                case 3:
                    lstCourse.DataSource = cour4;
                    break;
                case 4:
                    lstCourse.DataSource = cour5;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkGR())
                MessageBox.Show(record(), txtName.Text + "的推荐信息");
        }

        string gr, xy, msg;

        private bool checkGR()
        {
            bool check = true;
            if (txtName.Text.Trim() == "" || txtAge.Text.Trim() == "")
            {
                check = false;
                MessageBox.Show("姓名和年龄必须填写");
            }
            return check;
        }

        private string record()
        {
            gr = "";
            gr += txtName.Text.Trim();
            if (radMale.Checked)
                gr += ", 男";
            else
                gr += ", 女";
            gr += ", " + txtAge.Text.Trim() + "岁, ";
            string hobby = "";
            foreach (Control ctl in groupBox1.Controls)
            {
                CheckBox chk = (CheckBox)ctl;
                if (chk.Checked == true)
                    hobby += "<" + chk.Text + ">";
            }
            if (hobby != "")
                hobby = "特长" + hobby;
            gr += hobby;
            gr += "。\n";
            xy = "所学专业<" + cboSpec.Text + ">, 专业必修课包括：\n";
            foreach (object course in lstCourse.Items)
                xy += "<" + course.ToString() + ">";
            xy += "。\n";
            if (chklstIntr.CheckedItems.Count != 0)
            {
                xy += "特别说明：";
                foreach (object intr in chklstIntr.CheckedItems)
                    xy += "<" + intr.ToString() + ">";
                xy += "。";
            }
            msg = gr + xy;
            return msg;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radMale.Checked = true;
            spec = new string[5] { "计算机科学与技术", "软件工程", "网络工程", "数字媒体", "通信工程" };
            cboSpec.DataSource = spec;
            cboSpec.SelectedIndex = 0;
            cour1 = new string[] { "计算机应用基础", "程序设计基础", "关系数据库", "计算机网络", "计算机科学", "计算机技术" };
            cour2 = new string[] { "计算机应用基础", "计算机网络", "关系数据库", "高级程序设计语言", "高级编程", "软件工程" };
            cour3 = new string[] { "计算机应用基础", "程序设计基础", "关系数据库", "计算机网络", "高级程序设计语言", "高级计算机网络技术" };
            cour4 = new string[] { "计算机应用基础", "程序设计基础", "计算机数学", "计算机网络", "数字媒体", "高级数字媒体技术" };
            cour5 = new string[] { "计算机应用基础", "程序设计基础", "计算机数学", "数字电路", "模拟电路", "通信工程" };
            lstCourse.DataSource = cour1;
        }
    }
}
