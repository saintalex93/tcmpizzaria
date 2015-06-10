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

            cbFuncionario.DataSource = compras.SelectFuncionarios();
            cbFuncionario.DisplayMember = "Nome_Fantasia";
            cbFuncionario.ValueMember = "Cod_Fornecedor";
            cbFuncionario.SelectedIndex = 0;

            cbInsumo.DataSource = compras.SelectInsumos();
            cbInsumo.DisplayMember = "Nome";
            cbInsumo.ValueMember = "CodInsumo";
            cbInsumo.SelectedIndex = 0;
        }

        bool ValidarData()
        {
            if (dtCompra.Value > DateTime.Today)
            {
                Home.mensagemDeErro("Não é permitido adicionar uma data futura.", "Valor não válido");

                return false;
            }

            return true;
        }

        bool ValidarDados()
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

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormHome.Visible = true;

            Dispose();
        }

        private void gridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsFornecedor fornecedor = new clsFornecedor();
            fornecedor.Cod_Fornecedor = (int) gridFornecedores.CurrentRow.Cells[0].Value;

            gridCompras.DataSource = compras.BuscarComprasComFornecedor(fornecedor);
            
            cbFornecedores.DataSource = compras.SelectFornecedores();
            cbFornecedores.DisplayMember = "Nome_Fantasia";
            cbFornecedores.ValueMember = "Cod_Fornecedor";
        }

        private void btnAdicionarCompra_Click(object sender, EventArgs e)
        {
            if(!ValidarDados())
                return;

            clsCompra objCompra = new clsCompra();
            objCompra.DataVenda = dtCompra.Value;
            objCompra.codFuncionario = (int) cbFuncionario.SelectedValue;
            objCompra.codFornecedor = (int) gridFornecedores.CurrentRow.Cells[0].Value;

            compras.RegistrarCompra(objCompra);
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
            btnAlterarCompra.Text = "Gravar";

            cbFornecedores.SelectedIndex = gridFornecedores.CurrentRow.Index;
            cbFornecedores.Enabled = true;
            
            cbFuncionario.Text = (string)gridFornecedores.CurrentRow.Cells[3].Value;
        }

        void finalizarEdicao()
        {
            btnAlterarCompra.Text = "Alterar";
        }
    }
}
