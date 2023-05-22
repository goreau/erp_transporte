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
    internal class Manutencao
    {
        MySqlConnection conn = Database.conn;

        public Manutencao()
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

        public int Add(frmManutencao form)
        {
            try
            {
                string arquivo = form.Controls["txtArquivo"].Text;
                if (arquivo != "")
                {
                    arquivo = this.saveFile(arquivo);
                }

                string sql = "INSERT INTO `manutencao`( `id_veiculo`, `km`, `id_fornecedor`, `valor`, `pagamento`, `vencimento`, `descricao`, `arquivo`, `data`) " +
                    "VALUES (@veiculo, @km, @fornecedor, @valor, @pagamento, @vencimento, @descricao,  @arquivo, @data)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbVeiculo");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();

                cmd.Parameters.AddWithValue("@veiculo", sel);
            
                cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
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
                cmd.Parameters.AddWithValue("@descricao", form.Controls["txtDescricao"].Text);
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

        public int Edit(frmManutencao form)
        {
            string sqlArquivo = "";
            string arquivo = "";

            try
            {
                if (form.Controls["txtNewFile"].Text == "1")
                {
                    arquivo = form.Controls["txtArquivo"].Text;
                    if (arquivo != "")
                    {
                        arquivo = this.saveFile(arquivo);
                    }
                    sqlArquivo = "`arquivo`=@arquivo, ";
                }
            
            
                string sql = "UPDATE `manutencao` SET `id_veiculo`=@veiculo,`km`=@km,`id_fornecedor`=@fornecedor,`valor`=@valor," +
                    "`pagamento`=@pagamento,`vencimento`=@vencimento,`descricao`=@descricao, "+ sqlArquivo +"`data`=@data, `updated_at` = CURRENT_TIMESTAMP() " +
                    " WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

                var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbVeiculo");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();

                cmd.Parameters.AddWithValue("@veiculo", sel);

                cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", ".")                                                        );
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
                cmd.Parameters.AddWithValue("@descricao", form.Controls["txtDescricao"].Text);
            
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
                string sql = "DELETE FROM manutencao WHERE id=@id";
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
                string sql = "SELECT m.id, CONCAT(v.modelo, '(', v.placa, ')') AS Veículo, km AS Km, f.nome AS Fornecedor, m.valor AS Valor, CASE m.pagamento WHEN 1 THEN 'Cartão' WHEN 2 THEN 'Dinheiro' ELSE 'Cheque' END AS 'Forma Pgto', " +
                    "DATE_FORMAT(m.vencimento, '%d/%m/%Y') as Vencimento, m.updated_at AS 'Ultima atualização' " +
                    "FROM manutencao m JOIN veiculo v ON v.id = m.id_veiculo JOIN fornecedor AS f ON f.id = m.id_fornecedor";

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
                string sql = "SELECT * FROM manutencao WHERE id=@id";

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
