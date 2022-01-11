using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 1; i < 11; i++)
        {
            Response.Write(i + "x 1 =" + (i * 1) + "<br>");

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                Response.Write(i + " x " + j + " = " + (i * j) + "<br>");
            }
            Response.Write("******* <br>");
        }
    }
}