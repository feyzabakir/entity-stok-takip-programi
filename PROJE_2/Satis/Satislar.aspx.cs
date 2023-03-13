using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Satis
{
    public partial class Satislar : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            // var satislar = db.SATISLAR.ToList();
            var satislar = (from x in db.SATISLAR
                            select new
                            {
                                x.SATISID,
                                x.URUNLER.URUNAD,
                                x.PERSONELLER.PERSONELADSOYAD,
                                MUSTERI = x.MUSTERILER.MUSTERIAD + " " + x.MUSTERILER.MUSTERISOYAD,
                                x.FIYAT
                            }).ToList();

            Repeater1.DataSource = satislar;
            Repeater1.DataBind();
        }
    }
}