using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Transporte.Auxiliares
{
    internal class Database
    {
        private static string host = "localhost";
        private static string porta = "3306";
        private static string user = "root";
        private static string senha = "";
        private static string banco = "apitransporte";

        public static string connstring = String.Format("server={0};Port={1};uid={2};pwd={3};database={4};Convert Zero Datetime=True",
                    host, porta, user, senha, banco);

        public static MySqlConnection conn = new MySqlConnection(connstring);

        public static bool Conecta()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro na Conexão:" + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado:" + ex.Message);
                return false;
            }
        }

        public static bool Desconecta()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro inesperado:" + ex.Message);
                return false;
            }
        }

        public DataTable GetTabela(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                // conn.Open();
                Conecta();

                using (MySqlDataAdapter Adpt = new MySqlDataAdapter(sql, conn))
                {
                    Adpt.Fill(dt);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro na execução da solicitação:\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado:" + ex.Message);
            }
            finally
            {
                //  conn.Close();
                Desconecta();
            }
            return dt;
        }

        public void Acao(string sql)
        {
            try
            {
                conn.Open();

                using (MySqlCommand Cmd = new MySqlCommand(sql, conn))
                {
                    Cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
