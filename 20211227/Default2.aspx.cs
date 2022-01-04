using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Burası Page Load");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kadi = TextBox1.Text;
            if ((kadi).ToUpper() == "MURAT")
                Label2.Text = "Hoşgeldin Murat";
            Response.Write("Buras if e bağlı mı?");
            
        }
    }
}