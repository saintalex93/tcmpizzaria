using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class aspx_modelo : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["funcionario"] != null)
        {
            pnlLogout.Visible = true;
            string funcionario = Session["funcionario"].ToString();
            string[] infoFuncionario = funcionario.Split('/');
            lblNomeFunc.Text = infoFuncionario[1];
            pnlLogin.Visible = false;
        }
        else
        {
            Response.Redirect(Request.ApplicationPath + "/index.aspx");
        }
    }

    protected void Logout(object sender, EventArgs e)
    {
        Session["funcionario"] = null;
        pnlLogout.Visible = false;
        pnlLogin.Visible = true;
        Response.Redirect(Request.ApplicationPath + "/index.aspx");
    }
}
