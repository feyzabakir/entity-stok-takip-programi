using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;
namespace PROJE_2
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                TxtID.Text = id.ToString();         // ID değerini taşıyoruz
                var ktgr = db.CATEGORIES.Find(id);
                TxtAd.Text = ktgr.KATEGORIAD;      // kategori adını yazdırıyoruz
            }
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.CATEGORIES.Find(id);
            ktgr.KATEGORIAD = TxtAd.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}