using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAL.Model;
using DAL.DAO;

namespace BLL
{
    public class clsLoginBLL
    {
        private DAL.DAO.clsBanco Banco;
        public clsLoginBLL()
        {
            Banco = new clsBanco();

        }

        ~clsLoginBLL()
        {
            Banco = null;
        }

        public DataTable ValidarUsuario(clsFuncionario objFuncionario) 
        {
            List<SqlParameter> lista = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@Login";
            parametro.Value = objFuncionario.Login_Funcionario;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            parametro = new SqlParameter();
            parametro.ParameterName = "@Senha";
            parametro.Value = objFuncionario.Senha_Funcionario;
            parametro.DbType = System.Data.DbType.String;

            lista.Add(parametro);

            return Banco.ExecuteProc("USP_CSharp_Login_ValidarUsuario", lista);
        }

    }
}