using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for conexao
/// </summary>
public class Conexao
{
    public Conexao()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection conexao;
    public SqlCommand command;

    string strConexao = "Server=localhost;DataBase=Pizzaria;user id=SA;password=123456";
    //string strConexao = "Server=localhost;DataBase=Pizzaria;user id=aluno;password=etesp";

    public void conectar()
    {
        conexao = new SqlConnection(strConexao);
        conexao.Open();
        command = new SqlCommand();
        command.Connection = conexao;
    }

    public void fechaConexao()
    {
        conexao.Close();
        conexao = null;
        command = null;
    }

}