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
        //string conexao = "Data Source= Alex\\SQLEXPRESS ;Initial Catalog=Pizzaria; Persist Security Info = True; User ID=sa; Password=1234";
        string conexao = "";
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

        public string formatarParaData(string dataAFormatar)
        {
            dataAFormatar = dataAFormatar.Insert(0, "'");
            dataAFormatar = dataAFormatar.Insert(3, "-");
            dataAFormatar = dataAFormatar.Insert(6, "-");
            dataAFormatar = dataAFormatar.Insert(dataAFormatar.Length, "'");

            return dataAFormatar;
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
                Home.mensagemDeErro("A data inicial não pode estar depois da data final.\n\nPor favor, certifique-se de que as datas estejam corretas e tente novamente.","Data inadequada");

                dpComeco.Value = hoje;
                dpFim.Value = hoje.AddDays(1);

                return;
            }


            dataComeco = dpComeco.Value.Day.ToString("D2") + dpComeco.Value.Month.ToString("D2") + dpComeco.Value.Year;

            dataFim = dpFim.Value.Day.ToString("D2") + dpFim.Value.Month.ToString("D2") + dpFim.Value.Year;

            dataComeco = formatarParaData(dataComeco);
            dataFim = formatarParaData(dataFim);

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
            dataComeco = hoje.Day.ToString("D2") + hoje.Month.ToString("D2") + hoje.Year;

            dataComeco = formatarParaData(dataComeco);

            dataFim = dataComeco;

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdSemanal_CheckedChanged(object sender, EventArgs e)
        {
            DateTime input = hoje;
            int delta = DayOfWeek.Monday - input.DayOfWeek;
            DateTime monday = input.AddDays(delta);

            dataComeco = monday.Day.ToString("D2") + hoje.Month.ToString("D2") + hoje.Year;
            dataFim = monday.Day.ToString("D2") + hoje.Month.ToString("D2") + hoje.Year;

            dataComeco = formatarParaData(dataComeco);
            dataFim = formatarParaData(dataFim);

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdMensal_CheckedChanged(object sender, EventArgs e)
        {
            dataComeco = "01" + hoje.Month.ToString("D2") + hoje.Year;
            dataFim = hoje.Day.ToString("D2") + hoje.Month.ToString("D2") + hoje.Year;

            dataComeco = formatarParaData(dataComeco);
            dataFim = formatarParaData(dataFim);

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdSemestral_CheckedChanged(object sender, EventArgs e)
        {
            DateTime meioDoAno = new DateTime(hoje.Year, 6, 1);

            if (hoje <= meioDoAno)
                dataComeco = "01" + "01" + hoje.Year;
            else
                dataComeco = "01" + "06" + hoje.Year;

            dataFim = hoje.Day.ToString("D2") + hoje.Month.ToString("D2") + hoje.Year;

            dataComeco = formatarParaData(dataComeco);
            dataFim = formatarParaData(dataFim);

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void rdAnual_CheckedChanged(object sender, EventArgs e)
        {
            dataComeco = "01" + "01" + hoje.Year;
            dataFim = hoje.Day.ToString("D2") + hoje.Month.ToString("D2") + hoje.Year;

            dataComeco = formatarParaData(dataComeco);
            dataFim = formatarParaData(dataFim);

            preencherGrid("select Cod_Pedido as [ID], Data, Hora, Valor as [Saldo], Cod_Funcionario as [Atendente], Cod_Cliente as [Cliente] from Pedido where Data between " + dataComeco + " and " + dataFim, gridRegistros);

            calcularSaldo();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            conexao = Acesso.Conexao;
        }
    }
}
