using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EnvioMer.Mysql
{
    class conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;database=enbarque;uid=root;password=;");
            conexion.Open();
            return conexion;
        }
    }
}
