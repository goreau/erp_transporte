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
    internal class Trafego
    {
        MySqlConnection conn = Database.conn;

        private String id, nome, logradouro, numero, bairro, ra_rg, dt_nascimento, pai, tel_pai, mae, tel_mae, responsavel, resp_qualif, tel_resp, naturalidade, nacionalidade, rg, cpf, obs;
        private int id_escola, est_civil, id_trafego, periodo;

        public Trafego()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmTrafego form)
        {
            string sql = "INSERT INTO `trafego`(`veiculo`, `data`, `motivo`, `partida`, `km_partida`, `chegada`, `km_chegada`, `fornecedor`, `valor`, `km`, `litros`) " +
                "VALUES (@veiculo, @data, @motivo, @partida, @km_partida, @chegada, @km_chegada, @fornecedor, @valor, @km, @litros)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbVeiculo");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@veiculo", sel);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            cmd.Parameters.AddWithValue("@data", data);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbMotivo");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@motivo", sel);

            cmd.Parameters.AddWithValue("@partida", form.Controls["txtPartida"].Text);
            cmd.Parameters.AddWithValue("@km_partida", form.Controls["txtKm_partida"].Text);
            cmd.Parameters.AddWithValue("@chegada", form.Controls["txtChegada"].Text);
            cmd.Parameters.AddWithValue("@km_chegada", form.Controls["txtKm_chegada"].Text);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@fornecedor", sel);

            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@km", form.Controls["txtKm"].Text);
            cmd.Parameters.AddWithValue("@litros", form.Controls["txtLitros"].Text.Replace(".", "").Replace(",", "."));

            return cmd.ExecuteNonQuery();
        }

        public int Edit(frmTrafego form)
        {
            string sql = "UPDATE `trafego` SET `veiculo`=@veiculo,`data`=@data,`motivo`=@motivo,`partida`=@partida,`km_partida`=@km_partida," +
                "`chegada`=@chegada,`km_chegada`=@km_chegada,`fornecedor`=@fornecedor,`valor`=@valor,`km`=@km,`litros`=@litros, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbVeiculo");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@veiculo", sel);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            cmd.Parameters.AddWithValue("@data", data);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbMotivo");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@motivo", sel);

            cmd.Parameters.AddWithValue("@partida", form.Controls["txtPartida"].Text);
            cmd.Parameters.AddWithValue("@km_partida", form.Controls["txtKm_partida"].Text);
            cmd.Parameters.AddWithValue("@chegada", form.Controls["txtChegada"].Text);
            cmd.Parameters.AddWithValue("@km_chegada", form.Controls["txtKm_chegada"].Text);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@fornecedor", sel);

            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@km", form.Controls["txtKm"].Text);
            cmd.Parameters.AddWithValue("@litros", form.Controls["txtLitros"].Text.Replace(".", "").Replace(",", "."));


            return cmd.ExecuteNonQuery();
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM trafego WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT * FROM trafego";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM trafego WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}
