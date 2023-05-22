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
    internal class Despesa
    {
        MySqlConnection conn = Database.conn;

        public Despesa()
        {
          /*  if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }*/

        }

        public int Add(frmDespesa form, DataTable table)
        {
            string sql = "INSERT INTO `despesa`(`data`, `id_fornecedor`, `id_categoria`, `notaFiscal`, `valor`, `id_tipo`, `id_metodo`, `descricao`) " +
                "VALUES (@data, @fornecedor, @categoria, @nota, @valor, @tipo, @metodo, @descricao)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql);
                MySqlTransaction trans;
    
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                } 
            

                trans = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                SplitContainer sc = (SplitContainer) form.Controls["splitContainer1"];
                Control.ControlCollection colec = sc.Panel1.Controls;


                var cmb = colec.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@fornecedor", sel);

                cmb = colec.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
                drv = cmb.SelectedItem as DataRowView;
                sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@categoria", sel);

                cmd.Parameters.AddWithValue("@tipo", colec["txtTipoPgto"].Text);
                cmd.Parameters.AddWithValue("@metodo", colec["txtMetodoPgto"].Text);
                cmd.Parameters.AddWithValue("@valor", colec["txtValor"].Text.Replace(".", "").Replace(",", "."));
                cmd.Parameters.AddWithValue("@descricao", colec["txtDescricao"].Text);

                cmd.Parameters.AddWithValue("@nota", colec["txtNF"].Text);

                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(colec["txtData"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@data", data);

            
                cmd.ExecuteNonQuery();
                long id =  cmd.LastInsertedId;

                foreach (DataRow r in table.Rows)
                {
                    int ret = this.AddDetail(r, id, trans);
                    if (ret == 0)
                    {
                        trans.Rollback();
                        return 0;
                    }
                }
                trans.Commit();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int AddDetail(DataRow dr, long id, MySqlTransaction trans)
        {
            string sql = "INSERT INTO `despesa_item`(`id_despesa`, `parcela`, `vencimento`, `valor`) " +
                "VALUES (@master, @parcela, @vencimento, @valor)";

            MySqlCommand cmd = new MySqlCommand(sql, conn, trans);

            cmd.Parameters.AddWithValue("@master", id);
            cmd.Parameters.AddWithValue("@parcela",dr["parcela"]);
            cmd.Parameters.AddWithValue("@valor", dr["valor"].ToString().Replace(".", "").Replace(",", "."));

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(dr["vencimento"].ToString(), out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            cmd.Parameters.AddWithValue("@vencimento", data);

            try
            {

                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int DeleteDetail(long desp, MySqlTransaction trans)
        {
            string sql = "DELETE FROM `despesa_item` WHERE id_despesa=@desp";

            MySqlCommand cmd = new MySqlCommand(sql, conn, trans);

            cmd.Parameters.AddWithValue("@desp", desp);

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmDespesa form, DataTable table, bool detail)
        {
            string sql = "UPDATE `despesa` SET `data`=@data, `id_fornecedor`=@fornecedor,`id_categoria`=@categoria," +
                "`notaFiscal`=@nota,`valor`=@valor,`id_tipo`=@tipo, `id_metodo`=@metodo, `descricao`=@descricao, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql);

            MySqlTransaction trans;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            trans = conn.BeginTransaction();
            cmd.Connection = conn;
            cmd.Transaction = trans;

            SplitContainer sc = (SplitContainer)form.Controls["splitContainer1"];
            Control.ControlCollection colec = sc.Panel1.Controls;



            cmd.Parameters.AddWithValue("@id", colec["txtId"].Text);

            long id = long.Parse(colec["txtId"].Text);

            var cmb = colec.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFornecedor");
            DataRowView drv = cmb.SelectedItem as DataRowView;
            String sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@fornecedor", sel);

            cmb = colec.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
            drv = cmb.SelectedItem as DataRowView;
            sel = drv.Row["id"].ToString();
            cmd.Parameters.AddWithValue("@categoria", sel);

            cmd.Parameters.AddWithValue("@tipo", colec["txtTipoPgto"].Text);
            cmd.Parameters.AddWithValue("@metodo", colec["txtMetodoPgto"].Text);
            cmd.Parameters.AddWithValue("@valor", colec["txtValor"].Text.Replace(".", "").Replace(",", "."));
            cmd.Parameters.AddWithValue("@nota", colec["txtNF"].Text);
            cmd.Parameters.AddWithValue("@descricao", colec["txtDescricao"].Text);

            string data = "";
            DateTime dt;
            bool success = DateTime.TryParse(colec["txtData"].Text, out dt);
            if (success)
            {
                data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
            }
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.ExecuteNonQuery();

                if (detail)
                {
                    int clear = this.DeleteDetail(id, trans);

                    if (clear == 0)
                    {
                        trans.Rollback();
                        conn.Close();
                        return 0;
                    }
                    else
                    {
                        foreach (DataRow r in table.Rows)
                        {
                            int ret = this.AddDetail(r, id, trans);
                            if (ret == 0)
                            {
                                trans.Rollback();
                                conn.Close();
                                return 0;
                            }
                        }
                    }
                }

                trans.Commit();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable getAbertos()
        {
            string sql = "SELECT di.id, f.nome AS fornecedor, d.descricao,  di.vencimento, di.valor FROM despesa d LEFT JOIN (" +
                "SELECT  min(di.id) AS id, min(di.id_despesa) AS id_despesa, MIN(di.parcela) AS parcela, MIN(di.vencimento) AS vencimento, MIN(di.valor) AS valor " +
                "FROM despesa_item di LEFT JOIN liquidacao l ON l.id_despesa_item = di.id WHERE l.id IS null GROUP BY di.id_despesa) " +
                "di ON di.id_despesa = d.id JOIN fornecedor f ON f.id = d.id_fornecedor ORDER BY di.vencimento";

            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nâo foi possível consultar as despesas nesse momento.");
            }
            return dt;
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM despesa WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT p.id, p.data AS 'Data', f.nome AS Fornecedor, a.nome AS Categoria, p.valor AS Valor, p.descricao as 'Descrição', (case p.id_tipo WHEN 1 THEN 'A vista' else 'Parcelado' END) AS 'Tipo Pgto', p.updated_at AS 'Ultima atualização' " +
                "FROM despesa p JOIN fornecedor f ON f.id = p.id_fornecedor JOIN auxiliar a ON a.id = p.id_categoria";
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nâo foi possível consultar as despesas nesse momento.");
            }
            return dt;
        }

        public DataTable Details(int desp)
        {
            string sql = "SELECT p.id, p.parcela AS 'Parcela', p.vencimento as 'Vencimento', p.valor AS 'Valor' " +
                "FROM despesa_item p WHERE p.id_despesa=@desp ORDER BY p.parcela";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@desp", desp);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT * FROM despesa WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataRow GetWithDetail(int id)
        {
            string sql = "SELECT f.nome as fornecedor, a.nome AS categoria, d.descricao, di.parcela, di.vencimento, di.valor " +
                "FROM despesa d JOIN despesa_item di ON di.id_despesa=d.id JOIN fornecedor f ON f.id = d.id_fornecedor JOIN auxiliar a ON a.id = d.id_categoria WHERE di.id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataSet Combo()
        {
            string sql = "SELECT id, concat(placa,'-',modelo) as nome FROM despesa";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }
    }
}
