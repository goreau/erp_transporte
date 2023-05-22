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
    internal class Liquidacao
    {
        MySqlConnection conn = Database.conn;

        public Liquidacao()
        {
              if (conn.State != ConnectionState.Open)
              {
                  conn.Open();
              }

        }

        public int Add(frmLiquidacao form)
        {
            string sql = "INSERT INTO `liquidacao`(`id_despesa_item`, `data`, `valor`) " +
                "VALUES (@desp, @data, @valor)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
               

                SplitContainer sc = (SplitContainer)form.Controls["splitContainer1"];
                Control.ControlCollection colec = sc.Panel1.Controls;

                cmd.Parameters.AddWithValue("@desp", colec["txtIdMaster"].Text);
                
                cmd.Parameters.AddWithValue("@valor", colec["txtValor"].Text.Replace(".", "").Replace(",", "."));
                
                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(colec["txtData"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@data", data);

                cmd.ExecuteNonQuery();
               
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmLiquidacaoEd form)
        {
            string sql = "INSERT INTO `liquidacao`(`id_despesa_item`, `data`, `valor`) " +
                "VALUES (@desp, @data, @valor)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                SplitContainer sc = (SplitContainer)form.Controls["splitContainer1"];
                Control.ControlCollection colec = sc.Panel1.Controls;

                cmd.Parameters.AddWithValue("@desp", colec["txtIdMaster"].Text);

                cmd.Parameters.AddWithValue("@valor", colec["txtValor"].Text.Replace(".", "").Replace(",", "."));

                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(colec["txtData"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@data", data);

                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable Delete(int id)
        {
            string sql = "DELETE FROM liquidacao WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return this.Consulta();
        }

        public DataTable Consulta()
        {
            string sql = "SELECT p.id, f.nome AS Fornecedor, d.descricao as 'Descrição', di.parcela as Parcela, di.vencimento, di.valor, p.data AS data_pago, p.valor AS valor_pago, p.updated_at AS 'Ultima atualização' " +
                "FROM liquidacao p JOIN despesa_item di ON di.id=p.id_despesa_item JOIN despesa d ON d.id=di.id_despesa JOIN fornecedor f ON f.id = d.id_fornecedor JOIN auxiliar a ON a.id = d.id_categoria  ";
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

        public DataRow Get(int id)
        {
            string sql = "SELECT p.id, f.nome AS fornecedor, a.nome as categoria, d.descricao, di.vencimento, di.parcela as parcela, di.valor, p.data AS data_pago, p.valor AS valor_pago " +
                "FROM liquidacao p JOIN despesa_item di ON di.id=p.id_despesa_item JOIN despesa d ON d.id=di.id_despesa JOIN fornecedor f ON f.id = d.id_fornecedor JOIN auxiliar a ON a.id = d.id_categoria " +
                "WHERE p.id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }
    }
}
