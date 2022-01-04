using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sec = Convert.ToInt16(DropDownList1.SelectedValue);
            if (sec==16)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add  ("Osmangazi");
                ListBox1.Items.Add  ("Nilüfer");
                ListBox1.Items.Add  ("Yıldırım");
                ListBox1.Items.Add  ("Orhangazi");
            }
            else if (sec == 34)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add  ("Beşiktaş");
                ListBox1.Items.Add  ("KadıKöy");
                ListBox1.Items.Add  ("Şişli");
            }
            else if (sec == 06)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add  ("Çankaya");
                ListBox1.Items.Add  ("Kızılay");
                ListBox1.Items.Add  ("Cebeci");
            }
            else if (sec == 35)
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Çeşme");
            }
            else
            {
                ListBox1.Items.Clear();
            }
        }
    }
}