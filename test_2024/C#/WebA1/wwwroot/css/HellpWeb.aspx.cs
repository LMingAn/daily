using System;
namespace WebA1
{
    public partial class HelloWeb:System.Web.UI.page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "这是一个Web窗体";
            Label1.Text = "Hello,World!";
        }
    }
}