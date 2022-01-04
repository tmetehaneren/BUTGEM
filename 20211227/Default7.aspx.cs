using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double s1, s2;
            s1 = Convert.ToDouble(TextBox1.Text);
            s2 = Convert.ToDouble(TextBox2.Text);
            if (RadioButton1.Checked)
            {
                Label3.Text = (s1 + s2).ToString();
            }
            else if (RadioButton2.Checked)
            {
                Label3.Text = (s1 - s2).ToString();
            }
            else if (RadioButton3.Checked)
            {
                Label3.Text = (s1 / s2).ToString();
            }
            else if (RadioButton4.Checked)
            {
                Label3.Text = (s1 * s2).ToString();
            }
        }
    }
}