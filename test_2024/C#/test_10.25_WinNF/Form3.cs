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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRedLeaf_Click(object sender, EventArgs e)
        {
            picChange.Image = Image.FromFile(@"pic\红叶.jpg");
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            picChange.Image = new Bitmap(@"pic\\水果.jpg");
        }

        private void btnFlower_Click(object sender, EventArgs e)
        {
            picChange.ImageLocation = @"pic\鲜花.jpg";
            picChange.Load();
        }

        private void btnGirl_Click(object sender, EventArgs e)
        {
            picChange.Load("pic\\肖像.jpg");
        }

        private void btnUmbrella_Click(object sender, EventArgs e)
        {
            picChange.ImageLocation ="pic\\花伞.jpg";
            picChange.LoadAsync();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            picChange.LoadAsync(@"pic\风景.jpg");
        }
    }
}
