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
    internal class Pagamento
    {
        MySqlConnection conn = Database.conn;

        public Pagamento()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmPagamento form)
        {
            try
            {
                string sql = "INSERT INTO `pagamento`(`dia_vencimento`, `id_fornecedor`, `categoria`, `vinculo`, `valor`, `recorrente`, `data`) " +
                    "VALUES (@dia_vencimento, @fornecedor, @categoria, @vinculo, @valor, @recorrente, @data)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                cmd.Parameters.AddWithValue("@dia_vencimento", form.Controls["txtDia_vencimento"].Text);

                var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@fornecedor", sel);

                cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
                drv = cmb.SelectedItem as DataRowView;
                sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@categoria", sel);

                cmd.Parameters.AddWithValue("@vinculo", form.Controls["txtVinculo"].Text);
                cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

                var check = form.Controls.OfType<CheckBox>().FirstOrDefault(r => r.Name == "recorrente");
                cmd.Parameters.AddWithValue("@recorrente", check.Checked);

                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@data", data);

           
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public int Edit(frmPagamento form)
        {
            try
            {
                string sql = "UPDATE `pagamento` SET `dia_vencimento`=@dia_vencimento,`id_fornecedor`=@fornecedor,`categoria`=@categoria," +
                    "`vinculo`=@vinculo,`valor`=@valor,`recorrente`=@recorrente, `data`=@data, `updated_at` = CURRENT_TIMESTAMP() " +
                    " WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
           
                cmd.Parameters.AddWithValue("@dia_vencimento", form.Controls["txtDia_vencimento"].Text);

                var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@fornecedor", sel);

                cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
                drv = cmb.SelectedItem as DataRowView;
                sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@categoria", sel);

                cmd.Parameters.AddWithValue("@vinculo", form.Controls["txtVinculo"].Text);
                cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

                var check = form.Controls.OfType<CheckBox>().FirstOrDefault(r => r.Name == "recorrente");
                cmd.Parameters.AddWithValue("@recorrente", check.Checked);

                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@data", data);

            
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
                string sql = "DELETE FROM pagamento WHERE id=@id";
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
                string sql = "SELECT p.id, p.dia_vencimento AS 'Dia Vcto', f.nome AS Fornecedor, a.nome AS Categoria, p.valor AS Valor, p.data AS 'Data', p.updated_at AS 'Ultima atualização' " +
                                "FROM pagamento p JOIN fornecedor f ON f.id = p.id_fornecedor JOIN auxiliar a ON a.id = p.categoria";

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
                string sql = "SELECT * FROM pagamento WHERE id=@id";

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

        public DataSet Combo()
        {
            DataSet ds = new DataSet();

            try
            {
                string sql = "SELECT id, concat(placa,'-',modelo) as nome FROM pagamento";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível consultar os registros nesse momento. Tente novamente.");
            }
            

            return ds;
        }
    }
}
