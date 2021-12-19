using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _13122021
{
    public partial class DEFAULT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int maas;
            maas = 4500;
            Response.Write("Maaş: " + maas+"<br>");
            byte yas;
            yas = 21;
            Response.Write("yas: "+yas+"<br>");
            short sayi;
            sayi = 2134;
            Response.Write("sayı: "+sayi+"<br>");
            long deger ;
            deger = 23451251;
            Response.Write("değer: "+deger+"<br>");
            char karakter;
            karakter = 'a';
            string ad ;
            ad = "BUTGEM";
            double maas1;
            maas1 = 120.52;
            float maas2;
            maas2 = 321.45F;
            bool durum;
            durum = true;
            durum = false;
            Response.Write("karakter: " + karakter);
            Response.Write("<br>ad değişkenin değeri: " + ad);
            Response.Write("<br>Yeni Maas: " + maas1);
            Response.Write("<br>Yeni Maas: " + maas2);
            Response.Write("<br>Durum Değişkeni: " + durum);
            //burası yorum satırı...
            /*fsdfasdfasdgfasdfasdgsdaf
             * asgdfs Çok satırlı yorum satırı
             */
            // Response.Write("Merhaba C#");ekrana yazı yazdırma komutu

        }
    }
}