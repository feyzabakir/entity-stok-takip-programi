using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.MUSTERILER.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MUSTERILER t = new MUSTERILER();
            t.MUSTERIAD = TextBox1.Text;
            t.MUSTERISOYAD = TextBox2.Text;
            db.MUSTERILER.Add(t);
            db.SaveChanges();
        }

    }
}