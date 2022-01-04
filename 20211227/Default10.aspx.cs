using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default101 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte ano = Convert.ToByte(TextBox1);
            switch (ano)
            {

                case 1:
                    Label2.Text = "ocak";

                    break;

                case 2:
                    Label2.Text = "şubat";
                    break;

                case 3:
                    Label2.Text = "mart";
                    break;

                case 4:
                    Label2.Text = "nisan";
                    break;

                case 5:
                    Label2.Text = "mays";
                    break;

                case 6:
                    Label2.Text = "haziran";
                    break;

                case 7:
                    Label2.Text = "temmuz";
                    break;
                case 8:
                    Label2.Text = "ağustos";
                    break;
                case 9:
                    Label2.Text = "eylül";
                    break;
                case 10:
                    Label2.Text = "ekim";
                    break;
                case 11:
                    Label2.Text = "kasım";
                    break;
                case 12:
                    Label2.Text = "aralık";
                    break;
            }
        }
    }
}