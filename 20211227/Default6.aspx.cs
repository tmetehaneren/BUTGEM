using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(TextBox1.Text);
            if ((not>=0)&&(not<=5))
            {
                if (not==0 || not==1)
                {
                    Label1.Text = "Kaldın";
                }
                else if (not == 2)
                {
                    Label1.Text = "Başarılı";
                }
                else if (not == 3)
                {
                    Label1.Text = "Orta";
                }
                else if (not == 4)
                {
                    Label1.Text = "İyi";
                }
                else if (not == 5)
                {
                    Label1.Text = "Pek İyi";
                }
            }
            else
            {
                Label1.Text = "Girilen not uygun değil uygun not giriniz";
            }
        }
    }
}