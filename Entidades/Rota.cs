using ERP_Transporte.Auxiliares;
using ERP_Transporte.Views;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Transporte.Entidades
{
    internal class Rota
    {
        MySqlConnection conn = Database.conn;

        private String id, nome, logradouro, numero, bairro, ra_rg, dt_nascimento, pai, tel_pai, mae, tel_mae, responsavel, resp_qualif, tel_resp, naturalidade, nacionalidade, rg, cpf, obs;
        private int id_escola, est_civil, id_rota, periodo;

        public Rota()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmRota form)
        {
            string sql = "INSERT INTO `rota`(`nome`, `escola`, `km`, `valor_km`) " +
                "VALUES (@nome, @escola, @km, @valor_km)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEscola");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@escola", sel);

            cmd.Parameters.AddWithValue("@km", form.Controls["txtKm"].Text);
            cmd.Parameters.AddWithValue("@valor_km", form.Controls["txtValor_km"].Text.Replace(".", "").Replace(",", "."));

            return cmd.ExecuteNonQuery();
        }

        public int Edit(frmRota form)
        {
            string sql = "UPDATE `rota` SET `nome`= @nome, `escola`= @escola, `km`= @km, `valor_km`= @valor_km, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEscola");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@escola", sel);

            cmd.Parameters.AddWithValue("@km", form.Controls["txtKm"].Text);
            cmd.Parameters.AddWithValue("@valor_km", form.Controls["txtValor_km"].Text.Replace(".", "").Replace(",", "."));


            return cmd.ExecuteNonQuery();
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM rota WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM rota";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM rota WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataSet Combo()
        {
            string sql = "SELECT id, nome FROM rota";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }
    }
}
