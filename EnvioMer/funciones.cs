using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace EnvioMer
{
    class funciones
    {
        public static int agregar(DatosLCL add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into Lcl (Paquete_N,Peso_kg,Volumen_m3,Costo,idEmbarque)" +
                "values('{0}','{1}','{2}','{3}','{4}')", add.PaqueteN, add.peso, add.Volumen, add.costo, add.idEmbarque), Mysql.conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int agregarfcl(DatosFCL add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into fcl(Cantidad,Tipo_Contenedor,Costo_por_Contenedor,idEmbarque,Costo_Total)" +
                "values('{0}','{1}','{2}','{3}','{4}')", add.Cantidad, add.Tipo_Contenedor, add.Costo_Contenedor, add.idEmbarque, add.Costo_Total), Mysql.conexion.obtenerConexion());
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
        //Mostramos los datos en el DataGritView especificos dependiendo de la orden de compra
        public void ConsultaFCL(DataGridView dt, TextBox txtid)
        {
            MySqlCommand comando = new MySqlCommand("SELECT Cantidad, Tipo_Contenedor, Costo_por_Contenedor,Costo_Total,IdEmbarque from fcl WHERE IdEmbarque ='" + txtid.Text + "'", Mysql.conexion.obtenerConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dt.DataSource = tabla;

        }
        //------------------------------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------------------------------
        //Mostramos los datos en el DataGritView especificos dependiendo de la orden de compra
        public void ConsultaLCL(DataGridView dt, TextBox txtid)
        {
            MySqlCommand comando = new MySqlCommand("SELECT Peso_kg, Volumen_m3,Costo,idEmbarque from lcl WHERE IdEmbarque ='" + txtid.Text + "'", Mysql.conexion.obtenerConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dt.DataSource = tabla;

        }
        //--------------------------------------------------------------------------------------------



        //metodo para calcular el precio final del FCL


        public Double CostoFinalFCL(TextBox Total)
        {
            Double Resultado;
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT SUM(Costo_Total) FROM fcl WHERE IdEmbarque ='" + Total.Text + "'", Mysql.conexion.obtenerConexion());                               
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())                
                    Resultado = reader.GetDouble(0);                                    
                else                
                    Resultado = 0;                    
                
                return Resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
        public Double CostoFinalLCL(TextBox Total)
        {
            Double Resultado;
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT SUM(Costo) FROM lcl WHERE idEmbarque ='" + Total.Text + "'", Mysql.conexion.obtenerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    Resultado = reader.GetDouble(0);          
                }
                else
                {
                    Resultado = 0;                
                }
                return Resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        //Aereos--------------------------------------------------------------
        public static int AgregarAereos(DatosAereo add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO aereo(Origen,Destino,Pago_En,Cantidad,Peso(kg),Volumen(m3),Descripcion_Embarque,Seguro,Porcentaje,Tipo_Moneda,Costo_Envio)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", add.Origen, add.Destino, add.Pago_en, add.Cantidad,add.Peso,add.Volumen,add.Descripcion,add.Seguro,add.Porcentaje,add.Moneda,add.CostoEnvio), Mysql.conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
