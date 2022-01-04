using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(TextBox1.Text);
            if (yas >= 18)
                Label2.Text = "Hoşgeldiniz...";
            else
                Label2.Text = "Yaşınız uygun değil...";
        }
    }
}