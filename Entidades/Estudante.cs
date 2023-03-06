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
    internal class Estudante
    {
        MySqlConnection conn = Database.conn;

        public Estudante()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmEstudante form)
        {
            string sql = "INSERT INTO `estudante`(`nome`, `logradouro`, `numero`, `bairro`, `id_escola`, `periodo`, `ra_rg`, `dt_nascimento`, `pai`, `tel_pai`, " +
                "`mae`, `tel_mae`, `responsavel`, `resp_qualif`, `tel_resp`, `id_rota`, `obs`, `serie`) " +
                "VALUES (@nome, @logradouro, @numero, @bairro, @id_escola, @periodo, @ra_rg, @dt_nascimento, @pai, @tel_pai, " +
                "@mae, @tel_mae, @responsavel, @resp_qualif, @tel_resp, @id_rota, @obs, @serie)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            
            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);
            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEscola");
            //  DataRowView drv = cmb.SelectedItem as DataRowView;
            //drv.Row["FleetID"].ToString()


            cmd.Parameters.AddWithValue("@id_escola", cmb.SelectedValue);

            cmd.Parameters.AddWithValue("@periodo", form.Controls["txtPeriodo"].Text);
            cmd.Parameters.AddWithValue("@ra_rg", form.Controls["txtRa_rg"].Text);

            DateTime dt = Convert.ToDateTime(form.Controls["txtDt_nascimento"].Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            cmd.Parameters.AddWithValue("@dt_nascimento", data);
            cmd.Parameters.AddWithValue("@pai", form.Controls["txtPai"].Text);
            cmd.Parameters.AddWithValue("@tel_pai", form.Controls["txtTel_pai"].Text);
            cmd.Parameters.AddWithValue("@mae", form.Controls["txtMae"].Text);
            cmd.Parameters.AddWithValue("@tel_mae", form.Controls["txtTel_mae"].Text);
            cmd.Parameters.AddWithValue("@responsavel", form.Controls["txtResponsavel"].Text);
            cmd.Parameters.AddWithValue("@resp_qualif", form.Controls["txtResp_qualif"].Text);
            cmd.Parameters.AddWithValue("@tel_resp", form.Controls["txtTel_resp"].Text);
            cmd.Parameters.AddWithValue("@serie", form.Controls["txtSerie"].Text);
            

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbId_rota");
            cmd.Parameters.AddWithValue("@id_rota", cmb.SelectedValue);
         
            cmd.Parameters.AddWithValue("@obs", form.Controls["txtObs"].Text);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmEstudante form)
        {
            string sql = "UPDATE `estudante` SET`nome` = @nome, `logradouro` = @logradouro, `numero` = @numero, `bairro` = @bairro, `id_escola` = @id_escola, `periodo` = @periodo, `ra_rg` = @ra_rg, `dt_nascimento` = @dt_nascimento, `pai` = @pai, `tel_pai` = @tel_pai, " +
                "`mae` = @mae, `tel_mae` = @tel_mae, `responsavel` = @responsavel, `resp_qualif` = @resp_qualif, `tel_resp` = @tel_resp, `id_rota` = @id_rota, `obs` = @obs, `serie`=@serie, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);
            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEscola");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String esc = drv.Row["id"].ToString();

            cmd.Parameters.AddWithValue("@id_escola", esc);
            cmd.Parameters.AddWithValue("@periodo", form.Controls["txtPeriodo"].Text);
            cmd.Parameters.AddWithValue("@ra_rg", form.Controls["txtRa_rg"].Text);

            DateTime dt = Convert.ToDateTime(form.Controls["txtDt_nascimento"].Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            cmd.Parameters.AddWithValue("@dt_nascimento", data);
            cmd.Parameters.AddWithValue("@pai", form.Controls["txtPai"].Text);
            cmd.Parameters.AddWithValue("@tel_pai", form.Controls["txtTel_pai"].Text);
            cmd.Parameters.AddWithValue("@mae", form.Controls["txtMae"].Text);
            cmd.Parameters.AddWithValue("@tel_mae", form.Controls["txtTel_mae"].Text);
            cmd.Parameters.AddWithValue("@responsavel", form.Controls["txtResponsavel"].Text);
            cmd.Parameters.AddWithValue("@resp_qualif", form.Controls["txtResp_qualif"].Text);
            cmd.Parameters.AddWithValue("@tel_resp", form.Controls["txtTel_resp"].Text);
            cmd.Parameters.AddWithValue("@serie", form.Controls["txtSerie"].Text);


            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbId_rota");
            cmd.Parameters.AddWithValue("@id_rota", cmb.SelectedValue);

            cmd.Parameters.AddWithValue("@obs", form.Controls["txtObs"].Text);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM estudante WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT e.`id`, e.`nome` as 'Nome', CONCAT(e.`logradouro`,', ', e.`numero`, ' - ', e.`bairro`) as 'Endereço', s.nome as 'Escola', (CASE e.`periodo` WHEN 1 THEN 'M' when 2 THEN 'T' ELSE 'I' END) as 'Período', `ra_rg` as 'RA/RG', `dt_nascimento` as 'Nascimento', `pai` as 'Nome Pai', `tel_pai` as 'Tel. do Pai', `mae` as 'Nome Mãe', `tel_mae` as 'Tel da Mãe', " +
                "`responsavel` as 'Responsável', `resp_qualif` as 'Qualificação', `tel_resp` as 'Tel do Responsável', r.nome as 'Rota', `obs` as 'Observação', e.`updated_at` as 'Ultima Atualização' " +
                "FROM `estudante` e JOIN escola s on e.id_escola=s.id JOIN rota r on e.id_rota = r.id  ORDER BY id desc";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Contrato(int id)
        {
            string sql = "SELECT e.`id`, e.`nome` as 'Nome', s.nome as 'Escola', s.telefone as 'TelEscola', CONCAT(s.`logradouro`,', nº ', s.`numero`, ', Bairro: ', s.`bairro`) as 'EndEscola',  e.`periodo` as 'Periodo', `ra_rg` as 'RA', `dt_nascimento` as 'Nascimento', `pai` as 'NomePai', `tel_pai` as 'TelPai', `mae` as 'NomeMae', `tel_mae` as 'TelMae', " +
                "`responsavel` as 'NomeResp', `resp_qualif` as 'Qualificacao', `tel_resp` as 'TelResp',  " +
                "r.nome as 'Rota', e.resp_nasc as 'RespNasc', s.entrada, s.saida, e.serie " +
                "FROM `estudante` e JOIN escola s on e.id_escola=s.id JOIN rota r on e.id_rota = r.id  WHERE e.id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM estudante WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataTable Combo(int rt)
        {
            string sql = "SELECT id, nome FROM estudante where id_rota = @rota ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@rota", rt);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

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

        public DataTable Combo()
        {
            string sql = "SELECT id, nome FROM estudante ORDER BY nome";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

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
