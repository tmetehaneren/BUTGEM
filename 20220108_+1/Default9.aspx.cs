using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[] sayilar = { 45, 78, 100, 20, 19, 99, 5 };
        int eb;
        int ek;
        for (int i = 0; i < sayilar.Length; i++)
        {
            DropDownList1.Items.Add(sayilar[i].ToString());
        }
        eb = sayilar[0];
        for (int i = 1; i < sayilar.Length; i++)
        {
            if (sayilar[i] > eb)
            {
                eb = sayilar[i];
            }
        }
        ek = sayilar[0];
        for (int i = 1; i < sayilar.Length; i++)
        {
            if (sayilar[i] < ek)
            {
                ek = sayilar[i];
            }
        }
        Label1.Text += eb.ToString();
        Label2.Text += ek.ToString();
    }
}