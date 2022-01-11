using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int[] sayilar = { 10, 40, 50, 100, 20, 90, 70, 80, 40, 60, };
        int eb, ek, tmp;

        for (int i = 0; i < sayilar.Length; i++)
        {
            DropDownList1.Items.Add(sayilar[i].ToString());
        }
        eb = sayilar[0];
        ek= sayilar[0];
        for (int i = 1; i< sayilar.Length; i++)
        {
            if (sayilar[i] > eb)
            {
                eb = sayilar[i];
            }
            if (sayilar[i] < ek)
            {
                ek = sayilar[i];
            }

        }
        Label1.Text += eb.ToString();
        Label2.Text += ek.ToString();

        for (int i = 0; i < sayilar.Length-1; i++)
        {
            for (int j = i+1; j < sayilar.Length; j++)
            {
                if(sayilar[i] > sayilar[j])
                {
                    tmp = sayilar[i];
                    sayilar[i] = sayilar[j];
                    sayilar[j] = tmp;
                }
            }
        }     
        for (int i = 0; i< sayilar.Length; i++)
        {
            DropDownList2.Items.Add(sayilar[i].ToString());
        }
    } 
}