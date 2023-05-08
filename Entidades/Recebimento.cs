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
    internal class Recebimento
    {
        MySqlConnection conn = Database.conn;

        public Recebimento()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmRecebimento form)
        {
            string sql = "INSERT INTO `recebimento`(`id_contrato`, `ano`, `mes`, `valor`, `data`) " +
                "VALUES (@contrato, @ano, @mes, @valor, @data)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@mes", form.Controls["txtMes"].Text);
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEstudante");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@contrato", sel);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
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

        public int Edit(frmRecebimento form)
        {
            string sql = "UPDATE `recebimento` SET `id_contrato`=@contrato,`ano`=@ano,`mes`=@mes,`valor`=@valor, `data`=@data, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);
            cmd.Parameters.AddWithValue("@ano", form.Controls["txtAno"].Text);
            cmd.Parameters.AddWithValue("@mes", form.Controls["txtMes"].Text);
            cmd.Parameters.AddWithValue("@valor", form.Controls["txtValor"].Text.Replace(".", "").Replace(",", "."));

            var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbEstudante");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@contrato", sel);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(form.Controls["txtData"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
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

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM recebimento WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT r.id, t.nome AS Trajeto, e.nome AS Estudante, r.ano AS Ano, r.mes AS Mes, r.valor AS Valor, DATE_FORMAT(r.data, '%d/%m/%Y') AS 'Data', r.updated_at AS 'Ultima atualização' " +
                "FROM recebimento r JOIN contrato c ON c.id = r.id_contrato JOIN estudante e ON c.id_aluno = e.id JOIN rota t ON t.id = e.id_rota";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT r.*, e.id_rota FROM recebimento r JOIN contrato c on r.id_contrato=c.id JOIN estudante e on e.id=c.id_aluno WHERE r.id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataSet Combo()
        {
            string sql = "SELECT id, concat(placa,'-',modelo) as nome FROM recebimento";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }

        public DataRow Recibo(int id)
        {
            string sql = "SELECT r.valor, r.data, c.cpf, e.responsavel as pagador, r.ano, r.mes " +
                "FROM recebimento r join contrato c on r.id_contrato=c.id JOIN estudante e on e.id=c.id_aluno WHERE r.id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}
