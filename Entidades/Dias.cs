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
    internal class Dias
    {
        MySqlConnection conn = Database.conn;

       
        public Dias()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmDias form)
        {
            string sql = "INSERT INTO `dias_letivos`( `rota`, `ano`, `mes`, `dias`) " +
                "VALUES (@rota, @ano, @mes, @dias)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbRota");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@rota", sel);

            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@mes", form.Controls["txtMes"].Text);
            cmd.Parameters.AddWithValue("@dias", form.Controls["txtDias"].Text);
            

            return cmd.ExecuteNonQuery();
        }

        public int Edit(frmDias form)
        {
            string sql = "UPDATE `dias_letivos` SET `rota`=@rota,`ano`=@ano,`mes`=@mes,`dias`=@dias, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbRota");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@rota", sel);

            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@mes", form.Controls["txtMes"].Text);
            cmd.Parameters.AddWithValue("@dias", form.Controls["txtDias"].Text);


            return cmd.ExecuteNonQuery();
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM dias_letivos WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM dias_letivos";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM dias_letivos WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}
