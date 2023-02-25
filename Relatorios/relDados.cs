using ERP_Transporte.Auxiliares;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Transporte.Relatorios
{
    internal class ListaAluno
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Escola { get; set; }
        public string Rota { get; set; }
        public string Periodo { get; set; }

        public DataTable getDados(string filt)
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT " +
                "p.nome, " +
                "concat(p.logradouro, ', ', p.numero, ' - ', p.`bairro`) as endereco, " +
                "e.nome as escola," +
                "r.nome as rota," +
                "(CASE e.`periodo` WHEN 1 THEN 'M' when 2 THEN 'T' ELSE 'I' END) as periodo" +
                "  FROM estudante p join escola e on p.id_escola = e.id join rota r on p.id_rota=r.id " + filt;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
    }

    internal class ListaEscolas
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }


        public DataTable getDados(string filt)
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT " +
                "p.nome, " +
                "concat(p.logradouro, ', ', p.numero, ' - ', p.`bairro`) as endereco, " +
                "p.telefone " +
                "FROM escola p " + filt;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;

        }
    }

    internal class ListaAbastecimento
    {
        public string Veiculo { get; set; }
        public string Km { get; set; }
        public string Combustivel { get; set; }
        public string Data { get; set; }
        public Double Litros { get; set; }
        public Double Unitario { get; set; }
        public Double Total { get; set; }


        public DataTable getDados(string filt)
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT " +
                "modelo as veiculo, " +
                "km, " +
                "case p.combustivel when 1 then 'Etanol' when 2 then 'Gasolina' else 'Diesel' end as combustivel, " +
                "DATE_FORMAT(p.data, '%d/%m/%Y') as data, " +
                "litros, " +
                "valor_litro as unitario, " +
                "CAST(litros * valor_litro as decimal(10,2)) as total " +
                "FROM `abastecimento` p join veiculo v on p.id_veiculo=v.id" + filt +
                " ORDER BY veiculo, data";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;

        }
    }
}
