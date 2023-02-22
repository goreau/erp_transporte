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
    internal class Abastecimento
    {
        MySqlConnection conn = Database.conn;

        public Abastecimento()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmAbastecimento form)
        {       
            string sql = "INSERT INTO `abastecimento`( `veiculo`, `km`, `fornecedor`, `litros`, `valor_litro`, `pagamento`, `vencimento`, `combustivel`, `arquivo`) " +
                "VALUES (@veiculo, @km, @fornecedor, @litros, @valor_litro, @pagamento, @vencimento, @combustivel,  @arquivo)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbVeiculo");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@veiculo", sel);

            cmd.Parameters.AddWithValue("@litros", form.Controls["txtLitros"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@valor_litro", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@km", form.Controls["txtKm"].Text);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@fornecedor", sel);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtVencimento"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            cmd.Parameters.AddWithValue("@vencimento", data);

            cmd.Parameters.AddWithValue("@pagamento", form.Controls["txtPagamento"].Text);
            cmd.Parameters.AddWithValue("@combustivel", form.Controls["txtCombustivel"].Text);
            cmd.Parameters.AddWithValue("@arquivo", form.Controls["txtArquivo"].Text);


            return cmd.ExecuteNonQuery();
        }

        public int Edit(frmAbastecimento form)
        {
            string sql = "UPDATE `abastecimento` SET `veiculo`=@veiculo,`km`=@km,`fornecedor`=@fornecedor,`litros`=@litros, `valor_litro`=@valor_litro, " +
                "`pagamento`=@pagamento,`vencimento`=@vencimento,`combustivel`=@combustivel,`arquivo`=@arquivo, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbVeiculo");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@veiculo", sel);

            cmd.Parameters.AddWithValue("@litros", form.Controls["txtLitros"].Text.Replace(".","").Replace(",", "."));
            cmd.Parameters.AddWithValue("@valor_litro", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@km", form.Controls["txtKm"].Text);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@fornecedor", sel);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtVencimento"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            cmd.Parameters.AddWithValue("@vencimento", data);

            cmd.Parameters.AddWithValue("@pagamento", form.Controls["txtPagamento"].Text);
            cmd.Parameters.AddWithValue("@combustivel", form.Controls["txtCombustivel"].Text);
            cmd.Parameters.AddWithValue("@arquivo", form.Controls["txtArquivo"].Text);

            return cmd.ExecuteNonQuery();
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM abastecimento WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM abastecimento";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM abastecimento WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}
