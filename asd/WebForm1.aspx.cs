using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (DropDownList1.SelectedItem.Text == "16")
            {
                Label2.Text = "Bursa";
            }
            else if (DropDownList1.SelectedItem.Text == "35")
            {
                Label2.Text = "İzmir";
            }
            else if (DropDownList1.SelectedItem.Text == "06")
            {
                Label2.Text = "Ankara";
            }
            else if (DropDownList1.SelectedItem.Text == "34")
            {
                Label2.Text = "İstanbul";
            }
            else if (DropDownList1.SelectedItem.Text == "07")
            {
                Label2.Text = "Antalya";
            }*/

            switch (DropDownList1.SelectedItem.Text)
            {
                case "16":
                    Label2.Text = "Bursa";
                    break;
                case "34":
                    Label2.Text = "İstanbul";
                    break;
                case "06":
                    Label2.Text = "Ankara";
                    break;
                case "07":
                    Label2.Text = "Anlalya";
                    break;
                case "35":
                    Label2.Text = "İzmir";
                    break;
                default:
                    Label2.Text = "";
                    break;
            }
        }
    }
}