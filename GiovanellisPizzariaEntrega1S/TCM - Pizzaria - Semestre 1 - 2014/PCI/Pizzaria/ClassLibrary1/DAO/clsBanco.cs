using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Import das DLL utilizadas para conexão com banco de dados
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.DAO
{
    public class clsBanco
    {
        private SqlConnection GerarConexao()
        {
            try
            {
                string strConn = ConfigurationManager.ConnectionStrings["CONEXAO"].ConnectionString;

                if (!string.IsNullOrEmpty(strConn))
                {
                    SqlConnection conexao = new SqlConnection(strConn);
                    return conexao;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SqlConnection AbrirConexão()
        {
            SqlConnection cn = GerarConexao();

            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FecharConexao(SqlConnection cn)
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteProc(string strNomeProc, List<SqlParameter> lstParametros)
        {
            try
            {
                DataTable dtDados = new DataTable();

                using (SqlConnection sqlConexao = AbrirConexão())
                {
                    using (SqlCommand sqlComando = new SqlCommand(strNomeProc, sqlConexao))
                    {
                        sqlComando.CommandType = CommandType.StoredProcedure;

                        if (lstParametros != null)
                        {
                            sqlComando.Parameters.AddRange(lstParametros.ToArray());
                        }

                        using (SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando))
                        {
                            sqlAdaptador.Fill(dtDados);
                        }
                    }
                    return dtDados;
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteProc(string strComando)
        {
            try
            {
                DataTable dtDados = new DataTable();
                using (SqlConnection sqlConexao = AbrirConexão())
                {
                    using (SqlCommand sqlComando = new SqlCommand(strComando, sqlConexao))
                    {
                        sqlComando.CommandType = CommandType.Text;


                        if (strComando != null)
                        {
                            sqlComando.CommandText = strComando;
                        }

                        using (SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando))
                        {
                            sqlAdaptador.Fill(dtDados);
                        }
                    }
                    return dtDados;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteProc(string strNomeProc, SqlParameter parametro)
        {
            try
            {
                DataTable dtDados = new DataTable();

                using (SqlConnection sqlConexao = AbrirConexão())
                {
                    using (SqlCommand sqlComando = new SqlCommand(strNomeProc, sqlConexao))
                    {
                        sqlComando.CommandType = CommandType.StoredProcedure;

                        if (parametro != null)
                        {
                            sqlComando.Parameters.Add(parametro);
                        }

                        using (SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando))
                        {
                            sqlAdaptador.Fill(dtDados);
                        }
                    }
                    return dtDados;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
