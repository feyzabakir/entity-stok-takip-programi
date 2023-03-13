using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun = db.URUNLER.Find(id);
            urun.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}