using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //int[] sayilar = new int[10];
        //for (int i = 0; i < 10; i++)
        //{
        //    sayilar[i] = i * 5;
        //    DropDownList1.Items.Add(sayilar[i].ToString());
        //}

        //string[] arabalar = { "Renault", "Mercedes", "Fiat", "BMW", "Ford" };
        //Response.Write(arabalar[2]);

        //string[] motorlar = new string[5];
        //motorlar[0] = "Ducati";

        int[] maaslar = new int[10];
        maaslar[0] = 4250;
        maaslar[1] = 4255;
        maaslar[2] = 4299;
        maaslar[3] = 4300;
        maaslar[4] = 4350;
        for (int i = 0; i < maaslar.Length ; i++)
        {
            Response.Write(i + ". maaş " + maaslar[i].ToString() + "<br>");
        }
    }
}