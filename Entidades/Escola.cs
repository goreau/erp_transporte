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

     
        public Escola()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            
        }

        public int Add(frmEscola form)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public int Edit(frmEscola form)
        {
            try
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
                string sql = "DELETE FROM escola WHERE id=@id";
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
                string sql = "SELECT id, nome AS Nome, CONCAT(logradouro, ', ', numero, ' - ', bairro) AS Endereço, " +
                "telefone AS Telefone, CASE periodo WHEN 1 THEN 'M' WHEN 2 THEN 'T' ELSE 'I' END AS Período, " +
                "TIME_FORMAT(entrada, '%H %i') AS Entrada, TIME_FORMAT(saida, '%H %i') AS Saída, TIME_FORMAT(especial, '%H %i') AS Especial, " +
                "updated_at AS 'Ultima atualização' FROM escola";

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

        public DataTable Combo()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            try
            {
                string sql = "SELECT id, nome FROM escola ORDER BY nome";

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

        public DataRow Get(int id)
        {
            DataRow dr = null;
            try
            {
                string sql = "SELECT * FROM escola WHERE id=@id";

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
    }
}
