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

namespace ProjetoAgenda
{
    public partial class frmIncluir : Form
    {
        public frmIncluir()
        {
            InitializeComponent();
        }

        Dados d1 = null;
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            d1 = new Dados();
            d1.Nome = txtNome.Text;
            d1.Telefone = txtTelefone.Text;
            d1.Cidade = txtCidade.Text;
            d1.incluirDados();
            MessageBox.Show("Incluido com sucesso!");
            txtNome.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
        }

        private void frmIncluir_Load(object sender, EventArgs e)
        {

        }
    }
}
