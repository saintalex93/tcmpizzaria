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

        public Form FormHome { get; set; }

        public static string dataSource= "";
        public static string catalog= "";
        public static string id= "";
        public static string password= "";

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
            dataSource = txtDataSource.Text;
            catalog = txtCatalog.Text;
            id = txtID.Text;
            password = txtPassword.Text;

            Acesso.Conexao = "Data Source=" + dataSource + " ;Initial Catalog=" + catalog + "; Persist Security Info = True; User ID=" + id + "; Password=" + password;

            Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rdLocalHost_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdCustom_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Rede_Shown(object sender, EventArgs e)
        {
            txtDataSource.Text = dataSource;
            txtCatalog.Text = catalog;
            txtID.Text = id;
            txtPassword.Text = password;

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtDataSource.Text = "MÔNICA\\SQLEXPRESS";
            txtCatalog.Text = "Pizzaria";
            txtID.Text = "sa";
            txtPassword.Text = "123456";
        }
    }
}
