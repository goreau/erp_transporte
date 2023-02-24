using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Transporte.Auxiliares
{
    internal class CreateDB
    {
        MySqlConnection conn = Database.conn;

        public CreateDB()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public bool createTables()
        {
            return true;
            /* try
             {
                 string sql = "ALTER TABLE `abastecimento` CHANGE `fornecedor` `id_fornecedor` INT(11) NOT NULL; ";

                 MySqlCommand cmd = new MySqlCommand(sql, conn);

                 cmd.ExecuteNonQuery();
             }
             catch (Exception ex)
             {
                 return false;
             }
             return true;*/
        }
    }
}
