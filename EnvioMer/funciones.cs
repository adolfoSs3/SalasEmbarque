using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Device.Location;
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
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT Peso_kg, Volumen_m3,Costo,idEmbarque from lcl WHERE IdEmbarque ='" + txtid.Text + "'", Mysql.conexion.obtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dt.DataSource = tabla;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Checa la linea" + e.StackTrace);
            }
           
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
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO aereo(Origen,Destino,Pago_En,Cantidad,Peso,Volumen,Descripcion_Embarque,Seguro,Porcentaje,Tipo_Moneda,Costo_Envio,ValorDeclarado,TipoServicio)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", add.Origen, add.Destino, add.Pago_en, add.Cantidad,add.Peso,add.Volumen,add.Descripcion,add.Seguro,add.Porcentaje,add.Moneda,add.CostoEnvio,add.ValorDeclarado,add.TipoServicio), Mysql.conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Mostramos los datos de la tabla Aereo
        public void ConsultaAereo(DataGridView dt)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * from aereo", Mysql.conexion.obtenerConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dt.DataSource = tabla;

        }
        //--------------------------------------Mapa----------------------------



        public void CalcularDistancia(RadioButton RAvion, RadioButton RCamion, RadioButton RBarco, DataTable td, TextBox Descrip, DataGridView dt, TextBox txtLat1, TextBox txtLat2, TextBox txtLong1, TextBox txtLong2)
        {
            try
            {
                string descripcion = Convert.ToString(Descrip.Text);
                double Latitud1 = double.Parse(txtLat1.Text);

                double Latitud2 = double.Parse(txtLat2.Text);

                double Longitud1 = double.Parse(txtLong1.Text);

                double Longitud2 = double.Parse(txtLong2.Text);

                //--------Fórmula del Haversine----------------------

                GeoCoordinate pin1 = new GeoCoordinate(Latitud1, Longitud1);
                GeoCoordinate pin2 = new GeoCoordinate(Latitud2, Longitud2);
                //----------caldulo del tiempo segun la velocidad
                double Velocidad = 0;
                double distancia = pin1.GetDistanceTo(pin2);
                double distanceBetween = distancia / 1000;
                if (RAvion.Checked == true)
                {
                    Velocidad = 964.604;
                }
                if (RCamion.Checked == true)
                {
                    Velocidad = 90;
                }
                if (RBarco.Checked == true)
                {
                    Velocidad = 56;
                }
                double tiempoDias = (distanceBetween) / Velocidad;
                double Horas = tiempoDias * 24 / 1;

                //------------------------------------------------------
                td.Rows.Add(descripcion,distanceBetween,Math.Round(tiempoDias),Math.Ceiling(Horas));
                dt.DataSource = td;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
          
        }
        //-----------------------Estacion1-------------------------------
        public static int Estacion1Add (Estacion1Propiedades add)
        {
            int retorno = 0;
            MySqlCommand Comando = new MySqlCommand(String.Format("insert into estacion1(TransporteContenedor,SentidoMovimiento)" +
                "Values('{0}','{1}')", add.TansporteContenedor, add.SentidoMovimiento), Mysql.conexion.obtenerConexion());
            retorno = Comando.ExecuteNonQuery();
            return retorno;
        }
       //-------------------Salida de Estacion 1--------------------
       public static int SalidaEst1Add(SalidaEstacion1Propiedades add)
        {
            int retorno;
            MySqlCommand Comado = new MySqlCommand(String.Format("insert into salida_estacion1(Cod_Embarque,Transporte_Contenedor_Salida,Destino,Puerdo_Llegada,fecha_Salida)" +
                "values('{0}','{1}','{2}','{3}','{4}')", add.Cod_Embarque, add.T_C_Salida, add.Destino, add.Puerto_Llegada, add.Fecha_Salida), Mysql.conexion.obtenerConexion());
            retorno = Comado.ExecuteNonQuery();
            return retorno;
        }
        //-----------------Llegada de la estacion 1-----------------------
        public static int LlegadaEstacion1Add(LlegadaEstacion1Propiedades add)
        {
            int retorno;
            MySqlCommand Comando = new MySqlCommand(String.Format("insert into llegada_estacion1(Cod_Barra,Operador,Origen,Puerto_Salida,Factura,Incoterms,Bill_Of_Lading,Producto,Packing_List,Pedimento,Cantidad)" +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", add.Cod_Barra, add.Operador,add.Origen,add.Puerto_Salida, add.Factura, add.Incoterms, add.Bill_Of_Lading, add.Producto, add.Packing_List, add.Pedimento, add.Cantidad), Mysql.conexion.obtenerConexion());
            retorno = Comando.ExecuteNonQuery();
            return retorno;
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------

        //----------insercion de la estacion 2-------------
        public static int Estacion2Add(Estacion2Propiedades add)
        {
            int retorno;
            MySqlCommand Comando = new MySqlCommand(String.Format("insert into estacion2(TransporteContenedor,SentidoMovimiento)" +
                "values('{0}','{1}')", add.TransporteContenedor, add.SentidoMov), Mysql.conexion.obtenerConexion());
            retorno = Comando.ExecuteNonQuery();
            return retorno;
        }
        //-----------insercion de la Llegada de la estacion 2------
        public static int LlegadaEst2Add(LlegadaEstacion2Propiedades add)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(String.Format("insert into llegadaestacion2(Fecha_Llegada,Puerto,DestinoEn,EstAduana,TRetencion,Buque,Cod_Embarque)" +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",add.Fecha_Llegada,add.Puerto,add.DestinoEn, add.EstAduana, add.TRetencion,add.Buque,add.Cod_Embarque), Mysql.conexion.obtenerConexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //-----------insercion de la salida de Estacion 2-------
        public static int SalidaEstacion2Add(SalidaEstacion2Propiedades add)
        {
            int retorno;
            MySqlCommand Command = new MySqlCommand(String.Format("insert into salidaestacion2(Flete,CodEmbarque,Destino,Transportista,CartaPorte,Direccion,FechaSalida)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",add.Flete,add.CodEmbarque,add.Destino, add.Transportista, add.CartaPorte, add.Direccion, add.FechaSalida), Mysql.conexion.obtenerConexion());
            retorno = Command.ExecuteNonQuery();
            return retorno;
        }
        //Muestra los datos en el datagrid dellegada en la estacion2 actualizado al ultimo dato incresado en la llegada de la estacion 1
        public void DataLlegadaEstacion2(DataGridView dt)
        {
            MySqlCommand comando = new MySqlCommand("SELECT Producto,Cantidad from llegada_estacion1 ORDER BY id DESC LIMIT 1;", Mysql.conexion.obtenerConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dt.DataSource = tabla;

        }
        //--------esta consulta solo sirve para obtener el Cod del embarque que esta en diferente tabla en la bd
        public void ConCodEmbarqueEst2(TextBox txt1)
        {
            MySqlCommand comando1 = new MySqlCommand();
            comando1.Connection= Mysql.conexion.obtenerConexion();
            comando1.CommandText = ("SELECT * from salida_estacion1 ORDER BY Cod_Embarque DESC LIMIT 1;");
            MySqlDataReader leer = comando1.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["Cod_Embarque"].ToString();
            }
            
        }
        //----Esta cosulta manda los datos faltantes al form de llegada de la estacion 2
        public void ConsultaLLegadaAEstacion2(TextBox txt1, TextBox txt2,TextBox txt3, TextBox txt4)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Mysql.conexion.obtenerConexion();
            comando.CommandText = ("SELECT * from llegada_estacion1 ORDER BY id DESC LIMIT 1;");
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["Puerto_Salida"].ToString();
                txt2.Text = leer["Factura"].ToString();
                txt3.Text = leer["Packing_List"].ToString();
                txt4.Text = leer["Bill_Of_Lading"].ToString();
            }

        }
        //----Esta cosulta manda los datos faltantes al form de llegada de la estacion 2 del lado derecho que son los mismos de la salida de la estacion 1
        public void ConsultaLLegadaAEstacion2LadoDerecho(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Mysql.conexion.obtenerConexion();
            comando.CommandText = ("SELECT * from salida_estacion1 ORDER BY Cod_Embarque DESC LIMIT 1");
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["fecha_Salida"].ToString();
                txt2.Text = leer["Destino"].ToString();
                txt3.Text = leer["Puerdo_Llegada"].ToString();
                txt4.Text = leer["Transporte_Contenedor_Salida"].ToString();
            }
        }
        //-----------------------------------------------------------------------------
        //-----------------------muestrtametodo para mostrar los datos fijos del formulario de salida de la estacion 2------------------------------------------------------
        public void MostrardatosEstacion2Salida(TextBox txt2, TextBox txt3, TextBox txt4,TextBox txt5,TextBox txt6)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = Mysql.conexion.obtenerConexion();
            command.CommandText=("SELECT * from llegadaestacion2 ORDER BY Cod_Embarque DESC LIMIT 1");
            MySqlDataReader REader = command.ExecuteReader();
            if (REader.Read() == true)
            {
                txt2.Text = REader["Fecha_Llegada"].ToString();
                txt3.Text = REader["DestinoEn"].ToString();
                txt4.Text = REader["Puerto"].ToString();
                txt5.Text = REader["EstAduana"].ToString();
                txt6.Text = REader["TRetencion"].ToString();
            }
           
        }

        public void SalidaMostrarFacturaEst3(TextBox txt1)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Mysql.conexion.obtenerConexion();
            comando.CommandText = ("select Factura FROM llegada_estacion1 ORDER BY id DESC LIMIT 1;");
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["Factura"].ToString();
                
            }
        }
        public void MostrarFleteyDireccionEst3(TextBox txt1, TextBox txt2)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Mysql.conexion.obtenerConexion();
            comando.CommandText = ("select  Flete,Direccion from salidaestacion2 ORDER BY Flete DESC LIMIT 1;");
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["Flete"].ToString();
                txt2.Text = leer["Direccion"].ToString();
            }
        }
        //------------llenado de la tabla de la estacion 3
        public static int llenarEstacion3(Estacion3Propiedades add)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(String.Format("insert into estacion3(TransporteCont3,CodFlete,TipoEntrega)" +
                "values('{0}','{1}','{2}')", add.trnstCon,add.CodFlete,add.TipoEntrega), Mysql.conexion.obtenerConexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //---------------insert de la estacion 3 de la salida
        public static int Salida1ClientesEstacion3(Salida1ClienteEstacion3 add)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(String.Format("insert into salida1clienteestacion3(EntregaProd,FechaLlegada,ReferenciaEntrega,RecibidoPor)" +
                "values('{0}','{1}','{2}','{3}')", add.EntregaProd, add.FechaLlegada, add.Referencia, add.RecibidoPor), Mysql.conexion.obtenerConexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //Mostrar datos en el datagridview de la salida 1 estacion3
        public void DatosSalida1Estacion3(DataGridView dt)
        {
            MySqlCommand comando = new MySqlCommand("select Producto,Cantidad, Factura FROM llegada_estacion1", Mysql.conexion.obtenerConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dt.DataSource = tabla;

        }
        //Dados que se muestran en la estacion 3 salida2
        public void MostrardatosEstacion3salida2(TextBox txt1, TextBox txt2,TextBox txt3)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Mysql.conexion.obtenerConexion();
            comando.CommandText = ("select  Flete,Transportista,CartaPorte from salidaestacion2 ORDER BY Flete DESC LIMIT 1;");
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["Flete"].ToString();
                txt2.Text = leer["Transportista"].ToString();
                txt3.Text = leer["CartaPorte"].ToString();
            }
        }
        //Insertamos datos De la estacion 3 Salida 2
        public static int Salida2Estacion3Add (Salida2ClienteEstacion3 add)
        {
                int retorno;
                MySqlCommand command = new MySqlCommand(String.Format("insert into salida2clienteestacion3(Cliente,ReferenciaEntrega,RecibidoPor,Direccion,Comentarios)" +
                    "values('{0}','{1}','{2}','{3}','{4}')", add.Cliente, add.ReferenciaE, add.RecibidoPor, add.Direccion, add.Comentarios), Mysql.conexion.obtenerConexion());
                retorno = command.ExecuteNonQuery();
                return retorno;           
        }
        //factura comercial Parte 1
        public static int FacturaComercialParte1Add(FacturaParte1 add)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(String.Format("insert into facturacomercialp1(NIdentifi,Nombre,Telefono,Email,CompanyName,Pais,PartiesTransaction,Fecha,ConoEmbarque,NFactura,OrdenCompra,TPago,Incoterm,ReasonExport)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", add.NIdentifi,add.Nombre,add.Telefono,add.Email,add.CompanyName,add.Pais,add.PartiesTransaction,add.Fecha,add.ConoEmbarque,add.NFactura,add.OrdenCompra,add.TPago,add.Incoterm,add.ReasonEx), Mysql.conexion.obtenerConexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //datos ya generados factura Comercial 1
        public void Parte1Fact(TextBox txt1, TextBox txt2)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Mysql.conexion.obtenerConexion();
            comando.CommandText = ("select  Factura,Incoterms from llegada_estacion1 ORDER BY id DESC LIMIT 1;");
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                txt1.Text = leer["Factura"].ToString();
                txt2.Text = leer["Incoterms"].ToString();
            }
        }
        //factura comercial Parte 2Primera Parte
        public static int FacturaComercialParte2de1Add(FacturaComercialP2PRopiedadesUnoo1 add)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(String.Format("insert into factura2destinatario(NIdentifi,Nombre,Telefono,Email,Pais,CompanyName)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}')", add.NIdentifi, add.Nombre, add.Telefono, add.Email, add.Pais, add.CompanyName), Mysql.conexion.obtenerConexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //factura comercial Parte 2 SEGUNDA Parte
        public static int FacturaComercialParte2de2Add(FacturaComercialP2PRopiedadesDoos2 add)
        {
            int retorno;
            MySqlCommand command = new MySqlCommand(String.Format("insert into factura2destinatariovendidoa(NIdentifi,Nombre,Telefono,Email,Pais,CompanyName)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}')", add.NIdentifi, add.Nombre, add.Telefono, add.Email, add.Pais, add.CompanyName), Mysql.conexion.obtenerConexion());
            retorno = command.ExecuteNonQuery();
            return retorno;
        }
        //_------------------Factura Parte 3 
        public void FactutaPate3(DataGridView dt)
        {
            MySqlCommand agregar = new MySqlCommand("insert into facturaparte3 values(NPaquetes,NoUnitario,UnidadMedida,DesMercancia,PaisOrigen,PUnitario,PTotal)", Mysql.conexion.obtenerConexion());
            //try
            {
                foreach (DataGridViewRow row in dt.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.Add("NPaquetes", MySqlDbType.Int16).Value = Convert.ToString(row.Cells["Column1"].Value);
                    agregar.Parameters.Add("NoUnitario", MySqlDbType.Int16).Value = Convert.ToString(row.Cells["Column2"].Value);
                    agregar.Parameters.Add("UnidadMedida", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["Column3"].Value);
                    agregar.Parameters.Add("DesMercancia", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["Column4"].Value);
                    agregar.Parameters.Add("PaisOrigen", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["Column5"].Value);
                    agregar.Parameters.Add("PUnitario", MySqlDbType.Double).Value = Convert.ToString(row.Cells["Column6"].Value);
                    agregar.Parameters.Add("PTotal", MySqlDbType.Double).Value = Convert.ToString(row.Cells["Column7"].Value);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Listo");
                }
            }
           /* catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace);
            }*/
        }
    }
}
