using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Rede : Form
    {
        public Rede()
        {
            InitializeComponent();
        }

        string dataSourceString = "";

        public static class DataContainer
        {
            static public string conexaoGlobal = "";
        }



        private void Rede_Load(object sender, EventArgs e)
        {

        }

        private void txtDataSource_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            dataSourceString = txtDataSource.Text;// +"\\" + "SQLEXPRESS";

            DataContainer.conexaoGlobal = "Data Source=" + dataSourceString + " ;Initial Catalog="+ txtCatalog.Text +"; Persist Security Info = True; User ID=" + txtID.Text + "; Password=" + txtPassword.Text;

            Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rdLocalHost_CheckedChanged(object sender, EventArgs e)
        {
            rdCustom.Checked = false;
            txtDataSource.Enabled = false;
            dataSourceString = "Localhost";
        }

        private void rdCustom_CheckedChanged(object sender, EventArgs e)
        {
            rdLocalHost.Checked = false;
            txtDataSource.Enabled = true;
        }

        private void Rede_Shown(object sender, EventArgs e)
        {
            rdLocalHost.Checked = true;
            txtDataSource.Enabled = false;
        }
    }
}
