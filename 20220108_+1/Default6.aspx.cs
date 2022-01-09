using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        ListBox1.Items.Clear();
        for (int i = 0; i < 11; i++)

        {

            {
                ListBox1.Items.Add(Convert.ToString(i));
            }
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox2.Items.Clear();
        int carpim ;
        for (int i = 0; i < 11; i++)

        {
            {
                carpim = i * i;
                ListBox2.Items.Add(Convert.ToString(carpim));
               
            }
        }
    }
}