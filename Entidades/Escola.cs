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
    internal class Escola
    {
        MySqlConnection conn = Database.conn;

        private String nome, logradouro, numero, bairro, telefone, telefone2, entrada, saida, especial, link;
        private int periodo;

        public Escola()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            
        }

        public int Add(frmEscola form)
        {
            string sql = "INSERT INTO `escola`(`nome`, `logradouro`, `numero`, `bairro`, `telefone`, `telefone2`, `periodo`, `entrada`, `saida`, `especial`, `link`) " +
                "VALUES (@nome, @logradouro, @numero, @bairro, @telefone, @telefone2, @periodo, @entrada, @saida, @especial, @link)";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);
            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);
            cmd.Parameters.AddWithValue("@telefone", form.Controls["txtTelefone1"].Text);
            cmd.Parameters.AddWithValue("@telefone2", form.Controls["txtTelefone2"].Text);
            cmd.Parameters.AddWithValue("@periodo", form.Controls["txtPeriodo"].Text);
            cmd.Parameters.AddWithValue("@entrada", form.Controls["txtEntrada"].Text);
            cmd.Parameters.AddWithValue("@saida", form.Controls["txtSaida"].Text);
            cmd.Parameters.AddWithValue("@especial", form.Controls["txtEspecial"].Text);
            cmd.Parameters.AddWithValue("@link", form.Controls["txtLink"].Text);

            return cmd.ExecuteNonQuery();
        }

        public int Edit(frmEscola form)
        {
            string sql = "UPDATE `escola` SET `nome` = @nome, `logradouro` = @logradouro, `numero` = @numero, " +
                "`bairro` = @bairro, `telefone` = @telefone, `telefone2`= @telefone2, `periodo` = @periodo, " +
                "`entrada` =  @entrada, `saida` = @saida, `especial` = @especial, `link` = @link, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);
            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);
            cmd.Parameters.AddWithValue("@telefone", form.Controls["txtTelefone1"].Text);
            cmd.Parameters.AddWithValue("@telefone2", form.Controls["txtTelefone2"].Text);
            cmd.Parameters.AddWithValue("@periodo", form.Controls["txtPeriodo"].Text);
            cmd.Parameters.AddWithValue("@entrada", form.Controls["txtEntrada"].Text);
            cmd.Parameters.AddWithValue("@saida", form.Controls["txtSaida"].Text);
            cmd.Parameters.AddWithValue("@especial", form.Controls["txtEspecial"].Text);
            cmd.Parameters.AddWithValue("@link", form.Controls["txtLink"].Text);

            return cmd.ExecuteNonQuery();
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM escola WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }
            
        public DataTable Consulta()
        {
            string sql = "SELECT * FROM escola";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataSet Combo()
        {
            string sql = "SELECT id, nome FROM escola";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM escola WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}
