using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;

namespace PROJE_2.Personel
{
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PROJE2Entities1 db = new PROJE2Entities1();
            PERSONELLER p = new PERSONELLER();
            p.PERSONELADSOYAD = TextBox1.Text;
            db.PERSONELLER.Add(p);
            db.SaveChanges();
            Response.Redirect("Personeller.aspx");
        }
    }
}