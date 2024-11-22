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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int x = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                PicBox.Image = imageList1.Images[x];
                picName.Text = "风景.jpg";
                x++;
            }
            else if (x == 1)
            {
                PicBox.Image = imageList1.Images[x];
                picName.Text = "红叶.jpg";
                x++;
            }
            else if (x == 2)
            {
                PicBox.Image = imageList1.Images[x];
                picName.Text = "花伞.jpg";
                x++;
            }
            else if (x == 3)
            {
                PicBox.Image = imageList1.Images[x];
                picName.Text = "水果.jpg";
                x++;
            }
            else if (x == 4)
            {
                PicBox.Image = imageList1.Images[x];
                picName.Text = "鲜花.jpg";
                x++;
            }
            else if (x == 5)
            {
                PicBox.Image = imageList1.Images[x];
                picName.Text = "肖像.jpg";
                x++;
            }
            else if (x > 5)
            {
                PicBox.Image = imageList1.Images[0];
                picName.Text = "风景.jpg";
                x = 1;
            }
        }
    }
}
