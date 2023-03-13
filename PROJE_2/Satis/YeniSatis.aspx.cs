using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.URUNLER select new { x.URUNID, x.URUNAD }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var mus = (from x in db.MUSTERILER
                           select new
                           {
                               x.MUSTERIID,
                               ADSOYAD = x.MUSTERIAD + " " + x.MUSTERISOYAD
                           }).ToList();
                DropDownList2.DataTextField = "ADSOYAD";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = mus;
                DropDownList2.DataBind();

                var per = (from x in db.PERSONELLER select new { x.PERSONELID, x.PERSONELADSOYAD }).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = per;
                DropDownList3.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SATISLAR t = new SATISLAR();
            t.MUSTERI = int.Parse(DropDownList2.SelectedValue);
            t.URUN = int.Parse( DropDownList1.SelectedValue);
            t.PERSONEL = int.Parse(DropDownList3.SelectedValue);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            db.SATISLAR.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}