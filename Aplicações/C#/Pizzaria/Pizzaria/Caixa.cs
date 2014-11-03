using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pizzaria
{
    public partial class Caixa : Form
    {
        string conexao = "Data Source= Alex\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";

        DateTime hoje = DateTime.Today;
        int periodo = 0;
        string dataComeco = "";
        string dataFim = "";

        public Caixa()
        {
            InitializeComponent();
        }

        public Form FormHome { get; set; }

        public void calcularSaldo()
        {
            double saldo = 0;

            for (int x = 0; x < gridRegistros.Rows.Count; x++)
            {


                saldo += Convert.ToDouble(gridRegistros.Rows[x].Cells[3].Value);
            }

            txtTotal.Text = saldo.ToString();
        }

        public void preencherGrid(string busca, DataGridView tabela)
        {

            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            SqlCommand sqlComm = new SqlCommand(busca, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlComm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela.DataSource = dt;
            conn.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.FormHome.Show();
            Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dpComeco.Value > dpFim.Value)
            {
                Fornecedores.mensagemDeErro("A data inicial não pode estar depois da data final.\n\nPor favor, certifique-se de que as datas estejam corretas e tente novamente.");

                dpComeco.Value = hoje;
                dpFim.Value = hoje.AddDays(1);

                return;
            }


            dataComeco = dpComeco.Value.Year + dpComeco.Value.Month.ToString("D2") + dpComeco.Value.Day.ToString("D2");
            dataFim = dpFim.Value.Year + dpFim.Value.Month.ToString("D2") + dpFim.Value.Day.ToString("D2");

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdEspecifico_CheckedChanged(object sender, EventArgs e)
        {
            dpComeco.Enabled = !dpComeco.Enabled;
            dpFim.Enabled = !dpFim.Enabled;
            btnBuscar.Enabled = !btnBuscar.Enabled;

            gridRegistros.DataSource = null;
            gridRegistros.Rows.Clear();

            calcularSaldo();
        }

        private void rdDiario_CheckedChanged(object sender, EventArgs e)
        {
            dataComeco = hoje.Year + hoje.Month.ToString("D2") + hoje.Day.ToString("D2");

            dataFim = dataComeco;

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdSemanal_CheckedChanged(object sender, EventArgs e)
        {
            DateTime input = hoje;
            int delta = DayOfWeek.Monday - input.DayOfWeek;
            DateTime monday = input.AddDays(delta);

            dataComeco = hoje.Year + hoje.Month.ToString("D2") + monday.Day.ToString("D2");
            dataFim = hoje.Year + hoje.Month.ToString("D2") + hoje.Day.ToString("D2");

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdMensal_CheckedChanged(object sender, EventArgs e)
        {
            dataComeco = hoje.Year + hoje.Month.ToString("D2") + "01";
            dataFim = hoje.Year + hoje.Month.ToString("D2") + hoje.Day.ToString("D2");

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdSemestral_CheckedChanged(object sender, EventArgs e)
        {
            DateTime meioDoAno = new DateTime(hoje.Year, 6, 1);

            if (hoje <= meioDoAno)
                dataComeco = hoje.Year + "01" + "01";
            else
                dataComeco = hoje.Year + "06" + "01";

            dataFim = hoje.Year + hoje.Month.ToString("D2") + hoje.Day.ToString("D2");

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdAnual_CheckedChanged(object sender, EventArgs e)
        {
            dataComeco = hoje.Year + "01" + "01";
            dataFim = hoje.Year + hoje.Month.ToString("D2") + hoje.Day.ToString("D2");

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }
    }
}
