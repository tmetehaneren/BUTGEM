using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int toplam = 0;
        for (int i = 70; i < 149; i++)
        
        {
            if (i % 2 == 0)
            { DropDownList1.Items.Add(Convert.ToString(i));
                toplam = toplam + i; 
            }
        }
        Label3.Text = toplam.ToString();
    }
}