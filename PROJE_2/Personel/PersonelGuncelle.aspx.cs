using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Personel
{
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["PERSONELID"]);
                TxtID.Text = id.ToString();         // ID değerini taşıyoruz
                var p = db.PERSONELLER.Find(id);
                TxtAdSoyad.Text = p.PERSONELADSOYAD;      // kategori adını yazdırıyoruz
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["PERSONELID"]);
            var p = db.PERSONELLER.Find(id);
            p.PERSONELADSOYAD = TxtAdSoyad.Text;
            db.SaveChanges();
            Response.Redirect("Personeller.aspx");
        }
    }
}