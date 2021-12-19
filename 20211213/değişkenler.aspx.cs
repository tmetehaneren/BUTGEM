using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _13122021
{
    public partial class değişkenler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 100;
            a = a + 5;
            a += 10;
            a -= 20;
            a *= 2;
            a /= 3;
            Response.Write(a);
            a++;
            Response.Write(a + "<br>");
            Response.Write((a++) + "<br>"); //değer yazdırılıp bir arttırılır
            Response.Write((++a) + "<br>");//değer arttırılı yazılır



        }
    }
}