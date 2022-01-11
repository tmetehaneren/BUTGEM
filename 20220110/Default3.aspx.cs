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
        int[] dizi = new int[5];
        int eb, ek, tmp;

        Random r = new Random();
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = r.Next(100);
            DropDownList1.Items.Add(dizi[i].ToString());

        }
        for (int i = 0; i < dizi.Length - 1; i++)
        {
            for (int j = i + 1; j < dizi.Length; j++)
            {
                if (dizi[i] > dizi[j])
                {
                    tmp = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = tmp;
                }
            }
        }
        for (int i = 0; i < dizi.Length; i++)
        {
            DropDownList2.Items.Add(dizi[i].ToString());
        }
    }
}