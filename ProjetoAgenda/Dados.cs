using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class Dados
    {
        private Conexaodados cdados = new Conexaodados();
        private int codigo;
        private string nome;
        private string telefone;
        private string cidade;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public void incluirDados()
        {
            string sql = $"Insert into DadosAgenda (Nome, Telefone, Cidade) " +
            $"values ('{Nome}','{Telefone}','{Cidade}')";
            cdados.executar(sql);
        }

        public void alterarDados()
        {
            string sql = $"UPDATE DadosAgenda SET  Cidade = '{cidade}'," +
                $" Telefone = '{telefone}' WHERE Codigo = " + codigo.ToString();
            cdados.executar(sql);
        }

        public void excluiDados()
        {
            string sql = $"DELETE FROM DadosAgenda WHERE codigo = {codigo}";
            cdados.executar(sql);
        }

        public void pesquisaID()
        {
            string sql = $"Select * from DadosAgenda where codigo = " + codigo.ToString();
            cdados.consultaID(sql);
            string[] vetorcampos = cdados.Campos.Split(';');
            telefone = vetorcampos[2];
            cidade = vetorcampos[3];
        }

        public DataSet pesquisaDados()
        {
            string sql = $"Select * from DadosAgenda";
            return cdados.listarDados(sql);
        }

        public DataSet pesquisaNome()
        {
            string sql = $"Select * from dadosAgenda where nome like'" + nome + "%'";
            return cdados.listarDados(sql);
        }

        public DataSet pesquisaCidade()
        {
            string sql = "Select * from dadosAgenda where cidade like'" + cidade + "%'";
            return cdados.listarDados(sql);
        }
    }
}
