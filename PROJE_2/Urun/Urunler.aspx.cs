using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.URUNLER.Where(x=>x.DURUM==true).ToList();
            var urunler = (from x in db.URUNLER
                           where x.DURUM == true       // ürün durumu true olanları ekranda gösterir
                            select new
                            {
                                x.URUNID,
                                x.URUNAD,
                                x.URUNMARKA,
                                x.CATEGORIES.KATEGORIAD,   // kategoriye ait adı getirir
                                x.URUNFIYAT,
                                x.URUNSTOK,

                            }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}