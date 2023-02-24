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
    internal class Recebimento
    {
        MySqlConnection conn = Database.conn;

        public Recebimento()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmRecebimento form)
        {
            string sql = "INSERT INTO `recebimento`(`id_rota`, `ano`, `mes`, `valor`) " +
                "VALUES (@rota, @ano, @mes, @valor)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@mes", form.Controls["txtMes"].Text);
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbRota");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@rota", sel);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmRecebimento form)
        {
            string sql = "UPDATE `recebimento` SET `id_rota`=@rota,`ano`=@ano,`mes`=@mes,`valor`=@valor,`updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@mes", form.Controls["txtMes"].Text);
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbRota");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@rota", sel);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM recebimento WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM recebimento";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM recebimento WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataSet Combo()
        {
            string sql = "SELECT id, concat(placa,'-',modelo) as nome FROM recebimento";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }
    }
}
