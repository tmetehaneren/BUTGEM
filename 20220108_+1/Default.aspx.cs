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
        Response.Write("DöngüBaşı<br>");
        for (int i = 0; i < 6; i++)
        {
            Response.Write("BUTGEM<br>");
        }
        Response.Write("DöngüBitti<br>");
    }
}