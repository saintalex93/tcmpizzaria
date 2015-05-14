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
  public  class clsFuncionarioBLL
    {
     private DAL.DAO.clsBanco ObjBanco;              

          public clsFuncionarioBLL()
            {
                ObjBanco = new clsBanco();

            }
          ~clsFuncionarioBLL()
            {
                ObjBanco = null;
            }


          public DataTable InsereFuncionario(clsFuncionario objPedido)
          {
              List<SqlParameter> LstParametros = new List<SqlParameter>();


              SqlParameter ParametroCargo = new SqlParameter();
              ParametroCargo.ParameterName = "Cargo_Funcionario";
              ParametroCargo.Value = objPedido.Cargo;
              ParametroCargo.DbType = System.Data.DbType.String;



              LstParametros.Add(ParametroCargo);
              SqlParameter ParametroNomeFuncionario = new SqlParameter();
              ParametroNomeFuncionario.ParameterName = "NOME_Funcionario";
              ParametroNomeFuncionario.Value = objPedido.Nome_Func;
              ParametroNomeFuncionario.DbType = System.Data.DbType.String;



              LstParametros.Add(ParametroNomeFuncionario);
              SqlParameter ParametroCPFFuncionario = new SqlParameter();
              ParametroCPFFuncionario.ParameterName = "CPF_Funcionario";
              ParametroCPFFuncionario.Value = objPedido.CPF_Funcionario;
              ParametroCPFFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCPFFuncionario);
              SqlParameter ParametroEnderecoFuncionario = new SqlParameter();
              ParametroEnderecoFuncionario.ParameterName = "Endereco_Funcionario";
              ParametroEnderecoFuncionario.Value = objPedido.Endereco_Funcionario;
              ParametroEnderecoFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroEnderecoFuncionario);
              SqlParameter ParametroNumeroResidencia = new SqlParameter();
              ParametroNumeroResidencia.ParameterName = "Numero_Residencia";
              ParametroNumeroResidencia.Value = objPedido.Numero_Residencia;
              ParametroNumeroResidencia.DbType = System.Data.DbType.Int32;

              LstParametros.Add(ParametroNumeroResidencia);
              SqlParameter ParametroBAIRROFuncionario = new SqlParameter();
              ParametroBAIRROFuncionario.ParameterName = "BAIRRO_Funcionario";
              ParametroBAIRROFuncionario.Value = objPedido.Bairro_Funcionario;
              ParametroBAIRROFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroBAIRROFuncionario);
              SqlParameter ParametroCepFuncionario = new SqlParameter();
              ParametroCepFuncionario.ParameterName = "Cep_Funcionario";
              ParametroCepFuncionario.Value = objPedido.CEP_Funcionario;
              ParametroCepFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCepFuncionario);
              SqlParameter ParametroESTADOFuncionario = new SqlParameter();
              ParametroESTADOFuncionario.ParameterName = "ESTADO_Funcionario";
              ParametroESTADOFuncionario.Value = objPedido.Estado_Funcionario;
              ParametroESTADOFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroESTADOFuncionario);
              SqlParameter ParametroCidadeFuncionario = new SqlParameter();
              ParametroCidadeFuncionario.ParameterName = "Cidade_Funcionario";
              ParametroCidadeFuncionario.Value = objPedido.Cidade_Funcionario;
              ParametroCidadeFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCidadeFuncionario);
              SqlParameter ParametroCOMPLEMENTOFuncionario = new SqlParameter();
              ParametroCOMPLEMENTOFuncionario.ParameterName = "COMPLEMENTO_Funcionario";
              ParametroCOMPLEMENTOFuncionario.Value = objPedido.Complemento_Funcionario;
              ParametroCOMPLEMENTOFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCOMPLEMENTOFuncionario);
              SqlParameter ParametroTELEFONEFuncionario = new SqlParameter();
              ParametroTELEFONEFuncionario.ParameterName = "TELEFONE_Funcionario";
              ParametroTELEFONEFuncionario.Value = objPedido.Telefone_Funcionario;
              ParametroTELEFONEFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroTELEFONEFuncionario);
              SqlParameter ParametroCELULARFuncionario = new SqlParameter();
              ParametroCELULARFuncionario.ParameterName = "CELULAR_Funcionario";
              ParametroCELULARFuncionario.Value = objPedido.Celular_Funcionario;
              ParametroCELULARFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCELULARFuncionario);
              SqlParameter ParametroEMAILFuncionario = new SqlParameter();
              ParametroEMAILFuncionario.ParameterName = "EMAIL_Funcionario";
              ParametroEMAILFuncionario.Value = objPedido.Email_Funcionario;
              ParametroEMAILFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroEMAILFuncionario);
              SqlParameter ParametroLoginFuncionario = new SqlParameter();
              ParametroLoginFuncionario.ParameterName = "Login_Funcionario";
              ParametroLoginFuncionario.Value = objPedido.Login_Funcionario;
              ParametroLoginFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroLoginFuncionario);
              SqlParameter ParametroSENHAFuncionario = new SqlParameter();
              ParametroSENHAFuncionario.ParameterName = "SENHA_Funcionario";
              ParametroSENHAFuncionario.Value = objPedido.Senha_Funcionario;
              ParametroSENHAFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroSENHAFuncionario);
              SqlParameter ParametroDATANASC = new SqlParameter();
              ParametroDATANASC.ParameterName = "DATA_NASC";
              ParametroDATANASC.Value = objPedido.data_Nasc;
              ParametroDATANASC.DbType = System.Data.DbType.Date;

              LstParametros.Add(ParametroDATANASC);
              SqlParameter ParametroSalario = new SqlParameter();
              ParametroSalario.ParameterName = "Salario";
              ParametroSalario.Value = objPedido.Salario;
              ParametroSalario.DbType = System.Data.DbType.Decimal;

              LstParametros.Add(ParametroSalario);
              SqlParameter ParametrocodPermissao = new SqlParameter();
              ParametrocodPermissao.ParameterName = "cod_Permissao";
              if (objPedido.Cod_Permissao < 1)
                  ParametrocodPermissao.Value = null;
              else
                  ParametrocodPermissao.Value = objPedido.Cod_Permissao;
              ParametrocodPermissao.DbType = System.Data.DbType.Int32;

              LstParametros.Add(ParametrocodPermissao);



              DataTable dt = ObjBanco.ExecuteProc("CSP_Insere_Funcionario", LstParametros);


              return dt;
          }
          public DataTable DeleteFuncionario(clsFuncionario objPedido)
          {
              List<SqlParameter> LstParametros = new List<SqlParameter>();

              SqlParameter ParametroCodFuncionario = new SqlParameter();
              ParametroCodFuncionario.ParameterName = "cod_Func";
              ParametroCodFuncionario.Value = objPedido.Cod_Func;
              ParametroCodFuncionario.DbType = System.Data.DbType.Int32;



              LstParametros.Add(ParametroCodFuncionario);

              DataTable dt = ObjBanco.ExecuteProc("csp_Delete_Funcionario", LstParametros);


              return dt;

          }

          public DataTable SelecionaFuncionario(clsFuncionario objPedido)
          {
              List<SqlParameter> LstParametros = new List<SqlParameter>();

              SqlParameter ParametroCodFuncionario = new SqlParameter();
              ParametroCodFuncionario.ParameterName = "Cod_Funcionario";
              if (objPedido.Cod_Func > 0)
                  ParametroCodFuncionario.Value = objPedido.Cod_Func;
              else
                  ParametroCodFuncionario.Value = null;
              ParametroCodFuncionario.DbType = System.Data.DbType.Int32;



              LstParametros.Add(ParametroCodFuncionario);
              SqlParameter ParametroNomeFuncionario = new SqlParameter();
              ParametroNomeFuncionario.ParameterName = "NOME_Funcionario";
              ParametroNomeFuncionario.Value = objPedido.Nome_Func;
              ParametroNomeFuncionario.DbType = System.Data.DbType.String;



              LstParametros.Add(ParametroNomeFuncionario);
              SqlParameter ParametroCPFFuncionario = new SqlParameter();
              ParametroCPFFuncionario.ParameterName = "CPF_Funcionario";
              ParametroCPFFuncionario.Value = objPedido.CPF_Funcionario;
              ParametroCPFFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCPFFuncionario);
              SqlParameter ParametroEnderecoFuncionario = new SqlParameter();
              ParametroEnderecoFuncionario.ParameterName = "Endereco_Funcionario";
              ParametroEnderecoFuncionario.Value = objPedido.Endereco_Funcionario;
              ParametroEnderecoFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroEnderecoFuncionario);
              SqlParameter ParametroNumeroResidencia = new SqlParameter();
              ParametroNumeroResidencia.ParameterName = "Numero_Residencia";
              ParametroNumeroResidencia.Value = objPedido.Numero_Residencia;
              ParametroNumeroResidencia.DbType = System.Data.DbType.Int32;

              LstParametros.Add(ParametroNumeroResidencia);
              SqlParameter ParametroBAIRROFuncionario = new SqlParameter();
              ParametroBAIRROFuncionario.ParameterName = "BAIRRO_Funcionario";
              ParametroBAIRROFuncionario.Value = objPedido.Bairro_Funcionario;
              ParametroBAIRROFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroBAIRROFuncionario);
              SqlParameter ParametroCepFuncionario = new SqlParameter();
              ParametroCepFuncionario.ParameterName = "Cep_Funcionario";
              ParametroCepFuncionario.Value = objPedido.CEP_Funcionario;
              ParametroCepFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCepFuncionario);
              SqlParameter ParametroESTADOFuncionario = new SqlParameter();
              ParametroESTADOFuncionario.ParameterName = "ESTADO_Funcionario";
              ParametroESTADOFuncionario.Value = objPedido.Estado_Funcionario;
              ParametroESTADOFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroESTADOFuncionario);
              SqlParameter ParametroCidadeFuncionario = new SqlParameter();
              ParametroCidadeFuncionario.ParameterName = "Cidade_Funcionario";
              ParametroCidadeFuncionario.Value = objPedido.Cidade_Funcionario;
              ParametroCidadeFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCidadeFuncionario);
              SqlParameter ParametroCOMPLEMENTOFuncionario = new SqlParameter();
              ParametroCOMPLEMENTOFuncionario.ParameterName = "COMPLEMENTO_Funcionario";
              ParametroCOMPLEMENTOFuncionario.Value = objPedido.Complemento_Funcionario;
              ParametroCOMPLEMENTOFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCOMPLEMENTOFuncionario);
              SqlParameter ParametroTELEFONEFuncionario = new SqlParameter();
              ParametroTELEFONEFuncionario.ParameterName = "TELEFONE_Funcionario";
              ParametroTELEFONEFuncionario.Value = objPedido.Telefone_Funcionario;
              ParametroTELEFONEFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroTELEFONEFuncionario);
              SqlParameter ParametroCELULARFuncionario = new SqlParameter();
              ParametroCELULARFuncionario.ParameterName = "CELULAR_Funcionario";
              ParametroCELULARFuncionario.Value = objPedido.Celular_Funcionario;
              ParametroCELULARFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCELULARFuncionario);
              SqlParameter ParametroEMAILFuncionario = new SqlParameter();
              ParametroEMAILFuncionario.ParameterName = "EMAIL_Funcionario";
              ParametroEMAILFuncionario.Value = objPedido.Email_Funcionario;
              ParametroEMAILFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroEMAILFuncionario);
              SqlParameter ParametroLoginFuncionario = new SqlParameter();
              ParametroLoginFuncionario.ParameterName = "Login_Funcionario";
              ParametroLoginFuncionario.Value = objPedido.Login_Funcionario;
              ParametroLoginFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroLoginFuncionario);
              SqlParameter ParametroSENHAFuncionario = new SqlParameter();
              ParametroSENHAFuncionario.ParameterName = "SENHA_Funcionario";
              ParametroSENHAFuncionario.Value = objPedido.Senha_Funcionario;
              ParametroSENHAFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroSENHAFuncionario);
              SqlParameter ParametroDATANASC = new SqlParameter();
              ParametroDATANASC.ParameterName = "DATA_NASC";
              ParametroDATANASC.Value = objPedido.data_Nasc;
              ParametroDATANASC.DbType = System.Data.DbType.Date;

              LstParametros.Add(ParametroDATANASC);
              SqlParameter ParametroSalario = new SqlParameter();
              ParametroSalario.ParameterName = "Salario";
              ParametroSalario.Value = objPedido.Salario;
              ParametroSalario.DbType = System.Data.DbType.Decimal;

              LstParametros.Add(ParametroSalario);
              SqlParameter ParametrocodPermissao = new SqlParameter();
              ParametrocodPermissao.ParameterName = "cod_Permissao";
              if (objPedido.Cod_Permissao > 0)
                  ParametrocodPermissao.Value = objPedido.Cod_Permissao;
              else
                  ParametrocodPermissao.Value = null;
              ParametrocodPermissao.DbType = System.Data.DbType.Int32;

              LstParametros.Add(ParametrocodPermissao);



              DataTable dt = ObjBanco.ExecuteProc("csp_Select_Funcionario", LstParametros);


              return dt;
          }

          public DataTable UpdateFuncionario(clsFuncionario objPedido)
          {
              List<SqlParameter> LstParametros = new List<SqlParameter>();

              SqlParameter ParametroCodFuncionario = new SqlParameter();
              ParametroCodFuncionario.ParameterName = "Cod_Funcionario";
              if (objPedido.Cod_Func > 0)
                  ParametroCodFuncionario.Value = objPedido.Cod_Func;
              else
                  ParametroCodFuncionario.Value = null;
              ParametroCodFuncionario.DbType = System.Data.DbType.Int32;



              LstParametros.Add(ParametroCodFuncionario);
              SqlParameter ParametroNomeFuncionario = new SqlParameter();
              ParametroNomeFuncionario.ParameterName = "NOME_Funcionario";
              ParametroNomeFuncionario.Value = objPedido.Nome_Func;
              ParametroNomeFuncionario.DbType = System.Data.DbType.String;



              LstParametros.Add(ParametroNomeFuncionario);
              SqlParameter ParametroCPFFuncionario = new SqlParameter();
              ParametroCPFFuncionario.ParameterName = "CPF_Funcionario";
              ParametroCPFFuncionario.Value = objPedido.CPF_Funcionario;
              ParametroCPFFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCPFFuncionario);
              SqlParameter ParametroEnderecoFuncionario = new SqlParameter();
              ParametroEnderecoFuncionario.ParameterName = "Endereco_Funcionario";
              ParametroEnderecoFuncionario.Value = objPedido.Endereco_Funcionario;
              ParametroEnderecoFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroEnderecoFuncionario);
              SqlParameter ParametroNumeroResidencia = new SqlParameter();
              ParametroNumeroResidencia.ParameterName = "Numero_Residencia";
              ParametroNumeroResidencia.Value = objPedido.Numero_Residencia;
              ParametroNumeroResidencia.DbType = System.Data.DbType.Int32;

              LstParametros.Add(ParametroNumeroResidencia);

              SqlParameter ParametroCargoFuncionario = new SqlParameter();
              ParametroCargoFuncionario.ParameterName = "Cargo_Funcionario";
              ParametroCargoFuncionario.Value = objPedido.Cargo;
              ParametroCargoFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCargoFuncionario);
              SqlParameter ParametroBAIRROFuncionario = new SqlParameter();
              ParametroBAIRROFuncionario.ParameterName = "BAIRRO_Funcionario";
              ParametroBAIRROFuncionario.Value = objPedido.Bairro_Funcionario;
              ParametroBAIRROFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroBAIRROFuncionario);
              SqlParameter ParametroCepFuncionario = new SqlParameter();
              ParametroCepFuncionario.ParameterName = "Cep_Funcionario";
              ParametroCepFuncionario.Value = objPedido.CEP_Funcionario;
              ParametroCepFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCepFuncionario);
              SqlParameter ParametroESTADOFuncionario = new SqlParameter();
              ParametroESTADOFuncionario.ParameterName = "ESTADO_Funcionario";
              ParametroESTADOFuncionario.Value = objPedido.Estado_Funcionario;
              ParametroESTADOFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroESTADOFuncionario);
              SqlParameter ParametroCidadeFuncionario = new SqlParameter();
              ParametroCidadeFuncionario.ParameterName = "Cidade_Funcionario";
              ParametroCidadeFuncionario.Value = objPedido.Cidade_Funcionario;
              ParametroCidadeFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCidadeFuncionario);
              SqlParameter ParametroCOMPLEMENTOFuncionario = new SqlParameter();
              ParametroCOMPLEMENTOFuncionario.ParameterName = "COMPLEMENTO_Funcionario";
              ParametroCOMPLEMENTOFuncionario.Value = objPedido.Complemento_Funcionario;
              ParametroCOMPLEMENTOFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCOMPLEMENTOFuncionario);
              SqlParameter ParametroTELEFONEFuncionario = new SqlParameter();
              ParametroTELEFONEFuncionario.ParameterName = "TELEFONE_Funcionario";
              ParametroTELEFONEFuncionario.Value = objPedido.Telefone_Funcionario;
              ParametroTELEFONEFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroTELEFONEFuncionario);
              SqlParameter ParametroCELULARFuncionario = new SqlParameter();
              ParametroCELULARFuncionario.ParameterName = "CELULAR_Funcionario";
              ParametroCELULARFuncionario.Value = objPedido.Celular_Funcionario;
              ParametroCELULARFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroCELULARFuncionario);
              SqlParameter ParametroEMAILFuncionario = new SqlParameter();
              ParametroEMAILFuncionario.ParameterName = "EMAIL_Funcionario";
              ParametroEMAILFuncionario.Value = objPedido.Email_Funcionario;
              ParametroEMAILFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroEMAILFuncionario);
              SqlParameter ParametroLoginFuncionario = new SqlParameter();
              ParametroLoginFuncionario.ParameterName = "Login_Funcionario";
              ParametroLoginFuncionario.Value = objPedido.Login_Funcionario;
              ParametroLoginFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroLoginFuncionario);
              SqlParameter ParametroSENHAFuncionario = new SqlParameter();
              ParametroSENHAFuncionario.ParameterName = "SENHA_Funcionario";
              ParametroSENHAFuncionario.Value = objPedido.Senha_Funcionario;
              ParametroSENHAFuncionario.DbType = System.Data.DbType.String;

              LstParametros.Add(ParametroSENHAFuncionario);
              SqlParameter ParametroDATANASC = new SqlParameter();
              ParametroDATANASC.ParameterName = "DATA_NASC";
              ParametroDATANASC.Value = objPedido.data_Nasc;
              ParametroDATANASC.DbType = System.Data.DbType.Date;

              LstParametros.Add(ParametroDATANASC);
              SqlParameter ParametroSalario = new SqlParameter();
              ParametroSalario.ParameterName = "Salario";
              ParametroSalario.Value = objPedido.Salario;
              ParametroSalario.DbType = System.Data.DbType.Decimal;

              LstParametros.Add(ParametroSalario);
              SqlParameter ParametrocodPermissao = new SqlParameter();
              ParametrocodPermissao.ParameterName = "cod_Permissao";
              if (objPedido.Cod_Permissao > 0)
                  ParametrocodPermissao.Value = objPedido.Cod_Permissao;
              else
                  ParametrocodPermissao.Value = null;
              ParametrocodPermissao.DbType = System.Data.DbType.Int32;

              LstParametros.Add(ParametrocodPermissao);



              DataTable dt = ObjBanco.ExecuteProc("CSP_Update_Funcionario", LstParametros);


              return dt;
          }

          public DataTable SelecionaCargo(clsFuncionario objPedido)
          {
              List<SqlParameter> LstParametros = new List<SqlParameter>();


              SqlParameter Parametroteste = new SqlParameter();
              Parametroteste.ParameterName = "teste";
              Parametroteste.Value = 0;
              Parametroteste.DbType = System.Data.DbType.Int32;


              LstParametros.Add(Parametroteste);
       

              DataTable dt = ObjBanco.ExecuteProc("CSP_Seleciona_Cargo", LstParametros);


              return dt;
          }

    }
}
