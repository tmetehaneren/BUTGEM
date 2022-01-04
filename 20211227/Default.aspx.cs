using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Ekrana yazı yazdırma");
            int sayi;
            sayi = 100;
            sayi++;
            if (sayi==100)
                Response.Write("Sayı 100 dür");
            
        }
    }
}