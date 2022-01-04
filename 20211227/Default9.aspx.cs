using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte gno = Convert.ToByte(TextBox1.Text);
            switch (gno)
            {
                case 1:
                    Label2.Text = "pazartesi";
                        
                    break;

                case 2:
                    Label2.Text = "Salı";
                    break;

                case 3:
                    Label2.Text = "Çarşamba";
                    break;

                case 4:
                    Label2.Text = "Perşembe";
                    break;

                case 5:
                    Label2.Text = "Cuma";
                    break;

                case 6:
                    Label2.Text = "Cumartesi";
                    break;

                case 7:
                    Label2.Text = "Pazar";
                    break;

                default:
                    Label2.Text = "Geçerli bir gün giriniz";
                    break;
            }
        }
    }
}