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
    internal class Veiculo
    {
        MySqlConnection conn = Database.conn;

        public Veiculo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmVeiculo form)
        {
            try
            {
                string sql = "INSERT INTO `veiculo`(`placa`, `modelo`, `ano`, `renavam`, `capacidade`, `combustivel`, `valor`, `entrada`, `oleo`, `filtros`, `licenciamento`) " +
                "VALUES (@placa, @modelo, @ano, @renavam, @capacidade, @combustivel, @valor, @entrada, @oleo, @filtros, @licenciamento)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                cmd.Parameters.AddWithValue("@placa", form.Controls["txtPlaca"].Text);
                cmd.Parameters.AddWithValue("@modelo", form.Controls["txtModelo"].Text);
                cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
                cmd.Parameters.AddWithValue("@renavam", form.Controls["txtRenavam"].Text);
                cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
                cmd.Parameters.AddWithValue("@capacidade", form.Controls["txtCapacidade"].Text);
                cmd.Parameters.AddWithValue("@combustivel", form.Controls["txtCombustivel"].Text);

                // DateTime? dt = null;
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(form.Controls["txtEntrada"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
            
                cmd.Parameters.AddWithValue("@entrada", data);

                cmd.Parameters.AddWithValue("@oleo", form.Controls["txtOleo"].Text);
                cmd.Parameters.AddWithValue("@filtros", form.Controls["txtFiltros"].Text);

                success = DateTime.TryParse(form.Controls["txtLicenciamento"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }

                cmd.Parameters.AddWithValue("@licenciamento", data);

            
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public int Edit(frmVeiculo form)
        {
            try
            {
                string sql = "UPDATE `veiculo` SET `placa`= @placa, `modelo`= @modelo, `ano`= @ano, `renavam`= @renavam, `capacidade`= @capacidade, `combustivel`= @combustivel, " +
                    "`valor`= @valor, `entrada`= @entrada, `oleo`= @oleo, `filtros`= @filtros, `licenciamento`= @licenciamento, `updated_at` = CURRENT_TIMESTAMP() " +
                    " WHERE id = @id";
                                                                                                                                                                                                     
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
                cmd.Parameters.AddWithValue("@placa", form.Controls["txtPlaca"].Text);
                cmd.Parameters.AddWithValue("@modelo", form.Controls["txtModelo"].Text);
                cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
                cmd.Parameters.AddWithValue("@renavam", form.Controls["txtRenavam"].Text);
                cmd.Parameters.AddWithValue("@capacidade", form.Controls["txtCapacidade"].Text);
                cmd.Parameters.AddWithValue("@combustivel", form.Controls["txtCombustivel"].Text);
                cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

                DateTime dt = Convert.ToDateTime(form.Controls["txtEntrada"].Text);
                string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                cmd.Parameters.AddWithValue("@entrada", data);

                cmd.Parameters.AddWithValue("@oleo", form.Controls["txtOleo"].Text);
                cmd.Parameters.AddWithValue("@filtros", form.Controls["txtFiltros"].Text);

                dt = Convert.ToDateTime(form.Controls["txtLicenciamento"].Text);
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                cmd.Parameters.AddWithValue("@licenciamento", data);

            
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
                string sql = "DELETE FROM veiculo WHERE id=@id";
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
                string sql = "SELECT id, placa AS Placa, modelo AS Modelo, ano AS Ano, renavam AS Renavam, capacidade AS Capacidade, " +
                                "CASE combustivel WHEN 1 THEN 'Etanol' WHEN 2 THEN 'Gasolina' WHEN 3 THEN 'Diesel' ELSE 'Flex' END AS Combustível, " +
                                "valor AS Valor, updated_at AS 'Ultima atualização' " +
                                "FROM veiculo";

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
                string sql = "SELECT * FROM veiculo WHERE id=@id";

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

        public DataTable Combo()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;

            try
            {
                string sql = "SELECT id, concat(placa,'-',modelo) as nome FROM veiculo";

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
    }
}
