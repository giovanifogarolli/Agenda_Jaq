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

namespace ProjetoAgenda
{
    public partial class FrmExcluir : Form
    {
        private int codigo;

        public FrmExcluir()
        {
            InitializeComponent();
        }

        Dados d1 = new Dados();
        private void FrmExcluir_Load(object sender, EventArgs e)
        {
            cboNome.DisplayMember = "Nome";
            cboNome.ValueMember = "Codigo";
            cboNome.DataSource = d1.pesquisaDados().Tables[0];
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            d1.Codigo = codigo;
            d1.excluiDados();
            MessageBox.Show("Excluido com sucesso!");

            cboNome.DisplayMember = "Nome";
            cboNome.ValueMember = "Codigo";
            cboNome.DataSource = d1.pesquisaDados().Tables[0];
        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = int.Parse(cboNome.SelectedValue.ToString());
            d1.Codigo = codigo;
            d1.pesquisaID();
            txtTelefone.Text = d1.Telefone;
            txtCidade.Text = d1.Cidade;
        }
    }
}
