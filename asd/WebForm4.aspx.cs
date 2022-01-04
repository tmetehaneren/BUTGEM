using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue=="1")
            {
                PnlKare.Visible = true;
                PnlDaire.Visible = false;
                PnlUcgen.Visible = false;

            }
            else if (DropDownList1.SelectedValue == "2")
            {
                PnlUcgen.Visible = true;
                PnlKare.Visible = false;
                PnlDaire.Visible = false;
            }
            else if (DropDownList1.SelectedValue == "3")
            {
                PnlDaire.Visible = true;
                PnlKare.Visible = false;
                PnlUcgen.Visible = false;
            }
            else
            {
                PnlDaire.Visible = false;
                PnlKare.Visible = false;
                PnlUcgen.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LblSonuc.Text = (Convert.ToInt16(TextBox1.Text) * Convert.ToInt16(TextBox1.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LblSonuc.Text = (Convert.ToInt16(TextBox2.Text) * Convert.ToInt16(TextBox3.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {  
            LblSonuc.Text = (Convert.ToDouble(TextBox4.Text) * 3.14).ToString();
        }
    }
}