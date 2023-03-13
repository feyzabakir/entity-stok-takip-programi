using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.LinqKart
{
    public partial class İstatistik : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.URUNLER.Count().ToString();                // ürün sayısı
            Label2.Text = db.MUSTERILER.Count().ToString();             // müsteri sayısı
            Label3.Text = db.SATISLAR.Sum(x => x.FIYAT).ToString();     // tutar
            Label4.Text = db.CATEGORIES.Count().ToString();             // kategori sayısı
            Label5.Text = db.URUNLER.Count(x => x.DURUM == true).ToString();   // aktif ürün
            Label6.Text = db.URUNLER.Count(x => x.DURUM == false).ToString();  // pasif ürün
            Label7.Text = (from x in db.URUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();   // en fazla stoklu

            // en fazla kategori
            var kate = (from x in db.URUNLER 
                        join y in db.CATEGORIES 
                        on x.URUNKATEGORI equals y.KATEGORIID 
                        group x by y into z orderby z.Count() descending select z.Key.KATEGORIAD).FirstOrDefault();

            Label8.Text = kate.ToString();
        }
    }
}