using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(TextBox1.Text);
            if ((not >= 0) && (not <= 100))
            {
                if (not>=70)
                {
                    Label2.Text = "Geçerli";
                }
                else
                {
                    Label2.Text = "Geçersiz";
                }
            }
            else
            {
                Label2.Text = "Geçerli Not giriniz";
            }
        }
    }
}