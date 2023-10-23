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
    public partial class FrmPesquisaCidade : Form
    {
        private string aux;

        Dados d1 = new Dados();
        public FrmPesquisaCidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = d1.pesquisaCidade().Tables[0];
        }
    }
}
