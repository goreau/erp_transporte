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
    internal class PrevisaoRecurso
    {
        public string Trajeto { get; set; }
        public double Jan { get; set; }
        public double Fev { get; set; }
        public double Mar { get; set; }
        public double Abr { get; set; }
        public double Mai { get; set; }
        public double Jun { get; set; }
        public double Jul { get; set; }
        public double Ago { get; set; }
        public double Set { get; set; }
        public double Out { get; set; }
        public double Nov { get; set; }
        public double Dez { get; set; }

        public DataTable getDados(string filt)
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT r.nome as trajeto," +
                "sum(CASE WHEN MONTH(p.`data`) <= 1 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 1) THEN p.valor ELSE 0 END) AS jan, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 2 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 2) THEN p.valor ELSE 0 END) AS fev, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 3 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 3) THEN p.valor ELSE 0 END) AS mar, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 4 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 4) THEN p.valor ELSE 0 END) AS abr, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 5 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 5) THEN p.valor ELSE 0 END) AS mai, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 6 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 6) THEN p.valor ELSE 0 END) AS jun, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 7 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 7) THEN p.valor ELSE 0 END) AS jul, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 8 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 8) THEN p.valor ELSE 0 END) AS ago, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 9 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 9) THEN p.valor ELSE 0 END) AS 'set', " +
                "sum(CASE WHEN MONTH(p.`data`) <= 10 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 10) THEN p.valor ELSE 0 END) AS 'out', " +
                "sum(CASE WHEN MONTH(p.`data`) <= 11 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 11) THEN p.valor ELSE 0 END) AS nov, " +
                "sum(CASE WHEN MONTH(p.`data`) <= 12 AND(dt_inativo IS NULL OR MONTH(dt_inativo) > 12) THEN p.valor ELSE 0 END) AS dez " +
                "FROM contrato p JOIN estudante e ON p.id_aluno = e.id JOIN rota r ON r.id = e.id_rota WHERE YEAR(p.`data`)= 2023 ";// + filt;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
    internal class RendimentoRota 
    { 
        public string Trajeto { get; set; }
        public int Estudantes { get; set; }
        public double Receita { get; set; }
        public double Previsto { get; set; }


        public DataTable getDados(string filt)
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT p.nome AS trajeto, COUNT(e.id) AS estudantes, SUM(r.valor) AS receita, SUM(c.valor) AS previsto " +
                "FROM rota p JOIN estudante e ON e.id_rota = p.id JOIN contrato c ON c.id_aluno = e.id " +
                "JOIN recebimento r ON r.id_contrato = c.id " + filt;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }


    internal class DadosEmpresa
    {
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Telefone1 { get; set; }
        public string Contato1 { get; set; }
        public string Telefone2 { get; set; }
        public string Contato2 { get; set; }

        public DataTable getDados()
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT nome,nome_fantasia as fantasia,cnpj,cidade,logradouro,numero,uf,bairro,telefone1,contato1,telefone2,contato2 " +
                "FROM empresa ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
    internal class ManutencaoMaster
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime Data { get; set; }
        public string Prestador { get; set; }
        public int Km { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public DataTable getDados(string filt)
        {
            MySqlConnection conn = Database.conn;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string sql = "SELECT " +
                "v.placa, " +
                "v.modelo, " +
                "DATE_FORMAT(p.data, '%d/%m/%Y') as data, " +
                "f.nome AS prestador, " +
                "p.km, " +
                "p.descricao, " +
                "p.valor " +
                "FROM manutencao p JOIN veiculo v ON p.id_veiculo = v.id JOIN fornecedor f ON p.id_fornecedor = f.id " + filt;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
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
