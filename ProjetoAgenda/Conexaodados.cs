using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class Conexaodados
    {
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private string campos = "";

        public string Campos { get => campos; set => campos = value; }

        public void conectar()
        {
            string aux = "Server =.\\SQLEXPRESS; Database = Agenda; UID = sa; PWD = 123; ";
            conn.ConnectionString = aux;
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
        }

        public void executar(string sql)
        {
            conectar();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }

        public void consultaID(string sql)
        {
            conectar();
            campos = null;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    campos += dr[i].ToString() + ";";
                }
            }
            desconectar();
        }

        public DataSet listarDados(string sql)
        {
            conectar();
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            desconectar();
            return ds;
        }
    }
}
