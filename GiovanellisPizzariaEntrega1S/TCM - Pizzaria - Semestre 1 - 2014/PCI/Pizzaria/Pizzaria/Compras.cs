using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DAL.DAO;
using DAL.Model;

namespace Pizzaria
{
    public partial class Compras : Form
    {
        public Form FormHome { get; set; }

        clsComprasBLL compras = new clsComprasBLL();

        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            gridFornecedores.DataSource = compras.SelectFornecedores();

            groupCompras.Enabled        = false;
            groupDetalhes.Enabled       = false;
        }

        bool ValidarData()
        {
            if (dtCompra.Value > DateTime.Today.AddDays(1))
            {
                Home.mensagemDeErro("Não é permitido adicionar uma data futura.", "Valor não válido");

                return false;
            }

            return true;
        }

        bool ValidarNovaCompra()
        {
            if (!ValidarData())
                return false;

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtPalavraChave_TextChanged(object sender, EventArgs e)
        {
            if (txtPalavraChave.Text.Length == 0)
                gridFornecedores.DataSource = compras.SelectFornecedores();
            else
            {
                clsFornecedor objFornecedor = new clsFornecedor();
                objFornecedor.Nome_Fantasia = txtPalavraChave.Text;

                gridFornecedores.DataSource = compras.BuscarFornecedoresPorPalavraChave(objFornecedor);
            }

            gridCompras.DataSource = null;
            gridInsumos.DataSource = null;

            groupDetalhes.Enabled = false;
            groupCompras.Enabled = false;
        }

        private void txtIDFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtIDFornecedor.Text.Length == 0)
                gridFornecedores.DataSource = compras.SelectFornecedores();
            else
            {
                clsFornecedor objFornecedor = new clsFornecedor();
                objFornecedor.Cod_Fornecedor = Int32.Parse(txtIDFornecedor.Text);

                gridFornecedores.DataSource = compras.BuscarFornecedoresPorID(objFornecedor);
            }

            gridCompras.DataSource = null;
            gridInsumos.DataSource = null;

            groupDetalhes.Enabled = false;
            groupCompras.Enabled = false;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormHome.Visible = true;

            Dispose();
        }

        void atualizarComprasComFornecedor()
        {
            clsFornecedor fornecedor = new clsFornecedor();
            fornecedor.Cod_Fornecedor = (int)gridFornecedores.CurrentRow.Cells[0].Value;

            gridCompras.DataSource = compras.BuscarComprasComFornecedor(fornecedor);
        }

        private void gridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarComprasComFornecedor();
            
            cbFuncionario.DataSource    = compras.SelectFuncionarios();
            cbFuncionario.DisplayMember = "Nome_Func";
            cbFuncionario.ValueMember   = "Cod_Funcionario";
            cbFuncionario.SelectedIndex = 0;

            groupCompras.Enabled        = true;
            
            groupDetalhes.Enabled       = false;

            gridInsumos.DataSource      = null;
        }

        void atualizarInsumosNaCompra()
        {
            clsCompra objCompra = new clsCompra();
            objCompra.codCompra = (int)gridCompras.CurrentRow.Cells[0].Value;

            gridInsumos.DataSource = compras.BuscarInsumosNaCompra(objCompra);
        }

        private void btnAdicionarCompra_Click(object sender, EventArgs e)
        {
            if(!ValidarNovaCompra())
                return;

            clsCompra objCompra         = new clsCompra();
            objCompra.DataVenda         = dtCompra.Value;
            objCompra.codFuncionario    = (int) cbFuncionario.SelectedValue;
            objCompra.codFornecedor      = (int)gridFornecedores.CurrentRow.Cells[0].Value;

            compras.RegistrarCompra(objCompra);

            atualizarComprasComFornecedor();
        }

        private void btnAlterarCompra_Click(object sender, EventArgs e)
        {
            if (btnAlterarCompra.Text == "Alterar")
                entrarEmModoEdicao();
            else
                finalizarEdicao();
        }

        void entrarEmModoEdicao() 
        {
            btnAlterarCompra.Text           =       "Gravar";

            cbFuncionario.Text              =       (string)gridCompras.CurrentRow.Cells[3].Value;
            cbFuncionario.Text              =       (string)gridFornecedores.CurrentRow.Cells[3].Value;

            dtCompra.Value                  =       (DateTime)gridCompras.CurrentRow.Cells[2].Value;

            groupFornecedores.Enabled       =       false;
            groupDetalhes.Enabled           =       false;

            btnAdicionarCompra.Enabled      =       false;
            btnRemoverCompra.Enabled        =       false;

            groupFornecedores.Enabled       =       false;

            
        }

        void finalizarEdicao()
        {
            if (!ValidarNovaCompra())
                return;

            clsCompra objCompra                 = new clsCompra();
            objCompra.codCompra                 = (int)gridCompras.CurrentRow.Cells[0].Value;
            objCompra.codFornecedor             = (int)gridFornecedores.CurrentRow.Cells[0].Value;
            objCompra.codFuncionario            = (int)    cbFuncionario.SelectedValue;
            objCompra.DataVenda                 = dtCompra.Value;

            compras.AtualizarCompra(objCompra);

            atualizarComprasComFornecedor();

            groupFornecedores.Enabled           = true;
            //groupDetalhes.Enabled               = true;

            btnAdicionarCompra.Enabled          = true;
            btnRemoverCompra.Enabled            = true;

            btnAlterarCompra.Text               = "Alterar";
        }

        private void gridCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbInsumo.Enabled            =           true;
            cbInsumo.DataSource         =           compras.SelectInsumos();
            cbInsumo.DisplayMember      =           "Nome_Insumo";
            cbInsumo.ValueMember        =           "Cod_Insumo";
            cbInsumo.SelectedIndex      =           0;

            atualizarInsumosNaCompra();

            txtTotalCompra.Text         =           gridCompras.CurrentRow.Cells[1].Value.ToString();

            groupDetalhes.Enabled = true;
        }

        bool ValidarInsumosNaCompra() 
        {
            if (!ValidarQuantidade())
                return false;

            if (!validaPreco())
                return false;

            if (!ValidarExistenciaInsumoNaCompra())
                return false;

            return true;
        }

        bool ValidarExistenciaInsumoNaCompra() 
        {
            if (gridInsumos.RowCount > 1) 
            {
                clsDetalheCompra objDetalheCompra = new clsDetalheCompra();

                objDetalheCompra.codInsumo = (int)cbInsumo.SelectedValue;
                objDetalheCompra.codCompra = (int)gridCompras.CurrentRow.Cells[0].Value;

                if ((int)compras.ValidarExistenciaInsumoNaCompra(objDetalheCompra).Rows[0][0] != 0)
                {
                    Home.mensagemDeErro("Não é permitido haver insumos repetidos na mesma uma compra.", "Comando inválido");

                    return false;
                }
            }
            
            return true;
        }

        bool ValidarQuantidade() 
        {
            if (numQuantidadeInsumo.Value <= 0)
            {
                Home.mensagemDeErro("É preciso fornecer a quantidade comprada de insumos." + ".", "Quantidade inválida");

                return false;
            }

            return true;
        }

        bool validaPreco()
        {
            if (txtPreçoUnitario.Text.Length == 0)
            {
                Home.mensagemDeErro("É preciso fornecer um valor no campo de preço.", "Erro no campo de preço");

                return false;
            }
            else if (txtPreçoUnitario.Text.Contains("."))
            {
                Home.mensagemDeErro("No campo de preço, utilize vírgula (,) ao invés de ponto (.) para separar os centavos.", "Erro no campo de preço");

                return false;
            }
            else
            {
                decimal x = 0;
                decimal.TryParse(txtPreçoUnitario.Text, out x);

                if (x == 0)
                {
                    Home.mensagemDeErro("Não é possível utilizar o valor inserido no campo de preço. Por favor, certifique-se de que o valor seja válido e tente novamente.", "Erro no campo de preço");

                    return false;
                }
            }

            return true;
        }

        bool validarDeleteCompra(clsCompra objCompra)
        {
            if ((int)compras.ValidarAssociacoesNoBanco(objCompra).Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Essa compra possui conexões no sistema e não pode ser excluida.", "Comando inválido");

                return false;
            }

            return true;
        }

        private void btnAdicionarInsumoNaCompra_Click(object sender, EventArgs e)
        {
            if (!ValidarInsumosNaCompra())
                return;

            clsDetalheCompra objDetalheCompra   =   new clsDetalheCompra();

            objDetalheCompra.codFornecedor      =   (int) gridFornecedores.CurrentRow.Cells[0].Value;
            objDetalheCompra.codCompra          =   (int)gridCompras.CurrentRow.Cells[0].Value;
            objDetalheCompra.codInsumo          =   (int)cbInsumo.SelectedValue;
            objDetalheCompra.Quantidade         =   (double)numQuantidadeInsumo.Value;
            objDetalheCompra.valorInsumo        =   Double.Parse(txtPreçoUnitario.Text);
            compras.InserirInsumoNaCompra(objDetalheCompra);

            clsCompra objCompra = new clsCompra();

            objCompra.codCompra                 =   objDetalheCompra.codCompra;
            gridInsumos.DataSource = compras.BuscarInsumosNaCompra(objCompra);

            double valorTotal = calcularValorCompra();

            objDetalheCompra.valorInsumo        =   valorTotal;
            txtTotalCompra.Text                 =   valorTotal.ToString();

            compras.AtualizarPrecoCompra(objDetalheCompra);

            int linha = gridCompras.CurrentRow.Index;
            int coluna = gridCompras.CurrentCell.ColumnIndex;
            atualizarComprasComFornecedor();
            gridCompras.CurrentCell = gridCompras.Rows[linha].Cells[coluna];
            
            atualizarInsumosNaCompra();
        }

        double calcularValorCompra() 
        {
            double valor = 0;
            double quantidade = 0;
            double valorTotal = 0;

            for (int i = 0; i < gridInsumos.RowCount; i++)
            {
                valor = Convert.ToDouble(gridInsumos.Rows[i].Cells[2].Value);
                quantidade = Convert.ToDouble(gridInsumos.Rows[i].Cells[3].Value);
                valorTotal += valor * quantidade;
            }

            return valorTotal;
        }
        
        private void btnRemoverCompra_Click(object sender, EventArgs e)
        {
            clsCompra objCompra = new clsCompra();
            objCompra.codCompra = (int)gridCompras.CurrentRow.Cells[0].Value;
            
            if(!validarDeleteCompra(objCompra))
                return;

            compras.ExcluirCompra(objCompra);

            atualizarComprasComFornecedor();

            gridInsumos.DataSource = null;
        }

        private void btnRemoverInsumoDaCompra_Click(object sender, EventArgs e)
        {
            if (gridInsumos.CurrentCell != null)
            {
                clsDetalheCompra objDetalheCompra = new clsDetalheCompra();

                objDetalheCompra.codCompra = (int) gridCompras.CurrentRow.Cells[0].Value;
                objDetalheCompra.codInsumo = (int)gridInsumos.CurrentRow.Cells[0].Value;

                compras.ExcluirInsumoDaCompra(objDetalheCompra);

                atualizarInsumosNaCompra();

                objDetalheCompra.valorInsumo =  calcularValorCompra();

                txtTotalCompra.Text = objDetalheCompra.valorInsumo.ToString();

                compras.AtualizarPrecoCompra(objDetalheCompra);

                int linha = gridCompras.CurrentRow.Index;
                int coluna = gridCompras.CurrentCell.ColumnIndex;
                atualizarComprasComFornecedor();
                gridCompras.CurrentCell = gridCompras.Rows[linha].Cells[coluna];
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores   = new Fornecedores();
            fornecedores.FormHome       = this;
            fornecedores.Show();
            this.Visible                = false;
        }   
    }
}