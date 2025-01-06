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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //单选框
            string favoritePlace = GetSelectedRadioButtonText(groupBoxFP);
            string favoriteSport = GetSelectedRadioButtonText(groupBoxFS);
            //复选框
            string favoriteFruits = GetCheckedltemsText(groupBoxFF);
            string hobbies = GetCheckedltemsText(groupBoxH);
            //文本框
            string hometown = txtHometown.Text;
            string address = txtAddress.Text;
            //对话框
            string message = $"感谢您参与调查，您最喜欢的地方是 {favoritePlace}，" +
            $"最喜欢的运动是 {favoriteSport}，喜爱的水果是 {favoriteFruits}，" +
            $"爱好的娱乐有 {hobbies}。\n您的籍贯地是 {hometown}，家庭住址是 {address}";
            MessageBox.Show(message,"调查结果");
        }

        private string GetSelectedRadioButtonText(Control parentControl)
        {
            foreach (RadioButton rb in parentControl.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    return rb.Text;
            }
            return "未选择";
        }

        private string GetCheckedltemsText(Control parentControl)
        {
            string selectedItems = "";
            foreach (CheckBox cb  in parentControl.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                    selectedItems += "、";
                selectedItems += cb.Text;
            }
            return string.IsNullOrEmpty(selectedItems) ? "未选择" : selectedItems;
        }
    }
}
