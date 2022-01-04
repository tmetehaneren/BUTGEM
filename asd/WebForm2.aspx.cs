using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (DropDownList1.SelectedItem.Text)
            //{
            //    case "0-6":
            //        Label1.Text = "İyi Geceler";
            //        break;
            //    case "7-12":
            //        Label1.Text = "Günaydın";
            //        break;
            //    case "13-18":
            //        Label1.Text = "Tünaydın";
            //        break;
            //    case "19-23":
            //        Label1.Text = "İyi Akşamlar";
            //        break;
            //    default:
            //        Label1.Text = "";
            //        break;
            //}
            if (DropDownList1.SelectedItem.Value=="1")
            {
                Label1.Text = "İyi geceler";
            }
            else if (DropDownList1.SelectedItem.Value == "2")
            {
                Label1.Text = "Günaydın";
            }
            else if (DropDownList1.SelectedItem.Value == "3")
            {
                Label1.Text = "Tünaydın";
            }
            else if (DropDownList1.SelectedItem.Value == "4")
            {
                Label1.Text = "İyi Akşamlar";
            }
            else
            {
                Label1.Text = "";
            }
        }
    }
}