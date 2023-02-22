using ERP_Transporte.Auxiliares;
using ERP_Transporte.Views;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Transporte.Entidades
{
    internal class Veiculo
    {
        MySqlConnection conn = Database.conn;

        private String id, nome, logradouro, numero, bairro, ra_rg, dt_nascimento, pai, tel_pai, mae, tel_mae, responsavel, resp_qualif, tel_resp, naturalidade, nacionalidade, rg, cpf, obs;
        private int id_escola, est_civil, id_rota, periodo;

        public Veiculo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmVeiculo form)
        {
            string sql = "INSERT INTO `veiculo`(`placa`, `modelo`, `ano`, `renavam`, `capacidade`, `combustivel`, `valor`, `entrada`, `oleo`, `filtros`, `licenciamento`) " +
                "VALUES (@placa, @modelo, @ano, @renavam, @capacidade, @combustivel, @valor, @entrada, @oleo, @filtros, @licenciamento)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            cmd.Parameters.AddWithValue("@placa", form.Controls["txtPlaca"].Text);
            cmd.Parameters.AddWithValue("@modelo", form.Controls["txtModelo"].Text);
            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@renavam", form.Controls["txtRenavam"].Text);
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@capacidade", form.Controls["txtCapacidade"].Text);
            cmd.Parameters.AddWithValue("@combustivel", form.Controls["txtCombustivel"].Text);

            // DateTime? dt = null;
            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtEntrada"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            
            cmd.Parameters.AddWithValue("@entrada", data);

            cmd.Parameters.AddWithValue("@oleo", form.Controls["txtOleo"].Text);
            cmd.Parameters.AddWithValue("@filtros", form.Controls["txtFiltros"].Text);

            success = DateTime.TryParse(form.Controls["txtLicenciamento"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }

            cmd.Parameters.AddWithValue("@licenciamento", data);

            return cmd.ExecuteNonQuery();
        }

        public int Edit(frmVeiculo form)
        {
            string sql = "UPDATE `veiculo` SET `placa`= @placa, `modelo`= @modelo, `ano`= @ano, `renavam`= @renavam, `capacidade`= @capacidade, `combustivel`= @combustivel, " +
                "`valor`= @valor, `entrada`= @entrada, `oleo`= @oleo, `filtros`= @filtros, `licenciamento`= @licenciamento, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";
                                                                                                                                                                                                     
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
            cmd.Parameters.AddWithValue("@placa", form.Controls["txtPlaca"].Text);
            cmd.Parameters.AddWithValue("@modelo", form.Controls["txtModelo"].Text);
            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@renavam", form.Controls["txtRenavam"].Text);
            cmd.Parameters.AddWithValue("@capacidade", form.Controls["txtCapacidade"].Text);
            cmd.Parameters.AddWithValue("@combustivel", form.Controls["txtCombustivel"].Text);
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

            DateTime dt = Convert.ToDateTime(form.Controls["txtEntrada"].Text);
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            cmd.Parameters.AddWithValue("@entrada", data);

            cmd.Parameters.AddWithValue("@oleo", form.Controls["txtOleo"].Text);
            cmd.Parameters.AddWithValue("@filtros", form.Controls["txtFiltros"].Text);

            dt = Convert.ToDateTime(form.Controls["txtLicenciamento"].Text);
            data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            cmd.Parameters.AddWithValue("@licenciamento", data);

            return cmd.ExecuteNonQuery();
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM veiculo WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM veiculo";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM veiculo WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataSet Combo()
        {
            string sql = "SELECT id, concat(placa,'-',modelo) as nome FROM veiculo";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }
    }
}
