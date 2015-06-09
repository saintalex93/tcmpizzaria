using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_modelo_painel : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null)
        {
            string admin = Session["admin"].ToString();
            string[] nomeAdm = admin.Split('/');
            lblNome.Text = nomeAdm[1];
        }
    }

    protected void Logout(object sender, EventArgs e)
    {
        Session["admin"] = null;
        Response.Redirect("index.aspx");
    }
}
