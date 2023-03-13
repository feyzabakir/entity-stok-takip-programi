using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;
namespace PROJE_2
{
    public partial class KategoriSilaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PROJE2Entities1 db = new PROJE2Entities1();
            int x = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var p = db.CATEGORIES.Find(x);
            db.CATEGORIES.Remove(p);   // kaldır
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");

        }
    }
}