using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //int[,] my = new int[4,3];
        //my [0, 0] = 10;
        //my [0, 1] = 20;
        //my [0, 2] = 30;

        //my [1, 0] = 11;
        //my [1, 1] = 22;
        //my [1, 2] = 33;

        //my [2, 0] = 100;
        //my [2, 1] = 200;
        //my [2, 2] = 300;

        //my [3, 0] = 111;
        //my [3, 1] = 222;
        //my [3, 2] = 333;

        int[,] dizim = new int[3, 2];
        Random random = new Random();
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                dizim[i, j] = random.Next(50, 150);
                DropDownList1.Items.Add(i + ".satır " + j + ". sütun " + dizim[i, j].ToString());

            }
        }
        tbl.InnerHtml = "<table><thead><td></td><td>Sütun Not</td><td>Sütun No</td></thead>";
        for(int i = 0; i < 3;i++)
        {
            tbl.InnerHtml += "<tr><td>Satır No</td><td> " + dizim[i, 0] + "</td><td>" + dizim[i, 1] + "</td></tr>";
        }
        tbl.InnerHtml += "</table>";
    }
}