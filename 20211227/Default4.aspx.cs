using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte yas = Convert.ToByte(TextBox1.Text);
            if ((yas>=0)&&(yas<=6))
            {
                Label2.Text = "Çocuksunuz";
            }
            else if ((yas >= 7) && (yas <= 17))
            {
                Label2.Text = "Gençtir";
            }
            else if ((yas >= 18) && (yas <= 30))
            {
                Label2.Text = "Orta Gençtir";
            }
            else if ((yas >= 31) && (yas <= 40))
            {
                Label2.Text = "Olgundur";
            }
            else if ((yas >= 41) && (yas <= 60))
            {
                Label2.Text = "Orta Yaşdır";
            }
            else
            {
                Label2.Text = "Yaşlı";
            }
        }
    }
}