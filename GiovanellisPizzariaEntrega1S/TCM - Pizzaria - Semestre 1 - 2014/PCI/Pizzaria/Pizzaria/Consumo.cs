using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using BLL;
using DAL.Model;

namespace Pizzaria
{
    public partial class Consumo : Form
    {
        //TODO: Será preciso filtrar consumos pelos insumos?

        clsConsumoBLL consumo = new clsConsumoBLL();

        public Form FormHome { get; set; }

        public clsProduto produto {get; set;}

        public Consumo()
        {
            InitializeComponent();
        }

        private void gridConsumo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridConsumo_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consumo_Load(object sender, EventArgs e)
        {
            gridConsumo.DataSource = consumo.MostrarConsumo();

            cbProduto.DataSource = consumo.PreencherProdutos();
            cbProduto.ValueMember = "Cod_Produto";
            cbProduto.DisplayMember = "Nome_Produto";
            cbProduto.SelectedIndex = -1;

            cbInsumo.DataSource = consumo.PreencherInsumos();
            cbInsumo.ValueMember = "Cod_Insumo";
            cbInsumo.DisplayMember = "Nome_Insumo";
            cbInsumo.SelectedIndex = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.FormHome.Enabled = true;
            
            Dispose();
        }

        bool ValidaCampos() 
        {
            if (cbProduto.SelectedIndex == -1)
            {
                Home.mensagemDeErro("Por favor, escolha um produto a ser inserido no sistema", "Escolha um produto");

                return false;
            }

            if (cbInsumo.SelectedIndex == -1)
            {
                Home.mensagemDeErro("Por favor, escolha um insumo a ser inserido no sistema", "Escolha um insumo");

                return false;
            }

            if (numQuantidade.Value == 0)
            {
                Home.mensagemDeErro("Por favor, preencha o campo de Quantidade.", "Valor de Quantidade");

                return false;
            }

            return true;
        }

        bool validaID(TextBox campo)
        {
            int s = 0;

            Int32.TryParse(campo.Text, out s);

            if (campo.TextLength > 0 && campo.Text == "0")
            {
                campo.Text = "";

                return false;
            }
            
            if (s == 0)
            {
                Home.mensagemDeErro("Por favor, insira apenas números no campo.", "Erro no campo");

                campo.Text = campo.Text.Remove(campo.TextLength - 1);

                return false;
            }
            return true;
        }

        bool ValidaExistenciaNoBanco() 
        {
            clsConsumo objConsumo = new clsConsumo();
            objConsumo.CodProduto = Int32.Parse(cbProduto.SelectedValue.ToString());
            objConsumo.CodInsumo = Int32.Parse(cbInsumo.SelectedValue.ToString());
            objConsumo.Quantidade = Decimal.Parse(numQuantidade.Value.ToString());

            DataTable resultado = consumo.ValidaExistenciaNoBanco(objConsumo);

            if ((int)resultado.Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Já existe um produto com este nome no banco de dados.\n\nCertifique-se de que o nome do produto que deseja inserir esteja correto ou utilize o produto já registrado.", "Produto existente");

                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            clsConsumo objConsumo = new clsConsumo();
            objConsumo.CodProduto = Int32.Parse(cbProduto.SelectedValue.ToString());
            objConsumo.CodInsumo = Int32.Parse(cbInsumo.SelectedValue.ToString());
            objConsumo.Quantidade = Decimal.Parse(numQuantidade.Value.ToString());

            consumo.InserirConsumo(objConsumo);

            gridConsumo.DataSource = consumo.MostrarConsumoDesc();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaProdutoNome.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else
                gridConsumo.DataSource = consumo.BuscarConsumosPorNomeProduto(txtBuscaProdutoNome.Text);
        }

        private void txtBuscaID_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaProdutoID.Text.Length > 0 && !validaID(txtBuscaProdutoID))
                return;

            if (txtBuscaProdutoID.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else
                gridConsumo.DataSource = consumo.BuscarConsumosPorIDProduto
                    (
                        Int32.Parse
                        (
                            txtBuscaProdutoID.Text
                        )
                    );
        }

        private void txtBuscaInsumoNome_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaInsumoNome.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else
                gridConsumo.DataSource = consumo.BuscarConsumosPorNomeInsumo(txtBuscaInsumoNome.Text);
        }

        private void txtBuscaInsumoID_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaInsumoID.Text.Length > 0 && !validaID(txtBuscaInsumoID))
                return;

            if (txtBuscaInsumoID.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else
                gridConsumo.DataSource = consumo.BuscarConsumosPorIdInsumo
                    (
                        Int32.Parse
                        (
                            txtBuscaInsumoID.Text
                        )
                    );
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnAlterar.Text == "Alterar")
                iniciarModoEdicao();
            else
                finalizarModoEdicao();
        }

        void iniciarModoEdicao() 
        {
            btnAlterar.Text = "Gravar";

            cbProduto.SelectedIndex = Int32.Parse(gridConsumo.CurrentRow.Cells[1].Value.ToString()) - 1;

            cbInsumo.SelectedIndex = Int32.Parse(gridConsumo.CurrentRow.Cells[3].Value.ToString()) - 1;

            numQuantidade.Value = Decimal.Parse(gridConsumo.CurrentRow.Cells[5].Value.ToString());

            btnAdicionar.Enabled = false;
            btnExcluir.Enabled = false;

            txtBuscaProdutoNome.Enabled = false;
            txtBuscaProdutoID.Enabled = false;
            txtBuscaInsumoNome.Enabled = false;
            txtBuscaInsumoID.Enabled = false;

            gridConsumo.Enabled = false;
        }

        void finalizarModoEdicao() 
        {
            if (!ValidaCampos())
                return;

            if (!ValidaExistenciaNoBanco())
                return;

            clsProduto objProduto = new clsProduto();
            objProduto.Cod_Produto = (int)dtg_produtos.CurrentRow.Cells[0].Value;
            objProduto.Nome_Produto = txt_nome.Text;
            objProduto.Valor_Venda = double.Parse(txtPreco.Text);

            if (chk_site.Checked)
                objProduto.Sobe_Site = 1;
            else
                objProduto.Sobe_Site = 0;

            produto.AtualizarProduto(objProduto);
            dtg_produtos.DataSource = produto.BuscarProdutoPorID(objProduto.Cod_Produto);

            txt_nome.Clear();
            txtPreco.Clear();
            chk_site.Checked = false;

            btn_inserir.Enabled = true;
            txtBuscaPorID.Enabled = true;
            txtBuscaPorNome.Enabled = true;
            dtg_produtos.Enabled = true;

            btn_atualizar.Text = "Alterar";
        }
        
    }
}
