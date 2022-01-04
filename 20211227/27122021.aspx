using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte ano = Convert.ToByte(TextBox1.Text);
            switch (ano)
            {
                case 1:
                    Label2.Text = "Ocak";
                    break;
                case 2:
                    Label2.Text = "Şubat";
                    break;
                case 3:
                    Label2.Text = "Mart";
                    break;
                case 4:
                    Label2.Text = "Nisan";
                    break;
                case 5:
                    Label2.Text = "Mayıs";
                    break;
                case 6:
                    Label2.Text = "Haziran";
                    break;
                case 7:
                    Label2.Text = "Temmuz";
                    break;
                case 8:
                    Label2.Text = "Ağustos";
                    break;
                case 9:
                    Label2.Text = "Eylül";
                    break;
                case 10:
                    Label2.Text = "Ekim";
                    break;
                case 11:
                    Label2.Text = "Kasım";
                    break;
                case 12:
                    Label2.Text = "Aralık";
                    break;
                default:
                    Label2.Text = "Geçerli bir ay giriniz";
                    break;
            }
        }
    }
}