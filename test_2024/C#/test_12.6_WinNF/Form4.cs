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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void picShow_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = prgPic.Value + 1;
            if (i <= prgPic.Maximum)
            {
                prgPic.Value += 1;
                switch (i)
                {
                    case 1:
                        picShow.Image = Image.FromFile(@"pic\02.jpg");
                        break;
                    case 2:
                        picShow.Image = Image.FromFile(@"pic\03.jpg");
                        break;
                    case 3:
                        picShow.Image = Image.FromFile(@"pic\04.jpg");
                        break;
                    case 4:
                        picShow.Image = Image.FromFile(@"pic\05.jpg");
                        break;
                }
            }
            else
            {
                prgPic.Value = 0;
                picShow.Image = Image.FromFile(@"pic\01.jpg");
            }

        }
    }
}
