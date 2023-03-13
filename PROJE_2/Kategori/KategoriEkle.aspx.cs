using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PROJE2Entities1 db = new PROJE2Entities1();
            CATEGORIES t = new CATEGORIES();
            t.KATEGORIAD = TextBox1.Text;
            db.CATEGORIES.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");

        }
    }
}