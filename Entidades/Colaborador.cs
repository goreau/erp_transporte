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
    internal class Colaborador
    {
        MySqlConnection conn = Database.conn;

        public Colaborador()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmColaborador form)
        {
            try
            {
                string sql = "INSERT INTO `colaborador`(`nome`, `funcao`, `categoria`, `dt_admissao`, `rg`, `dt_expedicao`, `cpf`, `cnh`, `cnh_categoria`, `dt_validade`, `dt_nascimento`, `pai`, `mae`, `remuneracao`) " +
                "VALUES (@nome, @funcao, @categoria, @dt_admissao, @rg, @dt_expedicao, @cpf, @cnh, @cnh_categoria, @dt_validade, @dt_nascimento, @pai, @mae, @remuneracao)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //var radio = form.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

                var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFuncao");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@funcao", sel);

                cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
                drv = cmb.SelectedItem as DataRowView;
                sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@categoria", sel);

                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(form.Controls["txtDt_admissao"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_admissao", data);

                cmd.Parameters.AddWithValue("@rg", form.Controls["txtRg"].Text);

                data = "";
                success = DateTime.TryParse(form.Controls["txtDt_expedicao"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_expedicao", data);

                cmd.Parameters.AddWithValue("@cpf", form.Controls["txtCpf"].Text);
                cmd.Parameters.AddWithValue("@cnh", form.Controls["txtCnh"].Text);
                cmd.Parameters.AddWithValue("@cnh_categoria", form.Controls["txtCnh_categoria"].Text);

                data = "";
                success = DateTime.TryParse(form.Controls["txtDt_validade"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_validade", data);

                data = "";
                success = DateTime.TryParse(form.Controls["txtDt_nascimento"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_nascimento", data);

                cmd.Parameters.AddWithValue("@pai", form.Controls["txtPai"].Text);
                cmd.Parameters.AddWithValue("@mae", form.Controls["txtMae"].Text);
                cmd.Parameters.AddWithValue("@remuneracao", form.Controls["txtRemuneracao"].Text.Replace(".", "").Replace(",", "."));

            
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nâo foi possível salvar o registro nesse momento. Tente novamente.");
                return 0;
            }
        }

        public int Edit(frmColaborador form)
        {
            try
            {
                string sql = "UPDATE `colaborador` SET `nome`=@nome,`funcao`=@funcao,`categoria`=@categoria,`dt_admissao`=@dt_admissao,`rg`=@rg,`dt_expedicao`=@dt_expedicao, `cpf`=@cpf," +
                "`cnh`=@cnh,`cnh_categoria`=@cnh_categoria,`dt_validade`=@dt_validade,`dt_nascimento`=@dt_nascimento,`pai`=@pai,`mae`=@mae,`remuneracao`=@remuneracao,`updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

                cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);

                var cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbFuncao");
                DataRowView drv = cmb.SelectedItem as DataRowView;
                String sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@funcao", sel);

                cmb = form.Controls.OfType<ComboBox>().FirstOrDefault(r => r.Name == "cmbCategoria");
                drv = cmb.SelectedItem as DataRowView;
                sel = drv.Row["id"].ToString();
                cmd.Parameters.AddWithValue("@categoria", sel);

                string data = "";
                DateTime dt;
                bool success = DateTime.TryParse(form.Controls["txtDt_admissao"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_admissao", data);

                cmd.Parameters.AddWithValue("@rg", form.Controls["txtRg"].Text);

                data = "";
                success = DateTime.TryParse(form.Controls["txtDt_expedicao"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_expedicao", data);

                cmd.Parameters.AddWithValue("@cpf", form.Controls["txtCpf"].Text);
                cmd.Parameters.AddWithValue("@cnh", form.Controls["txtCnh"].Text);
                cmd.Parameters.AddWithValue("@cnh_categoria", form.Controls["txtCnh_categoria"].Text);

                data = "";
                success = DateTime.TryParse(form.Controls["txtDt_validade"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_validade", data);

                data = "";
                success = DateTime.TryParse(form.Controls["txtDt_nascimento"].Text, out dt);
                if (success)
                {
                    data = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString();
                }
                cmd.Parameters.AddWithValue("@dt_nascimento", data);

                cmd.Parameters.AddWithValue("@pai", form.Controls["txtPai"].Text);
                cmd.Parameters.AddWithValue("@mae", form.Controls["txtMae"].Text);
                cmd.Parameters.AddWithValue("@remuneracao", form.Controls["txtRemuneracao"].Text.Replace(".", "").Replace(",", "."));

            
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
                string sql = "DELETE FROM colaborador WHERE id=@id";
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
                string sql = "SELECT c.id, c.nome AS Nome, a.nome AS Função, aa.nome AS Categoria, DATE_FORMAT(c.dt_admissao, '%d/%m/%Y') as Admissão, " +
                                "rg AS RG, cpf AS CPF, cnh AS CNH, cnh_categoria AS Categoria, DATE_FORMAT(c.dt_validade, '%d/%m/%Y') AS Validade, remuneracao AS Remuneração, c.updated_at AS 'Ultima atualização' " +
                                "FROM colaborador c JOIN auxiliar a ON a.id = c.funcao JOIN auxiliar aa ON aa.id = c.categoria";

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
                string sql = "SELECT * FROM colaborador WHERE id=@id";

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

        public DataTable Combo()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;


            try
            {
                string sql = "SELECT id, nome FROM colaborador ORDER BY nome";

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
            }
           
            return dt;
        }
    }
}
