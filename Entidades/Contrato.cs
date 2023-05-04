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
    internal class Contrato
    {
        MySqlConnection conn = Database.conn;

        public Contrato()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmPreContrato form)
        {
            string sql = "INSERT INTO `contrato`(`id_aluno`, `logradouro`, `numero`, `bairro`, `nacionalidade`, `dt_nascimento`, `est_civil`, " +
                "`rg`, `emissor`, `cpf`, `profissao`, `naturalidade`, `valor`, `dia`, `trajeto`, `trajeto_esp`, `data`) " +
                "VALUES (@id_aluno, @logradouro, @numero, @bairro, @nacionalidade, @dt_nascimento, @est_civil, " +
                "@rg, @emissor, @cpf, @profissao, @naturalidade, @valor, @dia, @trajeto, @trajeto_esp, @data)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);


            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbAluno");

            cmd.Parameters.AddWithValue("@id_aluno", cmb.SelectedValue);

            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);

            DateTime dt = Convert.ToDateTime(form.Controls["txtDt_nascimento"].Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            cmd.Parameters.AddWithValue("@dt_nascimento", data);
      
            cmd.Parameters.AddWithValue("@naturalidade", form.Controls["txtNaturalidade"].Text);
            cmd.Parameters.AddWithValue("@nacionalidade", form.Controls["txtNacionalidade"].Text);
            cmd.Parameters.AddWithValue("@rg", form.Controls["txtRg"].Text);
            cmd.Parameters.AddWithValue("@emissor", form.Controls["txtEmissor"].Text);
            cmd.Parameters.AddWithValue("@cpf", form.Controls["txtCpf"].Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@profissao", form.Controls["txtProfissao"].Text);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEst_civil");
            cmd.Parameters.AddWithValue("@est_civil", cmb.SelectedIndex);
            
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@dia", form.Controls["txtDia"].Text);

            cmd.Parameters.AddWithValue("@trajeto", form.Controls["txtTrajeto"].Text);

            string aux = form.Controls["txtTrajeto"].Text == "4" ? form.Controls["txtTrajeto_esp"].Text : " ";
            cmd.Parameters.AddWithValue("@trajeto_esp", aux);

            dt = Convert.ToDateTime(form.Controls["txtData"].Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmPreContrato form)
        {
            string sql = "UPDATE `contrato` SET id_aluno=@id_aluno, id_contratante=@id_contratante, logradouro=@logradouro, numero=@numero, bairro=@bairro, nacionalidade=@nacionalidade, dt_nascimento=@dt_nascimento, est_civil=@est_civil, " +
                "rg=@rg, emissor=@emissor, cpf=@cpf, profissao=@profissao,  naturalidade=@naturalidade, valor=@valor, dia=@dia, trajeto=@trajeto, trajeto_esp=@trajeto_esp, data=@data, inativo=@inativo, dt_inativo=@dt_inativo, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbAluno");

            cmd.Parameters.AddWithValue("@id_aluno", cmb.SelectedValue);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbContratante");

            cmd.Parameters.AddWithValue("@id_contratante", cmb.SelectedIndex);

            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);

            DateTime dt = Convert.ToDateTime(form.Controls["txtDt_nascimento"].Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            string data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            cmd.Parameters.AddWithValue("@dt_nascimento", data);

            cmd.Parameters.AddWithValue("@naturalidade", form.Controls["txtNaturalidade"].Text);
            cmd.Parameters.AddWithValue("@nacionalidade", form.Controls["txtNacionalidade"].Text);
            cmd.Parameters.AddWithValue("@rg", form.Controls["txtRg"].Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@emissor", form.Controls["txtEmissor"].Text);
            cmd.Parameters.AddWithValue("@cpf", form.Controls["txtCpf"].Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@profissao", form.Controls["txtProfissao"].Text);

            cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEst_civil");
            cmd.Parameters.AddWithValue("@est_civil", cmb.SelectedIndex);

            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@dia", form.Controls["txtDia"].Text);

            cmd.Parameters.AddWithValue("@trajeto", form.Controls["txtTrajeto"].Text);
            cmd.Parameters.AddWithValue("@trajeto_esp", form.Controls["txtTrajeto_esp"].Text);

            var check = form.Controls.OfType<CheckBox>().FirstOrDefault(r => r.Name == "chkInativo");
            cmd.Parameters.AddWithValue("@inativo", check.Checked);

            dt = Convert.ToDateTime(form.Controls["txtData"].Text);

            // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
            data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

            cmd.Parameters.AddWithValue("@data", data);

            if (check.Checked)
            {
                dt = Convert.ToDateTime(form.Controls["txtDt_inativo"].Text);

                // Cria uma nova cadeia de carecteres colocando os valores da data na ordem aceitada pelo MySQL.
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();

                cmd.Parameters.AddWithValue("@dt_inativo", data);
            }
            else
            {
                cmd.Parameters.AddWithValue("@dt_inativo", null);
            }
            

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
            string sql = "DELETE FROM contrato WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT e.`id`, e.`nome` as 'Nome', CONCAT(e.`logradouro`,', ', e.`numero`, ' - ', e.`bairro`) as 'Endereço', s.nome as 'Escola', (CASE e.`periodo` WHEN 1 THEN 'M' when 2 THEN 'T' ELSE 'I' END) as 'Período', `ra_rg` as 'RA/RG', `dt_nascimento` as 'Nascimento', `pai` as 'Nome Pai', `tel_pai` as 'Tel. do Pai', `mae` as 'Nome Mãe', `tel_mae` as 'Tel da Mãe', " +
                "`responsavel` as 'Responsável', `resp_qualif` as 'Qualificação', `tel_resp` as 'Tel do Responsável', `naturalidade` as 'Naturalidade', `nacionalidade` as 'Nacionalidade', `est_civil` as 'Estado Civil', `rg` as 'RG', `cpf` as 'CPF', r.nome as 'Rota', `obs` as 'Observação', e.`updated_at` as 'Ultima Atualização' " +
                "FROM `contrato` e JOIN escola s on e.id_escola=s.id JOIN rota r on e.id_rota = r.id  ORDER BY id desc";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow ContratoData(int id)
        {
            string sql = "SELECT c.`id`, c.id_aluno as 'id_aluno', CONCAT(c.`logradouro`,', nº ', c.`numero`, ', Bairro: ', `bairro`) as 'Endereco', DATE_FORMAT(dt_nascimento, '%d/%m/%Y') as 'Nascimento',  " +
                "`naturalidade` as 'Naturalidade', `nacionalidade` as 'Nacionalidade', (CASE `est_civil` WHEN 1 THEN 'Solteiro' WHEN 2 THEN 'Casado' WHEN 3 THEN 'União Est' ELSE 'Viúvo' END)  as 'EstadoCivil', `rg` as 'RG', `emissor` as 'Emissor',`cpf` as 'CPF', profissao as 'Profissao', " +
                "c.valor, c.dia, trajeto, trajeto_esp " +
                "FROM `contrato` c  WHERE c.id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
            
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM contrato WHERE id_aluno=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable Combo(int id_rota)
        {
            string sql = "SELECT c.id, a.nome as nome " +
                "FROM contrato c JOIN estudante a on a.id=c.id_aluno WHERE a.id_rota=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id_rota);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable ds = new DataTable();

            da.Fill(ds);

            return ds;
        }
    }
}
