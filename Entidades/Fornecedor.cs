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
    internal class Fornecedor
    {
        MySqlConnection conn = Database.conn;

        public Fornecedor()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmFornecedor form)
        {
            string sql = "INSERT INTO `fornecedor`(`nome`, `telefone`, `categoria`) " +
                "VALUES (@nome, @telefone, @categoria)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@categoria", sel);

            cmd.Parameters.AddWithValue("@telefone", form.Controls["txtTelefone"].Text);


            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmFornecedor form)
        {
            string sql = "UPDATE `fornecedor` SET `nome`= @nome, `telefone`= @telefone, `categoria`= @categoria, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@categoria", sel);

            cmd.Parameters.AddWithValue("@telefone", form.Controls["txtTelefone"].Text);

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
            string sql = "DELETE FROM fornecedor WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM fornecedor";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM fornecedor WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataTable Combo()
        {
            string sql = "SELECT id, nome FROM fornecedor ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["id"] = 0;
            dr["nome"] = "-- Selecione --";
            dt.Rows.Add(dr);

            dt.DefaultView.Sort = "id";
            dt = dt.DefaultView.ToTable();


            return dt;
        }
    }
}
