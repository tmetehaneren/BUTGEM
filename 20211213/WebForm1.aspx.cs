using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _13122021
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //değer atamalarını izlemek için
            int sayi;
            string isim;
           sayi = 100;
            sayi = sayi + 100;
            isim = "Mete";
            isim = "Talha";
            Response.Write(sayi);
            Response.Write("<br>"+isim);
        }
    }
}