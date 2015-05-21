using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class clsCliente
    {
            public int Cod_Cliente {get; set; }
            public string Nome_Cliente { get; set; }
            public string Cpf_Cliente { get; set; }
            public string Endereco_Cliente { get; set; }
            public int Numero_Residencia { get; set; }
            public int Numero_Apartamento { get; set; }
            public string Bairro_Cliente { get; set; }
            public string Cep_Cliente { get; set; }
            public string Estado_Cliente { get; set; }
            public string Cidade_Cliente { get; set; }
            public string Complemento_Cliente { get; set; }
            public string Telefone_Cliente { get; set; }
            public string Celular_Cliente { get; set; }
            public string Email_Cliente { get; set; }
            public string Senha_Cliente { get; set; }
            public string DataNascimento { get; set; }
            public string DataCadastro { get; set; }
    }
}
