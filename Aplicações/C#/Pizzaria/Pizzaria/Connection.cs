using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Pizzaria
{
    class Connection
    {

        int nivelgeral = 0;

        public Boolean Permisso(string usuario, string senha)
        {

            int nivel = 0;


            try
            {
                string conexao = "";

                //      conexao = Rede.DataContainer.conexaoGlobal;
                conexao = Acesso.Conexao;

                SqlConnection conn = new SqlConnection(conexao);
                string strIncluir = "select Cod_Func_Perm, Login_, senha from FuncPermissao where Login_= '" + usuario + "' and Senha= '" + senha + "'";
                conn.Open();
                SqlCommand sqlComm = new SqlCommand(strIncluir, conn);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = sqlComm;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][1].ToString() == usuario)
                    {
                        if (dt.Rows[0][2].ToString() == senha)
                        {
                            switch (dt.Rows[0][0].ToString())
                            {
                                case "1":
                                    nivelgeral = 1;

                                    Acesso.PermissAcesso = 1;
                                    return true;


                                    break;
                                case "2":
                                    nivelgeral = 2;
                                    Acesso.PermissAcesso = 2;
                                    return true;

                                    break;
                                case "3":

                                    Acesso.PermissAcesso = 3;
                                    return true;

                                    break;

                                default:

                                    nivelgeral = 0;
                                    Acesso.PermissAcesso = 0;
                                    return false;
                                    break;
                            }

                        }

                    }
                }
            }

            catch (Exception ex)
            {

            }

            return false;


        }

    }
}