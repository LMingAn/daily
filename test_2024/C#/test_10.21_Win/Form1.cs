namespace test_10._21_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkFile.LinkVisited = true;
            System.Diagnostics.Process.Start("for you.png");
        }

        private void lnkForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f2 = new Form();
            f2.Show();
            lnkForm.LinkVisited = true;
        }

        private void lnkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWeb.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }
    }
}
