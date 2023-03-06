using ERP_Transporte.Auxiliares;
using ERP_Transporte.Views;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Transporte.Entidades
{
    internal class Empresa
    {
        MySqlConnection conn = Database.conn;


        public Empresa()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        public int Add(frmEmpresa form)
        {
            string sql = "INSERT INTO `empresa`(nome,nome_fantasia,cnpj,cidade,logradouro,numero,uf,bairro,telefone1,contato1,telefone2,contato2) " +
                "VALUES (@nome, @nome_fantasia, @cnpj, @cidade, @logradouro, @numero, @uf, @bairro, @telefone1, @contato1, @telefone2, @contato2)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

          
            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);
            cmd.Parameters.AddWithValue("@nome_fantasia", form.Controls["txtNome_fantasia"].Text);
            cmd.Parameters.AddWithValue("@cnpj", form.Controls["txtCnpj"].Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@cidade", form.Controls["txtCidade"].Text);
            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@uf", form.Controls["txtUf"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);
            cmd.Parameters.AddWithValue("@telefone1", form.Controls["txtTelefone1"].Text);
            cmd.Parameters.AddWithValue("@contato1", form.Controls["txtContato1"].Text);
            cmd.Parameters.AddWithValue("@telefone2", form.Controls["txtTelefone2"].Text);
            cmd.Parameters.AddWithValue("@contato2", form.Controls["txtContato2"].Text);


            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Edit(frmEmpresa form)
        {
            string sql = "UPDATE `empresa` SET nome=@nome ,  nome_fantasia=@nome_fantasia ,  cnpj=@cnpj ,  cidade=@cidade ,  logradouro=@logradouro ,  numero=@numero ,  " +
                "uf=@uf ,  bairro=@bairro ,  telefone1=@telefone1 ,  contato1=@contato1 ,  telefone2=@telefone2 ,  contato2=@contato2, `updated_at` = CURRENT_TIMESTAMP() " +
                " WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", form.Controls["txtId"].Text);

            cmd.Parameters.AddWithValue("@nome", form.Controls["txtNome"].Text);
            cmd.Parameters.AddWithValue("@nome_fantasia", form.Controls["txtNome_fantasia"].Text);
            cmd.Parameters.AddWithValue("@cnpj", form.Controls["txtCnpj"].Text.Replace(',','.'));
            cmd.Parameters.AddWithValue("@cidade", form.Controls["txtCidade"].Text);
            cmd.Parameters.AddWithValue("@logradouro", form.Controls["txtLogradouro"].Text);
            cmd.Parameters.AddWithValue("@numero", form.Controls["txtNumero"].Text);
            cmd.Parameters.AddWithValue("@uf", form.Controls["txtUf"].Text);
            cmd.Parameters.AddWithValue("@bairro", form.Controls["txtBairro"].Text);
            cmd.Parameters.AddWithValue("@telefone1", form.Controls["txtTelefone1"].Text);
            cmd.Parameters.AddWithValue("@contato1", form.Controls["txtContato1"].Text);
            cmd.Parameters.AddWithValue("@telefone2", form.Controls["txtTelefone2"].Text);
            cmd.Parameters.AddWithValue("@contato2", form.Controls["txtContato2"].Text);


            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataRow Consulta(int id)
        {
            string sql = "SELECT * FROM empresa WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }

        public DataRow Get(int id)
        {
            string sql = "SELECT id, nome, cnpj, CONCAT(cidade, '/', uf) as cidade, CONCAT(logradouro,', ', numero, ' - ', bairro) as endereco," +
                "CONCAT(telefone1,' (',contato1,')') as telefone1, CONCAT(telefone2,' (',contato2,')') as telefone2  FROM empresa WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.Rows[0];
        }


    }
}
