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
    public class clsClienteBLL
    {
        private DAL.DAO.clsBanco ObjBanco;              
            public clsClienteBLL()
            {
                ObjBanco = new clsBanco();

            }
            ~clsClienteBLL()
            {
                ObjBanco = null;
            }


            public DataTable SelectCliente(clsCliente ObjCliente)
            {
                List<SqlParameter> LstParametros = new List<SqlParameter>();


                SqlParameter ParametroNome = new SqlParameter();
                ParametroNome.ParameterName = "NOME_CLIENTE";
                ParametroNome.Value = ObjCliente.Nome_Cliente;
                ParametroNome.DbType = System.Data.DbType.String;


                LstParametros.Add(ParametroNome);
                SqlParameter ParametroCod_Cliente = new SqlParameter();
                ParametroCod_Cliente.ParameterName = "Cod_Cliente";
                if (ObjCliente.Cod_Cliente.ToString() == "0")
                    ParametroCod_Cliente.Value = null;
                else
                    ParametroCod_Cliente.Value = ObjCliente.Nome_Cliente;
                ParametroCod_Cliente.DbType = System.Data.DbType.String;


                LstParametros.Add(ParametroCod_Cliente);
                SqlParameter ParametroCPF = new SqlParameter();
                ParametroCPF.ParameterName = "CPF_CLIENTE";
                ParametroCPF.Value = ObjCliente.Cpf_Cliente;
                ParametroCPF.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCPF);
                SqlParameter ParametroENDERECO = new SqlParameter();
                ParametroENDERECO.ParameterName = "ENDERECO_CLIENTE";
                ParametroENDERECO.Value = ObjCliente.Endereco_Cliente;
                ParametroENDERECO.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroENDERECO);
                SqlParameter ParametroNUMERO_RESIDENCIA = new SqlParameter();
                ParametroNUMERO_RESIDENCIA.ParameterName = "NUMERO_RESIDENCIA";
                if (ObjCliente.Numero_Residencia.ToString() == "0")
                    ParametroNUMERO_RESIDENCIA.Value = null;
                else
                    ParametroNUMERO_RESIDENCIA.Value = ObjCliente.Numero_Residencia;
                ParametroNUMERO_RESIDENCIA.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroNUMERO_RESIDENCIA);
                SqlParameter ParametroNUMERO_APARTAMENTO = new SqlParameter();
                ParametroNUMERO_APARTAMENTO.ParameterName = "NUMERO_APARTAMENTO";
                if (ObjCliente.Numero_Apartamento.ToString() == "0")
                    ParametroNUMERO_APARTAMENTO.Value = null;
                else
                    ParametroNUMERO_APARTAMENTO.Value = ObjCliente.Numero_Apartamento;
                ParametroNUMERO_APARTAMENTO.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroNUMERO_APARTAMENTO);
                SqlParameter ParametroBairro = new SqlParameter();
                ParametroBairro.ParameterName = "BAIRRO_CLIENTE";
                ParametroBairro.Value = ObjCliente.Bairro_Cliente;
                ParametroBairro.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroBairro);
                SqlParameter ParametroCEP = new SqlParameter();
                ParametroCEP.ParameterName = "CEP_CLIENTE";
                ParametroCEP.Value = ObjCliente.Cep_Cliente;
                ParametroCEP.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCEP);
                SqlParameter ParametroESTADO_CLIENTE = new SqlParameter();
                ParametroESTADO_CLIENTE.ParameterName = "ESTADO_CLIENTE";
                ParametroESTADO_CLIENTE.Value = ObjCliente.Estado_Cliente;
                ParametroESTADO_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroESTADO_CLIENTE);
                SqlParameter ParametroCIDADE_CLIENTE = new SqlParameter();
                ParametroCIDADE_CLIENTE.ParameterName = "CIDADE_CLIENTE";
                ParametroCIDADE_CLIENTE.Value = ObjCliente.Cidade_Cliente;
                ParametroCIDADE_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCIDADE_CLIENTE);
                SqlParameter ParametroCOMPLEMENTO_CLIENTE = new SqlParameter();
                ParametroCOMPLEMENTO_CLIENTE.ParameterName = "COMPLEMENTO_CLIENTE";
                ParametroCOMPLEMENTO_CLIENTE.Value = ObjCliente.Complemento_Cliente;
                ParametroCOMPLEMENTO_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCOMPLEMENTO_CLIENTE);
                SqlParameter ParametroTELEFONE_CLIENTE = new SqlParameter();
                ParametroTELEFONE_CLIENTE.ParameterName = "TELEFONE_CLIENTE";
                ParametroTELEFONE_CLIENTE.Value = ObjCliente.Telefone_Cliente;
                ParametroTELEFONE_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroTELEFONE_CLIENTE);
                SqlParameter ParametroCELULAR_CLIENTE = new SqlParameter();
                ParametroCELULAR_CLIENTE.ParameterName = "CELULAR_CLIENTE";
                ParametroCELULAR_CLIENTE.Value = ObjCliente.Celular_Cliente;
                ParametroCELULAR_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCELULAR_CLIENTE);
                SqlParameter ParametroLogin_CLIENTE = new SqlParameter();
                ParametroLogin_CLIENTE.ParameterName = "Login_Cliente ";
                ParametroLogin_CLIENTE.Value = ObjCliente.Email_Cliente;
                ParametroLogin_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroLogin_CLIENTE);
                SqlParameter ParametroSENHA_CLIENTE = new SqlParameter();
                ParametroSENHA_CLIENTE.ParameterName = "SENHA_CLIENTE";
                ParametroSENHA_CLIENTE.Value = ObjCliente.Senha_Cliente;
                ParametroSENHA_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroSENHA_CLIENTE);
                SqlParameter ParametroDATA_NASCIMENTO = new SqlParameter();
                ParametroDATA_NASCIMENTO.ParameterName = "DataNascimento ";
                ParametroDATA_NASCIMENTO.Value = ObjCliente.DataNascimento;
                ParametroDATA_NASCIMENTO.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroDATA_NASCIMENTO);
                SqlParameter ParametroDataCadastro = new SqlParameter();
                ParametroDataCadastro.ParameterName = "DataCadastro";
                ParametroDataCadastro.Value = ObjCliente.DataCadastro;
                ParametroDataCadastro.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroDataCadastro);
                DataTable dt = ObjBanco.ExecuteProc("CSP_Seleciona_Cliente", LstParametros);


                return dt;
            }


            public DataTable AtualizaCliente(clsCliente ObjCliente)
            {
                List<SqlParameter> LstParametros = new List<SqlParameter>();


                SqlParameter ParametroNome = new SqlParameter();
                ParametroNome.ParameterName = "NOME_CLIENTE";
                ParametroNome.Value = ObjCliente.Nome_Cliente;
                ParametroNome.DbType = System.Data.DbType.String;


                LstParametros.Add(ParametroNome);
                SqlParameter ParametroCod_Cliente = new SqlParameter();
                ParametroCod_Cliente.ParameterName = "Cod_Cliente";
                if (ObjCliente.Cod_Cliente.ToString() == "0")
                    ParametroCod_Cliente.Value = null;
                else
                    ParametroCod_Cliente.Value = ObjCliente.Cod_Cliente;
                ParametroCod_Cliente.DbType = System.Data.DbType.Int32;


                LstParametros.Add(ParametroCod_Cliente);
                SqlParameter ParametroCPF = new SqlParameter();
                ParametroCPF.ParameterName = "CPF_CLIENTE";
                ParametroCPF.Value = ObjCliente.Cpf_Cliente;
                ParametroCPF.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCPF);
                SqlParameter ParametroENDERECO = new SqlParameter();
                ParametroENDERECO.ParameterName = "ENDERECO_CLIENTE";
                ParametroENDERECO.Value = ObjCliente.Endereco_Cliente;
                ParametroENDERECO.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroENDERECO);
                SqlParameter ParametroNUMERO_RESIDENCIA = new SqlParameter();
                ParametroNUMERO_RESIDENCIA.ParameterName = "NUMERO_RESIDENCIA";
                if (ObjCliente.Numero_Residencia.ToString() == "0")
                    ParametroNUMERO_RESIDENCIA.Value = null;
                else
                    ParametroNUMERO_RESIDENCIA.Value = ObjCliente.Numero_Residencia;
                ParametroNUMERO_RESIDENCIA.DbType = System.Data.DbType.Int32;

                LstParametros.Add(ParametroNUMERO_RESIDENCIA);
                SqlParameter ParametroNUMERO_APARTAMENTO = new SqlParameter();
                ParametroNUMERO_APARTAMENTO.ParameterName = "NUMERO_APARTAMENTO";
                if (ObjCliente.Numero_Apartamento.ToString() == "0")
                    ParametroNUMERO_APARTAMENTO.Value = null;
                else
                    ParametroNUMERO_APARTAMENTO.Value = ObjCliente.Numero_Apartamento;
                ParametroNUMERO_APARTAMENTO.DbType = System.Data.DbType.Int32;

                LstParametros.Add(ParametroNUMERO_APARTAMENTO);
                SqlParameter ParametroBairro = new SqlParameter();
                ParametroBairro.ParameterName = "BAIRRO_CLIENTE";
                ParametroBairro.Value = ObjCliente.Bairro_Cliente;
                ParametroBairro.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroBairro);
                SqlParameter ParametroCEP = new SqlParameter();
                ParametroCEP.ParameterName = "CEP_CLIENTE";
                ParametroCEP.Value = ObjCliente.Cep_Cliente;
                ParametroCEP.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCEP);
                SqlParameter ParametroESTADO_CLIENTE = new SqlParameter();
                ParametroESTADO_CLIENTE.ParameterName = "ESTADO_CLIENTE";
                ParametroESTADO_CLIENTE.Value = ObjCliente.Estado_Cliente;
                ParametroESTADO_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroESTADO_CLIENTE);
                SqlParameter ParametroCIDADE_CLIENTE = new SqlParameter();
                ParametroCIDADE_CLIENTE.ParameterName = "CIDADE_CLIENTE";
                ParametroCIDADE_CLIENTE.Value = ObjCliente.Cidade_Cliente;
                ParametroCIDADE_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCIDADE_CLIENTE);
                SqlParameter ParametroCOMPLEMENTO_CLIENTE = new SqlParameter();
                ParametroCOMPLEMENTO_CLIENTE.ParameterName = "COMPLEMENTO_CLIENTE";
                ParametroCOMPLEMENTO_CLIENTE.Value = ObjCliente.Complemento_Cliente;
                ParametroCOMPLEMENTO_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCOMPLEMENTO_CLIENTE);
                SqlParameter ParametroTELEFONE_CLIENTE = new SqlParameter();
                ParametroTELEFONE_CLIENTE.ParameterName = "TELEFONE_CLIENTE";
                ParametroTELEFONE_CLIENTE.Value = ObjCliente.Telefone_Cliente;
                ParametroTELEFONE_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroTELEFONE_CLIENTE);
                SqlParameter ParametroCELULAR_CLIENTE = new SqlParameter();
                ParametroCELULAR_CLIENTE.ParameterName = "CELULAR_CLIENTE";
                ParametroCELULAR_CLIENTE.Value = ObjCliente.Celular_Cliente;
                ParametroCELULAR_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCELULAR_CLIENTE);
                SqlParameter ParametroLogin_CLIENTE = new SqlParameter();
                ParametroLogin_CLIENTE.ParameterName = "Login_Cliente ";
                ParametroLogin_CLIENTE.Value = ObjCliente.Email_Cliente;
                ParametroLogin_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroLogin_CLIENTE);
                SqlParameter ParametroSENHA_CLIENTE = new SqlParameter();
                ParametroSENHA_CLIENTE.ParameterName = "SENHA_CLIENTE";
                ParametroSENHA_CLIENTE.Value = ObjCliente.Senha_Cliente;
                ParametroSENHA_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroSENHA_CLIENTE);
                SqlParameter ParametroDATA_NASCIMENTO = new SqlParameter();
                ParametroDATA_NASCIMENTO.ParameterName = "DataNascimento ";
                ParametroDATA_NASCIMENTO.Value = ObjCliente.DataNascimento;
                ParametroDATA_NASCIMENTO.DbType = System.Data.DbType.Date;

                LstParametros.Add(ParametroDATA_NASCIMENTO);
                SqlParameter ParametroDataCadastro = new SqlParameter();
                ParametroDataCadastro.ParameterName = "DataCadastro";
                ParametroDataCadastro.Value = ObjCliente.DataCadastro;
                ParametroDataCadastro.DbType = System.Data.DbType.Date;

                LstParametros.Add(ParametroDataCadastro);
                DataTable dt = ObjBanco.ExecuteProc("CSP_Atualiza_Cliente", LstParametros);


                return dt;
            }


            public DataTable InsereCliente(clsCliente ObjCliente)
            {
                List<SqlParameter> LstParametros = new List<SqlParameter>();


                SqlParameter ParametroNome = new SqlParameter();
                ParametroNome.ParameterName = "NOME_CLIENTE";
                ParametroNome.Value = ObjCliente.Nome_Cliente;
                ParametroNome.DbType = System.Data.DbType.String;


                LstParametros.Add(ParametroNome);
              /*  SqlParameter ParametroCod_Cliente = new SqlParameter();
                ParametroCod_Cliente.ParameterName = "Cod_Cliente";
                if (ObjCliente.Cod_Cliente.ToString() == "0")
                    ParametroCod_Cliente.Value = null;
                else
                    ParametroCod_Cliente.Value = ObjCliente.Nome_Cliente;
                ParametroCod_Cliente.DbType = System.Data.DbType.String;


                LstParametros.Add(ParametroCod_Cliente);*/
                SqlParameter ParametroCPF = new SqlParameter();
                ParametroCPF.ParameterName = "CPF_CLIENTE";
                ParametroCPF.Value = ObjCliente.Cpf_Cliente;
                ParametroCPF.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCPF);
                SqlParameter ParametroENDERECO = new SqlParameter();
                ParametroENDERECO.ParameterName = "ENDERECO_CLIENTE";
                ParametroENDERECO.Value = ObjCliente.Endereco_Cliente;
                ParametroENDERECO.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroENDERECO);
                SqlParameter ParametroNUMERO_RESIDENCIA = new SqlParameter();
                ParametroNUMERO_RESIDENCIA.ParameterName = "NUMERO_RESIDENCIA";
                if (ObjCliente.Numero_Residencia.ToString() == "0")
                    ParametroNUMERO_RESIDENCIA.Value = null;
                else
                    ParametroNUMERO_RESIDENCIA.Value = ObjCliente.Numero_Residencia;
                ParametroNUMERO_RESIDENCIA.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroNUMERO_RESIDENCIA);
                SqlParameter ParametroNUMERO_APARTAMENTO = new SqlParameter();
                ParametroNUMERO_APARTAMENTO.ParameterName = "NUMERO_APARTAMENTO";
                if (ObjCliente.Numero_Apartamento.ToString() == "0")
                    ParametroNUMERO_APARTAMENTO.Value = null;
                else
                    ParametroNUMERO_APARTAMENTO.Value = ObjCliente.Numero_Apartamento;
                ParametroNUMERO_APARTAMENTO.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroNUMERO_APARTAMENTO);
                SqlParameter ParametroBairro = new SqlParameter();
                ParametroBairro.ParameterName = "BAIRRO_CLIENTE";
                ParametroBairro.Value = ObjCliente.Bairro_Cliente;
                ParametroBairro.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroBairro);
                SqlParameter ParametroCEP = new SqlParameter();
                ParametroCEP.ParameterName = "CEP_CLIENTE";
                ParametroCEP.Value = ObjCliente.Cep_Cliente;
                ParametroCEP.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCEP);
                SqlParameter ParametroESTADO_CLIENTE = new SqlParameter();
                ParametroESTADO_CLIENTE.ParameterName = "ESTADO_CLIENTE";
                ParametroESTADO_CLIENTE.Value = ObjCliente.Estado_Cliente;
                ParametroESTADO_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroESTADO_CLIENTE);
                SqlParameter ParametroCIDADE_CLIENTE = new SqlParameter();
                ParametroCIDADE_CLIENTE.ParameterName = "CIDADE_CLIENTE";
                ParametroCIDADE_CLIENTE.Value = ObjCliente.Cidade_Cliente;
                ParametroCIDADE_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCIDADE_CLIENTE);
                SqlParameter ParametroCOMPLEMENTO_CLIENTE = new SqlParameter();
                ParametroCOMPLEMENTO_CLIENTE.ParameterName = "COMPLEMENTO_CLIENTE";
                ParametroCOMPLEMENTO_CLIENTE.Value = ObjCliente.Complemento_Cliente;
                ParametroCOMPLEMENTO_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCOMPLEMENTO_CLIENTE);
                SqlParameter ParametroTELEFONE_CLIENTE = new SqlParameter();
                ParametroTELEFONE_CLIENTE.ParameterName = "TELEFONE_CLIENTE";
                ParametroTELEFONE_CLIENTE.Value = ObjCliente.Telefone_Cliente;
                ParametroTELEFONE_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroTELEFONE_CLIENTE);
                SqlParameter ParametroCELULAR_CLIENTE = new SqlParameter();
                ParametroCELULAR_CLIENTE.ParameterName = "CELULAR_CLIENTE";
                ParametroCELULAR_CLIENTE.Value = ObjCliente.Celular_Cliente;
                ParametroCELULAR_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroCELULAR_CLIENTE);
                SqlParameter ParametroLogin_CLIENTE = new SqlParameter();
                ParametroLogin_CLIENTE.ParameterName = "Login_Cliente ";
                ParametroLogin_CLIENTE.Value = ObjCliente.Email_Cliente;
                ParametroLogin_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroLogin_CLIENTE);
                SqlParameter ParametroSENHA_CLIENTE = new SqlParameter();
                ParametroSENHA_CLIENTE.ParameterName = "SENHA_CLIENTE";
                ParametroSENHA_CLIENTE.Value = ObjCliente.Senha_Cliente;
                ParametroSENHA_CLIENTE.DbType = System.Data.DbType.String;

                LstParametros.Add(ParametroSENHA_CLIENTE);
                SqlParameter ParametroDATA_NASCIMENTO = new SqlParameter();
                ParametroDATA_NASCIMENTO.ParameterName = "DataNascimento ";
                ParametroDATA_NASCIMENTO.Value = ObjCliente.DataNascimento;
                ParametroDATA_NASCIMENTO.DbType = System.Data.DbType.Date;

                LstParametros.Add(ParametroDATA_NASCIMENTO);
                SqlParameter ParametroDataCadastro = new SqlParameter();
                ParametroDataCadastro.ParameterName = "DataCadastro";
                ParametroDataCadastro.Value = ObjCliente.DataCadastro;
                ParametroDataCadastro.DbType = System.Data.DbType.Date;

                LstParametros.Add(ParametroDataCadastro);
                DataTable dt = ObjBanco.ExecuteProc("CSP_Insere_Cliente", LstParametros);


                return dt;
            }






    }
}
