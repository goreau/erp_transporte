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

        public Rota()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmRota form)
        {
            try
            {
                string sql = "INSERT INTO `rota`(`nome`, `id_escola`, `km`, `valor_km`) " +
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
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public int Edit(frmRota form)
        {
            try
            {
                string sql = "UPDATE `rota` SET `nome`= @nome, `id_escola`= @escola, `km`= @km, `valor_km`= @valor_km, `updated_at` = CURRENT_TIMESTAMP() " +
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
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public DataTable Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM rota WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível excluir o registro nesse momento. Tente novamente.");
            }

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT r.id, r.nome AS Nome, e.nome AS Escola, km AS Km, valor_km AS 'Valor Km', r.updated_at AS 'Ultima atualização' " +
                "FROM rota r JOIN escola e ON e.id = r.id_escola";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível consultar os registros nesse momento. Tente novamente.");
            }
            

            return dt;
        }

        public DataRow Get(int id)
        {
            DataRow dr = null;
            try
            {
                string sql = "SELECT * FROM rota WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dr = dt.Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível consultar o registro nesse momento. Tente novamente.");
            }
            return dr;
        }

        public DataTable Combo()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            try
            {
                string sql = "SELECT id, nome FROM rota ORDER BY nome";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nome"] = "-- Selecione --";
                dt.Rows.Add(dr);

                dt.DefaultView.Sort = "id";
                dt = dt.DefaultView.ToTable();
            }
            catch (Exception)
            {
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nome"] = "-- Selecione --";
                dt.Rows.Add(dr);

                MessageBox.Show("Nâo foi possível consultar os registros nesse momento. Tente novamente.");
            }

            return dt;
        }
    }
}
