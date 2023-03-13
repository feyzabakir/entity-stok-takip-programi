using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJE_2.Entity;
namespace PROJE_2
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        PROJE2Entities1 db = new PROJE2Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.CATEGORIES.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();

        }
    }
}