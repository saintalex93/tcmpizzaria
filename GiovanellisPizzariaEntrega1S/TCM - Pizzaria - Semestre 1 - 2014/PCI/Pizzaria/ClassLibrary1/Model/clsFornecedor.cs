using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsFornecedor
    {
        public int Cod_Fornecedor { get; set; }
        public string CNPJ_CPF { get; set; }
        public string Razao_Social { get; set; }
        public string Nome_Fantasia { get; set; }
        public string Nome_Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta_Corrente { get; set; }
        public string Responsavel { get; set; }
        public string Celular_Responsavel { get; set; }
        public string Email_Responsavel { get; set; }
        public string Telefone_Comercial { get; set; }
        public string Endereco_Fornecedor { get; set; }
        public int Numero_Residencia { get; set; }
        public string CEP_Fornecedor { get; set; }
        public string Estado_Fornecedor { get; set; }
        public string Cidade_Fornecedor { get; set; }
        public string Bairro_Fornecedor { get; set; }
        public string Complemento { get; set; }
    }
}
