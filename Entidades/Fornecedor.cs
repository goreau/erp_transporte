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
            try
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

                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public int Edit(frmFornecedor form)
        {
            try
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
                string sql = "DELETE FROM fornecedor WHERE id=@id";
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
            string sql = "SELECT f.id, f.nome AS Nome, telefone AS Telefone, a.nome AS Categoria, f.updated_at AS 'Ultima atualização' " +
                "FROM fornecedor f JOIN auxiliar a ON a.id = f.categoria";

            DataTable dt = new DataTable();
            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível consultar os fornecedores nesse momento.");
            }

            return dt;
        }

        public DataRow Get(int id)
        {
            DataRow dataRow = null;
            try
            {
                string sql = "SELECT * FROM fornecedor WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataRow = dt.Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível recuperar o registro nesse momento. Tente novamente.");
            }


            return dataRow;
        }

        public DataTable Combo()
        {
            string sql = "SELECT id, nome FROM fornecedor ORDER BY nome";
            DataTable dt = new DataTable();
            DataRow dr = null;
            try
            {

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

                MessageBox.Show("Nâo foi possível consultar os fornecedores nesse momento.");
            }

            return dt;
        }
    }
}
