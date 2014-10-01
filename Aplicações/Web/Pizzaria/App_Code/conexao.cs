using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for conexao
/// </summary>
public class conexao
{
	public conexao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public SqlConnection Conexao;
    public SqlCommand command;

    string strConexao = "Server=localhost;DataBase=Pizzaria;user id=SA;password=123456";


    public void conectar()
    {

        Conexao = new SqlConnection(strConexao);
        Conexao.Open();
        command = new SqlCommand();
        command.Connection = Conexao;

    }

    public void fechaConexao()
    {
        Conexao.Close();
        Conexao = null;
        command = null;
    }
    
}