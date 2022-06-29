using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace first_db_connection
{
    public class banco
    {
        public static MySqlConnection fazerconexao()
        {
            MySqlConnection cnn = new MySqlConnection("server=127.0.0.1;database=db_aspnet;uid=root;pwd=;port=3306;");
            return cnn;
        }
    }
}