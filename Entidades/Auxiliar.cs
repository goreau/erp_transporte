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
    internal class Auxiliar
    {
        MySqlConnection conn = Database.conn;

        public Auxiliar()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmAuxiliar form)
        {
            string sql = "INSERT INTO `auxiliar`(`nome`, `tipo`) " +
                "VALUES (@nome, @tipo)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

            cmd.Parameters.AddWithValue("@tipo", form.Controls["txtTipo"].Text);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmAuxiliar form, int id)
        {
            string sql = "UPDATE `auxiliar` SET `nome`= @nome, `tipo`= @tipo, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

            cmd.Parameters.AddWithValue("@tipo", form.Controls["txtTipo"].Text);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Delete(int id)
        {
            string sql = "DELETE FROM auxiliar WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery();

        }

        public DataTable Consulta(int tp)
        {
            string sql = "SELECT * FROM auxiliar where tipo = @tp";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@tp", tp);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM auxiliar WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataTable Combo(int tp)
        {
            string sql = "SELECT id, nome FROM auxiliar WHERE tipo=@tp";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            cmd.Parameters.AddWithValue("@tp", tp);

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
