using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt16(TextBox1.Text) % 2 == 0)

            Label1.Text = "Sayi Çifttir";
        else
            Label1.Text = "Sayı Tektir ";
        
    }
}