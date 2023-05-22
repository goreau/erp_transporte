using ERP_Transporte.Auxiliares;
using ERP_Transporte.Views;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public string saveFile(string file)
        {
            try
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory + "Uploads\\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string destFile = Path.Combine(path, Path.GetFileName(file));
                File.Copy(file, destFile, true);
                return destFile;
            }
            catch (Exception)
            {
                return "";
            }
            
        }

        public int Add(frmAbastecimento form)
        {
            try
            {
                string arquivo = form.Controls["txtArquivo"].Text;
                if (arquivo != "")
                {
                    arquivo=this.saveFile(arquivo);
                }

                string sql = "INSERT INTO `abastecimento`( `id_veiculo`, `km`, `id_fornecedor`, `litros`, `valor_litro`, `pagamento`, `vencimento`, `combustivel`, `arquivo`, `data`) " +
                    "VALUES (@veiculo, @km, @fornecedor, @litros, @valor_litro, @pagamento, @vencimento, @combustivel,  @arquivo, @data)";

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
                cmd.Parameters.AddWithValue("@arquivo", arquivo);

                data = "";
                success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
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

        public int Edit(frmAbastecimento form)
        {
            try
            {
                string sqlArquivo = "";
                string arquivo = "";

                if (form.Controls["txtNewFile"].Text == "1")
                {
                    arquivo = form.Controls["txtArquivo"].Text;
                    if (arquivo != "")
                    {
                        arquivo = this.saveFile(arquivo);
                    }
                    sqlArquivo = "`arquivo`=@arquivo, ";
                }


                string sql = "UPDATE `abastecimento` SET `id_veiculo`=@veiculo,`km`=@km,`id_fornecedor`=@fornecedor,`litros`=@litros, `valor_litro`=@valor_litro, " +
                    "`pagamento`=@pagamento,`vencimento`=@vencimento,`combustivel`=@combustivel,"+ sqlArquivo +" `data`=@data, `updated_at` = CURRENT_TIMESTAMP() " +
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
                if (form.Controls["txtNewFile"].Text == "1")
                {
                    cmd.Parameters.AddWithValue("@arquivo", arquivo);
                }

                data = "";
                success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
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
                string sql = "DELETE FROM abastecimento WHERE id=@id";
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
                string sql = "SELECT m.id, CONCAT(v.modelo, '(', v.placa, ')') AS Veículo, km AS Km, f.nome AS fornecedor, m.litros AS Quantidade, m.valor_litro AS 'Valor Litro', CASE m.combustivel WHEN 1 THEN 'Etanol' WHEN 2 THEN 'Gasolina' ELSE 'Diesel' END AS Combustível, CASE m.pagamento WHEN 1 THEN 'Cartão' WHEN 2 THEN 'Dinheiro' ELSE 'Cheque' END AS 'Forma Pgto', " +
                    "DATE_FORMAT(m.vencimento, '%d/%m/%Y') as Vencimento, m.updated_at AS 'Ultima atualização' " +
                    "FROM abastecimento m JOIN veiculo v ON v.id = m.id_veiculo JOIN fornecedor AS f ON f.id = m.id_fornecedor";

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
            DataRow dataRow = null;
            try
            {
                string sql = "SELECT * FROM abastecimento WHERE id=@id";

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
    }
}
