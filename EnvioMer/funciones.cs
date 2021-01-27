using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EnvioMer
{
    class funciones
    {
        public static int agregar(DatosLCL add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into Lcl (Cantidad,Peso_kg,Volumen_m3,Costo,idEmbarque,Tipo_Embarque)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}')",add.NPaquetes, add.peso, add.Volumen, add.costo,add.idEmbarque,add.TipoEm),Mysql.conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int agregarT(datos add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into maritimo(OrdenCompra,incoterm,TipoEnvio,TipoMoneda,PuertoOrigen,PuertoDestino)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}')", add.OrCompra, add.Incoterm, add.TipEnvio, add.TipMoneda, add.P_Origen, add.P_destino), Mysql.conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
