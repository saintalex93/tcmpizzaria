<%@ Page Language="C#" Debug="true" %>
<%@ import Namespace="System.IO"%>
<%@ import Namespace="System.Data"%>
<%@ import Namespace="System.Data.SqlClient"%>

<script runat="server">

	public void Page_Load()
	{
		int Cod_Pedido = int.Parse((Request.QueryString["Cod_Pedido"]));
		
		//string casa
		//String strConexao = "Password=peganomeupau; Persist Security Info=True; User ID=sa; Initial Catalog=Pizzaria; Data Source=TUCA\\SQLEXPRESS";

		//string curso
		String strConexao = "Password=etesp; Persist Security Info=True; User ID=aluno; Initial Catalog=Pizzaria; Data Source=LAB02T-11";

		SqlConnection objConexao = new SqlConnection(strConexao);
		String contato = "";
		String strSQL = "EXEC USP_ANDROID_HISTORICO_SelectEstadoPedido " + Cod_Pedido;
		SqlCommand objCommand = new SqlCommand(strSQL, objConexao);
		SqlDataReader dr;
		objConexao.Open();
		dr = objCommand.ExecuteReader();
		contato = "#";
		while (dr.Read())
		{
			contato += (dr[0].ToString()) + ";";
		}
		contato+="^";
		Label1.Text = contato;
	}
</script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://ww.w3.org/TR/xhtml1/DTD/xhtml1-transitional.detd">

<html xmlns="http://www.w3.org/1999.xhtml">	
<head id = "Head1" runat = "server">
 <title>Buscar registro</title>
</head>
<body>
 <form id = "form1" runat = "server">
 <div>
	<asp:Label ID = "Label1" runat = "server"></asp:Label>
 </div>
 </form>
</body>
</html>