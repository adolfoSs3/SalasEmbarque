using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
        public  static int agregarfcl(DatosFCL add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into fcl(Cantidad,Tipo_Contenedor,Costo_por_Contenedor,idEmbarque)" +
                "values('{0}','{1}','{2}','{3}')", add.Cantidad, add.Tipo_Contenedor, add.Costo_Contenedor, add.idEmbarque), Mysql.conexion.obtenerConexion());
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

        //------------------------------------------------------------------------------------------------------------

       /* public void ConsultaFCL(DataGridView dt)
        {
            MySqlCommand comando = new MySqlCommand("select * from fcl",Mysql.conexion.obtenerConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            
        }
        */
    }
}
