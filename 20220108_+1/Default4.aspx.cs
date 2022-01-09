using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        for (int i = 1; i < 121; i++)
        {
            if (i%2!=0)
            DropDownList1.Items.Add(Convert.ToString(i));
        }
    }
}