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
        }
    }
}
