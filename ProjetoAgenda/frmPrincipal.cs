using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncluir incluir = new frmIncluir();
            incluir.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterar alterar = new frmAlterar();
            alterar.ShowDialog();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaNome pesquisa = new FrmPesquisaNome();
            pesquisa.ShowDialog();
        }

        private void porCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaCidade frmPesquisaCidade = new FrmPesquisaCidade();
            frmPesquisaCidade.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir frmExcluir = new FrmExcluir();
            frmExcluir.ShowDialog();
        }
    }
}
