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
    public class clsFornecedorBLL
    {

        private DAL.DAO.clsBanco ObjBanco;    


         public clsFornecedorBLL()
            {
                ObjBanco = new clsBanco();

            }
         ~clsFornecedorBLL()
            {
                ObjBanco = null;
            }



         public DataTable SelecionaFornecedor(clsFornecedor objPedido)
         {
             List<SqlParameter> LstParametros = new List<SqlParameter>();

             SqlParameter ParametroCodFornecedor = new SqlParameter();
             ParametroCodFornecedor.ParameterName = "Cod_Fornecedor";
             if (objPedido.Cod_Fornecedor > 0)
                 ParametroCodFornecedor.Value = objPedido.Cod_Fornecedor;
             else
                 ParametroCodFornecedor.Value = null;
             ParametroCodFornecedor.DbType = System.Data.DbType.Int32;



             LstParametros.Add(ParametroCodFornecedor);
             SqlParameter ParametroCNPJ_CPF = new SqlParameter();
             ParametroCNPJ_CPF.ParameterName = "CNPJ_CPF";
             ParametroCNPJ_CPF.Value = objPedido.CNPJ_CPF;
             ParametroCNPJ_CPF.DbType = System.Data.DbType.String;



             LstParametros.Add(ParametroCNPJ_CPF);
             SqlParameter ParametroRazao_Social = new SqlParameter();
             ParametroRazao_Social.ParameterName = "Razao_Social";
             ParametroRazao_Social.Value = objPedido.Razao_Social;
             ParametroRazao_Social.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroRazao_Social);
             SqlParameter ParametroNome_Fantasia = new SqlParameter();
             ParametroNome_Fantasia.ParameterName = "Nome_Fantasia";
             ParametroNome_Fantasia.Value = objPedido.Nome_Fantasia;
             ParametroNome_Fantasia.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroNome_Fantasia);
             SqlParameter ParametroNome_Banco = new SqlParameter();
             ParametroNome_Banco.ParameterName = "Nome_Banco";
             ParametroNome_Banco.Value = objPedido.Nome_Banco;
             ParametroNome_Banco.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroNome_Banco);
             SqlParameter ParametroAgencia = new SqlParameter();
             ParametroAgencia.ParameterName = "Agencia";
             ParametroAgencia.Value = objPedido.Agencia;
             ParametroAgencia.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroAgencia);
             SqlParameter ParametroConta_Corrente = new SqlParameter();
             ParametroConta_Corrente.ParameterName = "Conta_Corrente";
             ParametroConta_Corrente.Value = objPedido.Conta_Corrente;
             ParametroConta_Corrente.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroConta_Corrente);
             SqlParameter ParametroResponsavel = new SqlParameter();
             ParametroResponsavel.ParameterName = "Responsavel";
             ParametroResponsavel.Value = objPedido.Responsavel;
             ParametroResponsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroResponsavel);
             SqlParameter ParametroCelular_Responsavel = new SqlParameter();
             ParametroCelular_Responsavel.ParameterName = "Celular_Responsavel";
             ParametroCelular_Responsavel.Value = objPedido.Celular_Responsavel;
             ParametroCelular_Responsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCelular_Responsavel);
             SqlParameter ParametroEmail_Responsavel = new SqlParameter();
             ParametroEmail_Responsavel.ParameterName = "Email_Responsavel";
             ParametroEmail_Responsavel.Value = objPedido.Email_Responsavel;
             ParametroEmail_Responsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEmail_Responsavel);
             SqlParameter ParametroTelefone_Comercial = new SqlParameter();
             ParametroTelefone_Comercial.ParameterName = "Telefone_Comercial";
             ParametroTelefone_Comercial.Value = objPedido.Telefone_Comercial;
             ParametroTelefone_Comercial.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroTelefone_Comercial);
             SqlParameter ParametroEndereco_Fornecedor = new SqlParameter();
             ParametroEndereco_Fornecedor.ParameterName = "Endereco_Fornecedor";
             ParametroEndereco_Fornecedor.Value = objPedido.Endereco_Fornecedor;
             ParametroEndereco_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEndereco_Fornecedor);
             SqlParameter ParametroNumero_Residencia = new SqlParameter();
             ParametroNumero_Residencia.ParameterName = "Numero_Residencia";
             if (objPedido.Numero_Residencia > 0)
                 ParametroNumero_Residencia.Value = objPedido.Numero_Residencia;
             else
                 ParametroNumero_Residencia.Value = null; ;
             ParametroNumero_Residencia.DbType = System.Data.DbType.Int32;

             LstParametros.Add(ParametroNumero_Residencia);
             SqlParameter ParametroCEP_Fornecedor = new SqlParameter();
             ParametroCEP_Fornecedor.ParameterName = "CEP_Fornecedor";
             ParametroCEP_Fornecedor.Value = objPedido.CEP_Fornecedor;
             ParametroCEP_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCEP_Fornecedor);
             SqlParameter ParametroEstado_Fornecedor = new SqlParameter();
             ParametroEstado_Fornecedor.ParameterName = "Estado_Fornecedor";
             ParametroEstado_Fornecedor.Value = objPedido.Estado_Fornecedor;
             ParametroEstado_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEstado_Fornecedor);
             SqlParameter ParametroCidade_FornecedorC = new SqlParameter();
             ParametroCidade_FornecedorC.ParameterName = "Cidade_Fornecedor";
             ParametroCidade_FornecedorC.Value = objPedido.Cidade_Fornecedor;
             ParametroCidade_FornecedorC.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCidade_FornecedorC);
             SqlParameter ParametroBairro_Fornecedor = new SqlParameter();
             ParametroBairro_Fornecedor.ParameterName = "Bairro_Fornecedor";
             ParametroBairro_Fornecedor.Value = objPedido.Bairro_Fornecedor;
             ParametroBairro_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroBairro_Fornecedor);
             SqlParameter ParametroComplemento = new SqlParameter();
             ParametroComplemento.ParameterName = "Complemento";
             ParametroComplemento.Value = objPedido.Complemento;
             ParametroComplemento.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroComplemento);



             DataTable dt = ObjBanco.ExecuteProc("SP_CSHARP_SELECIONA_FORNECEDOR", LstParametros);


             return dt;
         }

         public DataTable AtualizaFornecedor(clsFornecedor objPedido)
         {
             List<SqlParameter> LstParametros = new List<SqlParameter>();

             SqlParameter ParametroCodFornecedor = new SqlParameter();
             ParametroCodFornecedor.ParameterName = "Cod_Fornecedor";
             if (objPedido.Cod_Fornecedor > 0)
                 ParametroCodFornecedor.Value = objPedido.Cod_Fornecedor;
             else
                 ParametroCodFornecedor.Value = null;
             ParametroCodFornecedor.DbType = System.Data.DbType.Int32;



             LstParametros.Add(ParametroCodFornecedor);
             SqlParameter ParametroCNPJ_CPF = new SqlParameter();
             ParametroCNPJ_CPF.ParameterName = "CNPJ_CPF";
             ParametroCNPJ_CPF.Value = objPedido.CNPJ_CPF;
             ParametroCNPJ_CPF.DbType = System.Data.DbType.String;



             LstParametros.Add(ParametroCNPJ_CPF);
             SqlParameter ParametroRazao_Social = new SqlParameter();
             ParametroRazao_Social.ParameterName = "Razao_Social";
             ParametroRazao_Social.Value = objPedido.Razao_Social;
             ParametroRazao_Social.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroRazao_Social);
             SqlParameter ParametroNome_Fantasia = new SqlParameter();
             ParametroNome_Fantasia.ParameterName = "Nome_Fantasia";
             ParametroNome_Fantasia.Value = objPedido.Nome_Fantasia;
             ParametroNome_Fantasia.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroNome_Fantasia);
             SqlParameter ParametroNome_Banco = new SqlParameter();
             ParametroNome_Banco.ParameterName = "Nome_Banco";
             ParametroNome_Banco.Value = objPedido.Nome_Banco;
             ParametroNome_Banco.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroNome_Banco);
             SqlParameter ParametroAgencia = new SqlParameter();
             ParametroAgencia.ParameterName = "Agencia";
             ParametroAgencia.Value = objPedido.Agencia;
             ParametroAgencia.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroAgencia);
             SqlParameter ParametroConta_Corrente = new SqlParameter();
             ParametroConta_Corrente.ParameterName = "Conta_Corrente";
             ParametroConta_Corrente.Value = objPedido.Conta_Corrente;
             ParametroConta_Corrente.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroConta_Corrente);
             SqlParameter ParametroResponsavel = new SqlParameter();
             ParametroResponsavel.ParameterName = "Responsavel";
             ParametroResponsavel.Value = objPedido.Responsavel;
             ParametroResponsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroResponsavel);
             SqlParameter ParametroCelular_Responsavel = new SqlParameter();
             ParametroCelular_Responsavel.ParameterName = "Celular_Responsavel";
             ParametroCelular_Responsavel.Value = objPedido.Celular_Responsavel;
             ParametroCelular_Responsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCelular_Responsavel);
             SqlParameter ParametroEmail_Responsavel = new SqlParameter();
             ParametroEmail_Responsavel.ParameterName = "Email_Responsavel";
             ParametroEmail_Responsavel.Value = objPedido.Email_Responsavel;
             ParametroEmail_Responsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEmail_Responsavel);
             SqlParameter ParametroTelefone_Comercial = new SqlParameter();
             ParametroTelefone_Comercial.ParameterName = "Telefone_Comercial";
             ParametroTelefone_Comercial.Value = objPedido.Telefone_Comercial;
             ParametroTelefone_Comercial.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroTelefone_Comercial);
             SqlParameter ParametroEndereco_Fornecedor = new SqlParameter();
             ParametroEndereco_Fornecedor.ParameterName = "Endereco_Fornecedor";
             ParametroEndereco_Fornecedor.Value = objPedido.Endereco_Fornecedor;
             ParametroEndereco_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEndereco_Fornecedor);
             SqlParameter ParametroNumero_Residencia = new SqlParameter();
             ParametroNumero_Residencia.ParameterName = "Numero_Residencia";
             if (objPedido.Numero_Residencia > 0)
                 ParametroNumero_Residencia.Value = objPedido.Numero_Residencia;
             else
                 ParametroNumero_Residencia.Value = null; ;
             ParametroNumero_Residencia.DbType = System.Data.DbType.Int32;

             LstParametros.Add(ParametroNumero_Residencia);
             SqlParameter ParametroCEP_Fornecedor = new SqlParameter();
             ParametroCEP_Fornecedor.ParameterName = "CEP_Fornecedor";
             ParametroCEP_Fornecedor.Value = objPedido.CEP_Fornecedor;
             ParametroCEP_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCEP_Fornecedor);
             SqlParameter ParametroEstado_Fornecedor = new SqlParameter();
             ParametroEstado_Fornecedor.ParameterName = "Estado_Fornecedor";
             ParametroEstado_Fornecedor.Value = objPedido.Estado_Fornecedor;
             ParametroEstado_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEstado_Fornecedor);
             SqlParameter ParametroCidade_FornecedorC = new SqlParameter();
             ParametroCidade_FornecedorC.ParameterName = "Cidade_Fornecedor";
             ParametroCidade_FornecedorC.Value = objPedido.Cidade_Fornecedor;
             ParametroCidade_FornecedorC.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCidade_FornecedorC);
             SqlParameter ParametroBairro_Fornecedor = new SqlParameter();
             ParametroBairro_Fornecedor.ParameterName = "Bairro_Fornecedor";
             ParametroBairro_Fornecedor.Value = objPedido.Bairro_Fornecedor;
             ParametroBairro_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroBairro_Fornecedor);
             SqlParameter ParametroComplemento = new SqlParameter();
             ParametroComplemento.ParameterName = "Complemento";
             ParametroComplemento.Value = objPedido.Complemento;
             ParametroComplemento.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroComplemento);



             DataTable dt = ObjBanco.ExecuteProc("SP_CSHARP_Atualiza_FORNECEDOR", LstParametros);


             return dt;
         }

         public DataTable InsereFornecedor(clsFornecedor objPedido)
         {
             List<SqlParameter> LstParametros = new List<SqlParameter>();
             /*
             SqlParameter ParametroCodFornecedor = new SqlParameter();
             ParametroCodFornecedor.ParameterName = "Cod_Fornecedor";
             if (objPedido.Cod_Fornecedor > 0)
                 ParametroCodFornecedor.Value = objPedido.Cod_Fornecedor;
             else
                 ParametroCodFornecedor.Value = null;
             ParametroCodFornecedor.DbType = System.Data.DbType.Int32;
             


             LstParametros.Add(ParametroCodFornecedor);*/
             SqlParameter ParametroCNPJ_CPF = new SqlParameter();
             ParametroCNPJ_CPF.ParameterName = "CNPJ_CPF";
             ParametroCNPJ_CPF.Value = objPedido.CNPJ_CPF;
             ParametroCNPJ_CPF.DbType = System.Data.DbType.String;



             LstParametros.Add(ParametroCNPJ_CPF);
             SqlParameter ParametroRazao_Social = new SqlParameter();
             ParametroRazao_Social.ParameterName = "Razao_Social";
             ParametroRazao_Social.Value = objPedido.Razao_Social;
             ParametroRazao_Social.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroRazao_Social);
             SqlParameter ParametroNome_Fantasia = new SqlParameter();
             ParametroNome_Fantasia.ParameterName = "Nome_Fantasia";
             ParametroNome_Fantasia.Value = objPedido.Nome_Fantasia;
             ParametroNome_Fantasia.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroNome_Fantasia);
             SqlParameter ParametroNome_Banco = new SqlParameter();
             ParametroNome_Banco.ParameterName = "Nome_Banco";
             ParametroNome_Banco.Value = objPedido.Nome_Banco;
             ParametroNome_Banco.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroNome_Banco);
             SqlParameter ParametroAgencia = new SqlParameter();
             ParametroAgencia.ParameterName = "Agencia";
             ParametroAgencia.Value = objPedido.Agencia;
             ParametroAgencia.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroAgencia);
             SqlParameter ParametroConta_Corrente = new SqlParameter();
             ParametroConta_Corrente.ParameterName = "Conta_Corrente";
             ParametroConta_Corrente.Value = objPedido.Conta_Corrente;
             ParametroConta_Corrente.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroConta_Corrente);
             SqlParameter ParametroResponsavel = new SqlParameter();
             ParametroResponsavel.ParameterName = "Responsavel";
             ParametroResponsavel.Value = objPedido.Responsavel;
             ParametroResponsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroResponsavel);
             SqlParameter ParametroCelular_Responsavel = new SqlParameter();
             ParametroCelular_Responsavel.ParameterName = "Celular_Responsavel";
             ParametroCelular_Responsavel.Value = objPedido.Celular_Responsavel;
             ParametroCelular_Responsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCelular_Responsavel);
             SqlParameter ParametroEmail_Responsavel = new SqlParameter();
             ParametroEmail_Responsavel.ParameterName = "Email_Responsavel";
             ParametroEmail_Responsavel.Value = objPedido.Email_Responsavel;
             ParametroEmail_Responsavel.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEmail_Responsavel);
             SqlParameter ParametroTelefone_Comercial = new SqlParameter();
             ParametroTelefone_Comercial.ParameterName = "Telefone_Comercial";
             ParametroTelefone_Comercial.Value = objPedido.Telefone_Comercial;
             ParametroTelefone_Comercial.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroTelefone_Comercial);
             SqlParameter ParametroEndereco_Fornecedor = new SqlParameter();
             ParametroEndereco_Fornecedor.ParameterName = "Endereco_Fornecedor";
             ParametroEndereco_Fornecedor.Value = objPedido.Endereco_Fornecedor;
             ParametroEndereco_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEndereco_Fornecedor);
             SqlParameter ParametroNumero_Residencia = new SqlParameter();
             ParametroNumero_Residencia.ParameterName = "Numero_Residencia";
             if (objPedido.Numero_Residencia > 0)
                 ParametroNumero_Residencia.Value = objPedido.Numero_Residencia;
             else
                 ParametroNumero_Residencia.Value = null; ;
             ParametroNumero_Residencia.DbType = System.Data.DbType.Int32;

             LstParametros.Add(ParametroNumero_Residencia);
             SqlParameter ParametroCEP_Fornecedor = new SqlParameter();
             ParametroCEP_Fornecedor.ParameterName = "CEP_Fornecedor";
             ParametroCEP_Fornecedor.Value = objPedido.CEP_Fornecedor;
             ParametroCEP_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCEP_Fornecedor);
             SqlParameter ParametroEstado_Fornecedor = new SqlParameter();
             ParametroEstado_Fornecedor.ParameterName = "Estado_Fornecedor";
             ParametroEstado_Fornecedor.Value = objPedido.Estado_Fornecedor;
             ParametroEstado_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroEstado_Fornecedor);
             SqlParameter ParametroCidade_FornecedorC = new SqlParameter();
             ParametroCidade_FornecedorC.ParameterName = "Cidade_Fornecedor";
             ParametroCidade_FornecedorC.Value = objPedido.Cidade_Fornecedor;
             ParametroCidade_FornecedorC.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroCidade_FornecedorC);
             SqlParameter ParametroBairro_Fornecedor = new SqlParameter();
             ParametroBairro_Fornecedor.ParameterName = "Bairro_Fornecedor";
             ParametroBairro_Fornecedor.Value = objPedido.Bairro_Fornecedor;
             ParametroBairro_Fornecedor.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroBairro_Fornecedor);
             SqlParameter ParametroComplemento = new SqlParameter();
             ParametroComplemento.ParameterName = "Complemento";
             ParametroComplemento.Value = objPedido.Complemento;
             ParametroComplemento.DbType = System.Data.DbType.String;

             LstParametros.Add(ParametroComplemento);



             DataTable dt = ObjBanco.ExecuteProc("SP_CSHARP_Insere_FORNECEDOR", LstParametros);


             return dt;
         }


         public DataTable DeleteFornecedor(clsFornecedor objPedido)
         {
             List<SqlParameter> LstParametros = new List<SqlParameter>();

             SqlParameter ParametroCod_Fornecedor = new SqlParameter();
             ParametroCod_Fornecedor.ParameterName = "Cod_Fornecedor";
             ParametroCod_Fornecedor.Value = objPedido.Cod_Fornecedor;
             ParametroCod_Fornecedor.DbType = System.Data.DbType.Int32;



             LstParametros.Add(ParametroCod_Fornecedor);

             DataTable dt = ObjBanco.ExecuteProc("SP_CSHARP_Delete_Fornecedor", LstParametros);


             return dt;

         }




    }
}
