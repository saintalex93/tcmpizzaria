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

            PreencherInsumo();

            PreencheProdutos();

            if (Produtos.sequenciaCadastro)
            { 
                btnVoltar.Text = "Seguinte";
                btnCancelar.Visible = true;
                cbProduto.Enabled = false;
              
                cbProduto.SelectedIndex = 
                    cbProduto.FindStringExact
                    (
                       (string) consumo.BuscarUltimoProduto().Rows[0][0]
                    );

                btnAlterar.Enabled = false;
            }
        }

        int PreencheProdutos() 
        {
            cbProduto.DataSource = consumo.PreencherProdutos();
            cbProduto.ValueMember = "Cod_Produto";
            cbProduto.DisplayMember = "Nome_Produto";

            if (Produtos.sequenciaCadastro)
            {
                int x = 0;
                
                //for (int i = 0; i < cbProduto.Items.Count; i++)
                    //if(x < cbProduto.DataSource.

                    return 0;
            }
            else
                return cbProduto.SelectedIndex = -1;
        }

        void PreencherInsumo()
        {
            cbInsumo.DataSource = consumo.PreencherInsumos();
            cbInsumo.ValueMember = "Cod_Insumo";
            cbInsumo.DisplayMember = "Nome_Insumo";
            cbInsumo.SelectedIndex = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DataTable semConsumo = consumo.VerificaProdutoSemConsumo();
            DataTable consumoVazio = consumo.VerificaConsumoVazio();

            int intSemConsumo = (int) semConsumo.Rows[0][0];
            int intConsumoVazio =  (int) consumoVazio.Rows[0][0];

            if (intSemConsumo  != 0)
            {
                Home.mensagemDeErro("Consta no sistema que existem Produtos sem Insumos registrados para consumo.\n\nCertifique-se de que todos os Produtos tem pelo menos um Insumo associado para poder seguir para o próximo menu.", "Integridade no banco de dados");

                return;
            }

            if (intConsumoVazio != 0)
            {
                Home.mensagemDeErro("Consta no sistema que existem registros de Consumo com campos vazios.\n\nCertifique-se de que todos os Produtos tem pelo menos um Insumo associado para poder seguir para o próximo menu.","Integridade nos registros");

                return;
            }

            if (Produtos.sequenciaCadastro)
            {
                Categorias categoria = new Categorias();
                categoria.Show();

                categoria.FormHome = this.FormHome;
            }
            else
            { 
                FormHome.Show();
                FormHome.Focus();
            }
            
            
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

        bool ValidaExistenciaNoBanco(clsConsumo objConsumo) 
        {
            DataTable resultado = consumo.ValidaExistenciaNoBanco(objConsumo);

            if ((int)resultado.Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Já existe um registro de consumo com este produto e este insumo no banco de dados.\n\nCertifique-se de que tudo esteja correto para poder continuar.", "Produto existente");

                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
                return;

            clsConsumo objConsumo = new clsConsumo();
            objConsumo.CodProdutoInsumo = 0;
            objConsumo.CodProduto = Int32.Parse(cbProduto.SelectedValue.ToString());
            objConsumo.CodInsumo = Int32.Parse(cbInsumo.SelectedValue.ToString());
            objConsumo.Quantidade = Decimal.Parse(numQuantidade.Value.ToString());

            if (!ValidaExistenciaNoBanco(objConsumo))
                return;

            consumo.InserirConsumo(objConsumo);

            gridConsumo.DataSource = consumo.MostrarConsumoDesc();

            cbInsumo.SelectedIndex = -1;
            numQuantidade.Value = 0;
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaProdutoNome.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else 
            {
                clsProduto objProduto = new clsProduto();
                objProduto.Nome_Produto = txtBuscaProdutoNome.Text.ToString();

                gridConsumo.DataSource = consumo.BuscarConsumosPorNomeProduto(objProduto);
            }
                
        }

        private void txtBuscaID_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaProdutoID.Text.Length > 0 && !validaID(txtBuscaProdutoID))
                return;

            if (txtBuscaProdutoID.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else
            {
                clsProduto objProduto = new clsProduto();
                objProduto.Cod_Produto = Int32.Parse(txtBuscaProdutoID.Text);

                gridConsumo.DataSource = consumo.BuscarConsumosPorIDProduto(objProduto);
            }
        }

        private void txtBuscaInsumoNome_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaInsumoNome.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else
            {
                clsInsumo objInsumo = new clsInsumo ();
                objInsumo.Nome_Insumo = txtBuscaInsumoNome.Text;

                gridConsumo.DataSource = consumo.BuscarConsumosPorNomeInsumo(objInsumo);
            }
                
        }

        private void txtBuscaInsumoID_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaInsumoID.Text.Length > 0 && !validaID(txtBuscaInsumoID))
                return;

            if (txtBuscaInsumoID.Text.Length == 0)
                gridConsumo.DataSource = consumo.MostrarConsumo();
            else 
            {
                clsInsumo insumo = new clsInsumo();
                insumo.Cod_Insumo = Int32.Parse(txtBuscaInsumoID.Text);

                gridConsumo.DataSource = consumo.BuscarConsumosPorIdInsumo(insumo);
            }
                
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

            clsConsumo objConsumo = new clsConsumo();
            objConsumo.CodProdutoInsumo = (int)gridConsumo.CurrentRow.Cells[0].Value;
            objConsumo.CodProduto = Int32.Parse(cbProduto.SelectedValue.ToString());
            objConsumo.CodInsumo = Int32.Parse(cbInsumo.SelectedValue.ToString());
            objConsumo.Quantidade = numQuantidade.Value;

            if (!ValidaExistenciaNoBanco(objConsumo))
                return;

            consumo.AtualizarConsumo(objConsumo);
            gridConsumo.DataSource = consumo.BuscarConsumosPorIDProduto(objConsumo);

            cbInsumo.SelectedIndex = -1;
            cbProduto.SelectedIndex = -1;
            numQuantidade.Value = 0;

            btnAdicionar.Enabled = true;
            btnExcluir.Enabled = true;
            
            txtBuscaInsumoID.Enabled = true;
            txtBuscaInsumoNome.Enabled = true;
            txtBuscaProdutoID.Enabled = true;
            txtBuscaProdutoNome.Enabled = true;

            gridConsumo.Enabled = true;

            btnAlterar.Text = "Alterar";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro?", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clsConsumo objConsumo = new clsConsumo();
                objConsumo.CodProdutoInsumo = (int) gridConsumo.CurrentRow.Cells[0].Value;
                consumo.RemoverConsumo(objConsumo);
                gridConsumo.DataSource = consumo.MostrarConsumo();
            }
        }

        private void cbProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cbProduto.SelectedValue != -1)
            {
                clsConsumo objConsumo = new clsConsumo();
                objConsumo.CodProduto = (int) cbProduto.SelectedValue;

                gridConsumo.DataSource = consumo.BuscarConsumosPorIDProduto
                    (objConsumo);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            consumo.CancelarInsercao();

            FormHome.Enabled = true;
            FormHome.Focus();

            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gridConsumo.DataSource = consumo.VerificaProdutoSemConsumo();
        }
    }
}
