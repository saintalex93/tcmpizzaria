using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;

public partial class aspx_pedir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null)
        {
            Response.Write("<script>alert('Você deve estar logado para acessar esta página.')</script>");
            Response.Write("<script>history.go(-1)</script>");
        }
    }
}