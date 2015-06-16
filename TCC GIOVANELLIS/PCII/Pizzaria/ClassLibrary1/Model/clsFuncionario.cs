using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsFuncionario
    {

        public int Cod_Func { get; set; }
        public string Nome_Func { get; set; }
        public string CPF_Funcionario { get; set; }
        public string Endereco_Funcionario { get; set; }
        public string Complemento_Funcionario { get; set; }
        public string Numero_Residencia { get; set; }
        public string CEP_Funcionario { get; set; }
        public string Estado_Funcionario { get; set; }
        public string Cidade_Funcionario { get; set; }
        public string Bairro_Funcionario { get; set; }
        public string Email_Funcionario { get; set; }
        public string Celular_Funcionario { get; set; }
        public string Telefone_Funcionario { get; set; }
        public string Login_Funcionario { get; set; }
        public string Senha_Funcionario { get; set; }
        public string Salario { get; set; }
        public int Cod_Permissao { get; set; }
        public string data_Nasc { get; set; }
        public string Cargo { get; set; }
    }
}
