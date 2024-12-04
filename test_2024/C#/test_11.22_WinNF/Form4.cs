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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[] spec, cour1, cour2;

        private void Form4_Load(object sender, EventArgs e)
        {
            radMale.Checked = true;
            spec = new string[2] { "四川省", "广东省" };
            cboSpec.DataSource = spec;
            cboSpec.SelectedIndex = 0;
            cour1 = new string[] { "成都市", "泸州市", "乐山市" };
            cour2 = new string[] { "广州市", "深圳市", "珠海市", "佛山市" };
            lstCourse.DataSource = cour1;
        }

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
            }

        }
    }
}
