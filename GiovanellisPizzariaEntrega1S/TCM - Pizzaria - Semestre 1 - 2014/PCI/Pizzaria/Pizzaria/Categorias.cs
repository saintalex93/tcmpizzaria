using BLL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Categorias : Form
    {
        clsCategoriaBLL categoria = new clsCategoriaBLL();

        public Categorias()
        {
            InitializeComponent();
        }

        public Form FormHome { get; set; }

        void PreencherComboBox(int cb) 
        {
            switch (cb)
            { 
                case 0:
                    cbCategorias.DataSource = categoria.BuscarCategorias();
                    cbCategorias.DisplayMember = "NomeCategoria";
                    cbCategorias.ValueMember = "CodCategoria";
                    cbCategorias.SelectedIndex = -1;
                    break;

                case 1:
                    cbProdutos.DataSource = categoria.PreencherProdutos();
                    cbProdutos.DisplayMember = "Nome_Produto";
                    cbProdutos.ValueMember = "Cod_Produto";
                    cbProdutos.SelectedIndex = -1;
                    break;

                case 2:
                    cbInsumos.DataSource = categoria.PreencherInsumos();
                    cbInsumos.DisplayMember = "Nome_Insumo";
                    cbInsumos.ValueMember = "Cod_Insumo";
                    cbInsumos.SelectedIndex = -1;
                    break;
            }
        }



        private void Categorias_Load(object sender, EventArgs e)
        {
            if (Produtos.sequenciaCadastro)
                btnFinalizar.Text = "Finalizar";
            
            PreencherComboBox(0);
        }

        void PreencherListas() 
        {
            if (cbCategorias.SelectedIndex != 0)
            {
                clsCategoria objCategoria = new clsCategoria();
                objCategoria.CodCategoria = (int) cbCategorias.SelectedValue;

                if (cbProdutos.SelectedIndex != 0) 
                {
                    lstProdutosCategoria.DataSource = categoria.PreencherProdutosNaCategoria(objCategoria);
                    lstProdutosCategoria.DisplayMember = "Nome_Produto";
                    lstProdutosCategoria.ValueMember = "Cod_Produto";
                }

                if (cbInsumos.SelectedIndex != 0)
                {
                    lstInsumosCategoria.DataSource = categoria.PreencherInsumosNaCategoria(objCategoria);
                    lstInsumosCategoria.DisplayMember = "Nome_Insumo";
                    lstInsumosCategoria.ValueMember = "Cod_Insumo";
                }
            }
        }

        void CategoriaNaoSelecionada() 
        {
            grpConteudo.Enabled = false;
            cbInsumos.DataSource = null;
            cbProdutos.DataSource = null;
            lstInsumosCategoria.DataSource = null;
            lstProdutosCategoria.DataSource = null;
        }

        void CategoriaSelecionada()
        {
            grpConteudo.Enabled = true;
            PreencherComboBox(1);
            PreencherComboBox(2);
            PreencherListas();
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedIndex != -1)
                CategoriaSelecionada();
            else
                CategoriaNaoSelecionada();
        }

        bool ValidaNome() 
        {
            if (txtNomeCategoria.Text.Length == 0)
            {
                Home.mensagemDeErro("Para inserir uma categoria ao sistema, não é permitido manter o campo de nome vazio.","Nome inválido");

                return false;
            }

            return true;
        }

        bool ValidaExistenciaNoBanco()
        {
            clsCategoria objCategoria = new clsCategoria();
            objCategoria.NomeCategoria = txtNomeCategoria.Text;

            if ( (int) categoria.ValidarExistenciaNoBanco(objCategoria).Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Já existe uma Categoria com esse nome no sistema. Certifique-se de que o nome esteja correto e tente novamente.", "Nome inválido");

                return false;
            }

            return true;
        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            if (!ValidaNome())
                return;

            if (!ValidaExistenciaNoBanco())
                return;

            clsCategoria objCategoria = new clsCategoria();
            objCategoria.NomeCategoria = txtNomeCategoria.Text;

            categoria.InserirCategoria(objCategoria);

            PreencherComboBox(0);
        }

        private void cbCategorias_Leave(object sender, EventArgs e)
        {
            if (cbCategorias.Text.Length == 0)
                CategoriaNaoSelecionada();
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            if (cbCategorias.Text.Length > 0) 
            {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo remover essa categoria?", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    clsCategoria objCategoria = new clsCategoria();
                    objCategoria.CodCategoria = (int)cbCategorias.SelectedValue;

                    categoria.RemoverCategoria(objCategoria);

                    MessageBox.Show("Categoria \"" + cbCategorias.Text + "\" e todos os dados referentes a ela foram excluídos.");

                    cbCategorias.DataSource = categoria.BuscarCategorias();
                }
            }
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (Produtos.sequenciaCadastro)
            {
                Produtos.sequenciaCadastro = false;

                FormHome.Enabled = true;
            }
            else
            {
                FormHome.Show();
            }

            Dispose();
        }

        void iniciarModoEdicao() 
        {
            txtNomeCategoria.Text = cbCategorias.Text;

            cbCategorias.Enabled = false;
            btnAdicionarCategoria.Enabled = false;
            btnRemoverCategoria.Enabled = false;
            grpConteudo.Enabled = false;

            btnAlterar.Text = "Gravar";
        }

        void finalizarModoEdicao() 
        {
            txtNomeCategoria.Clear();

            clsCategoria objCategoria = new clsCategoria();
            objCategoria.NomeCategoria = txtNomeCategoria.Text;
            objCategoria.CodCategoria = (int) cbCategorias.SelectedValue;

            categoria.AlterarCategoria(objCategoria);

            PreencherComboBox(0);

            cbCategorias.Enabled = true;
            btnAdicionarCategoria.Enabled = true;
            btnRemoverCategoria.Enabled = true;
            grpConteudo.Enabled = true;

            btnAlterar.Text = "Alterar";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cbCategorias.Text.Length > 0)
                if(btnAlterar.Text == "Alterar")
                    iniciarModoEdicao();
                else if (btnAlterar.Text == "Gravar")
                    finalizarModoEdicao();
           
        }

        bool ValidaProdutoCategoria(clsCategoriaProduto objCategoriaProduto)
        {
            if ( (int) categoria.ValidaProdutoCategoria(objCategoriaProduto).Rows[0][0] != 0) ;
            
            return true;
        }

        private void btnAdicionarProdutoCategoria_Click(object sender, EventArgs e)
        {
            if (cbProdutos.SelectedIndex != 0)
            {
                clsCategoriaProduto objCategoriaProduto = new clsCategoriaProduto();
                objCategoriaProduto.CodProduto = (int) cbProdutos.SelectedValue;
                objCategoriaProduto.CodCategoria = (int) cbCategorias.SelectedValue;

                if (!ValidaProdutoCategoria(objCategoriaProduto))
                    return;

                

                categoria.InserirProdutoNaCategoria(objCategoriaProduto);

                PreencherListas();
            }
        }
    }
}
