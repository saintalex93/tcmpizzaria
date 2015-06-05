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

        private void Categorias_Load(object sender, EventArgs e)
        {
            if (Produtos.sequenciaCadastro)
                btnFinalizar.Text = "Finalizar";

            btnAlterar.Enabled = false;
            btnRemoverCategoria.Enabled = false;

            PreencherComboBox(0);
        }
        
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

        void PreencherListas() 
        {
            try
            {
                if (cbCategorias.SelectedIndex != -1)
                {
                    clsCategoria objCategoria = new clsCategoria();
                    objCategoria.CodCategoria = (int) cbCategorias.SelectedValue;

                    lstProdutosCategoria.DataSource = categoria.PreencherProdutosNaCategoria(objCategoria);
                    lstProdutosCategoria.DisplayMember = "Nome_Produto";
                    lstProdutosCategoria.ValueMember = "Cod_Produto";

                    lstInsumosCategoria.DataSource = categoria.PreencherInsumosNaCategoria(objCategoria);
                    lstInsumosCategoria.DisplayMember = "Nome_Insumo";
                    lstInsumosCategoria.ValueMember = "Cod_Insumo";
                }
            }
            catch (Exception e) { }
            
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
            
            btnAlterar.Enabled = true;
            btnRemoverCategoria.Enabled = true;
            
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

        bool ValidarCategoriaNoBanco(clsCategoria objCategoria)
        {
            if ((int)categoria.ValidarCategoriaNoBanco(objCategoria).Rows[0][0] != 0)
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

            clsCategoria objCategoria = new clsCategoria();
            objCategoria.NomeCategoria = txtNomeCategoria.Text;

            if (!ValidarCategoriaNoBanco(objCategoria))
                return;

            categoria.InserirCategoria(objCategoria);

            PreencherComboBox(0);

            cbCategorias.SelectedIndex = cbCategorias.FindStringExact(txtNomeCategoria.Text);

            txtNomeCategoria.Clear();
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
                clsCategoria objCategoria = new clsCategoria();
                objCategoria.CodCategoria = Convert.ToInt32(cbCategorias.SelectedValue);

                if ((int)categoria.ValidaExclusaoCategoria(objCategoria).Rows[0][0] > 0)
                {
                    Home.mensagemDeErro("Não é possível excluir essa categoria, porque ela possui registros associados a ela.", "Exclusão não permitida");

                    return;
                }

                categoria.RemoverCategoria(objCategoria);

                PreencherComboBox(0);
            } 
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (Produtos.sequenciaCadastro)
                Produtos.sequenciaCadastro = false;

            FormHome.Enabled = true;
            FormHome.Show();
            FormHome.Focus();

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
            clsCategoria objCategoria = new clsCategoria();
            objCategoria.NomeCategoria = txtNomeCategoria.Text;
            objCategoria.CodCategoria = (int)cbCategorias.SelectedValue;

            if (!ValidarCategoriaNoBanco(objCategoria))
                return;

            categoria.AlterarCategoria(objCategoria);

            PreencherComboBox(0);

            cbCategorias.SelectedIndex = cbCategorias.FindStringExact(txtNomeCategoria.Text);

            txtNomeCategoria.Clear();

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

        bool ValidaProdutoNaCategoria(clsCategoriaProduto objCategoriaProduto)
        {
            if ((int)categoria.ValidaProdutoNaCategoria(objCategoriaProduto).Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Esse produto já está registrado nessa categoria.","Produto já na categoria");
                
                return false;
            }

            return true;
        }

        bool ValidaInsumoNaCategoria(clsCategoriaInsumo objCategoriaInsumo)
        {
            if ((int)categoria.ValidaInsumoNaCategoria(objCategoriaInsumo).Rows[0][0] != 0)
            {
                Home.mensagemDeErro("Esse insumo já está registrado nessa categoria.", "Produto já na categoria");

                return false;
            }
            return true;
        }

        private void btnAdicionarProdutoCategoria_Click(object sender, EventArgs e)
        {
            if (cbProdutos.Text.Length > 0) 
            {
                clsCategoriaProduto objCategoriaProduto = new clsCategoriaProduto();
                objCategoriaProduto.CodProduto = (int)cbProdutos.SelectedValue;
                objCategoriaProduto.CodCategoria = (int)cbCategorias.SelectedValue;

                if (!ValidaProdutoNaCategoria(objCategoriaProduto))
                    return;

                categoria.InserirProdutoNaCategoria(objCategoriaProduto);

                PreencherListas();
            }
        }

        private void btnRemoverProdutoCategoria_Click(object sender, EventArgs e)
        {
            try 
            {
                clsCategoriaProduto objCategoriaProduto = new clsCategoriaProduto();
                objCategoriaProduto.CodProduto = (int)lstProdutosCategoria.SelectedValue;
                objCategoriaProduto.CodCategoria = (int) cbCategorias.SelectedValue;

                categoria.RemoverProdutoDaCategoria(objCategoriaProduto);

                PreencherListas();
            }
            catch (Exception ex) { }
        }

        private void btnAdicionarInsumoCategoria_Click(object sender, EventArgs e)
        {
            if (cbInsumos.Text.Length > 0)
            {
                clsCategoriaInsumo objCategoriaInsumo = new clsCategoriaInsumo();
                objCategoriaInsumo.CodInsumo = (int) cbInsumos.SelectedValue;
                objCategoriaInsumo.CodCategoria = (int) cbCategorias.SelectedValue;

                if (!ValidaInsumoNaCategoria(objCategoriaInsumo))
                    return;

                categoria.InserirInsumoNaCategoria(objCategoriaInsumo);

                PreencherListas();
            }
        }

        private void btnRemoverInsumoCategoria_Click(object sender, EventArgs e)
        {
            clsCategoriaInsumo objCategoriaInsumo = new clsCategoriaInsumo();
            objCategoriaInsumo.CodInsumo = (int) lstInsumosCategoria.SelectedValue;
            objCategoriaInsumo.CodCategoria = (int) cbCategorias.SelectedValue;

            categoria.RemoverInsumoDaCategoria(objCategoriaInsumo);

            PreencherListas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            categoria.CancelarSequenciaDeCadastroDeProduto();

            FormHome.Enabled = true;
            FormHome.Show();
            
            Dispose();

            FormHome.Focus();
        }
    }
}
