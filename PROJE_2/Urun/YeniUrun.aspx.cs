using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Urun
{
    public partial class YenıUrun : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)              // formun ilk yüklediği haline geri dönmemesi bizim yaptığımıza dönmesi için
            {

          
            var ktgr = (from x in db.CATEGORIES
                        select new
                        {
                            x.KATEGORIID,
                            x.KATEGORIAD
                        }).ToList();

            DropDownList1.DataTextField = "KATEGORIAD";
            DropDownList1.DataValueField = "KATEGORIID";
            DropDownList1.DataSource = ktgr;
            DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            URUNLER t = new URUNLER();
            t.URUNAD = TxtAd.Text;
            t.URUNMARKA = TxtMarka.Text;
            t.URUNKATEGORI = int.Parse( DropDownList1.SelectedValue);
            t.URUNFIYAT = decimal.Parse( TxtFiyat.Text);
            t.URUNSTOK = int.Parse( TxtStok.Text);
            string fpath = null;
            if (FileUpload1.HasFile)
            {
                FileInfo dosyaBilgisi = new FileInfo(FileUpload1.FileName);
                fpath = Guid.NewGuid().ToString() + dosyaBilgisi.Extension;
                FileUpload1.SaveAs(Server.MapPath("/Resimler/") + fpath);
                t.RESIM = fpath;
            }
            db.URUNLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");



        }
    }
}