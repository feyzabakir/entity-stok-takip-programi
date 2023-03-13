using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
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


                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var urn = db.URUNLER.Find(id);
                TxtAd.Text = urn.URUNAD;
                TxtStok.Text = urn.URUNSTOK.ToString();
                TxtMarka.Text = urn.URUNMARKA;
                TxtFiyat.Text = urn.URUNFIYAT.ToString();

                DropDownList1.SelectedValue = urn.URUNKATEGORI.ToString();     // güncelleye tıklandığında hangi kategoriye ait olduğunu getiriyor 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var p = db.URUNLER.Find(id);
            p.URUNAD = TxtAd.Text;
            p.URUNSTOK = int.Parse( TxtStok.Text);
            p.URUNMARKA = TxtMarka.Text;
            p.URUNFIYAT = decimal.Parse(TxtFiyat.Text);
            string fpath = null;
            if (FileUpload1.HasFile)
            {
                FileInfo dosyaBilgisi = new FileInfo(FileUpload1.FileName);
                fpath = Guid.NewGuid().ToString() + dosyaBilgisi.Extension;
                FileUpload1.SaveAs(Server.MapPath("/Resimler/") + fpath);
                p.RESIM = fpath;
            }
            p.URUNKATEGORI = int.Parse( DropDownList1.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}