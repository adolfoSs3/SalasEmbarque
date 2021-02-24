using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioMer
{
    public class datos
    {
        public int OrCompra { get; set; }
        public string Incoterm { get; set; }
        public string TipEnvio { get; set; }
        public string TipMoneda { get; set; }
        public string P_Origen { get; set; }
        public string P_destino { get; set; }
        public datos() { }

        public datos(int OrCompra, string Incoterm, string TipEnvio, string TipMoneda,
            string P_Origen, string P_destino)
        {
            this.OrCompra = OrCompra;
            this.Incoterm = Incoterm;
            this.TipEnvio = TipEnvio;
            this.TipMoneda = TipMoneda;
            this.P_Origen = P_Origen;
            this.P_destino = P_destino;
        }
    }


    public class DatosLCL
    {
        public int PaqueteN { get; set; }
        public double peso { get; set; }
        public double Volumen { get; set; }
        public double costo { get; set; }
        public int idEmbarque { get; set; }

        public DatosLCL() { }
        public DatosLCL(int PaqueteNum, double peso, double Volumen, double costo, int idEmbarque)
        {
            this.PaqueteN = PaqueteNum;
            this.peso = peso;
            this.Volumen = Volumen;
            this.costo = costo;
            this.idEmbarque = idEmbarque;
        }
    }

    public class DatosFCL
    {
        public int Cantidad { get; set; }
        public string Tipo_Contenedor { get; set; }
        public double Costo_Contenedor { get; set; }
        public int idEmbarque { get; set; }
        public double Costo_Total { get; set; }
        public DatosFCL() { }
        public DatosFCL(int Cantidad, string Tipo_Contenedor, double Costo_Contenedor, int idEmbarque, double costoTotal)
        {
            this.Cantidad = Cantidad;
            this.Tipo_Contenedor = Tipo_Contenedor;
            this.Costo_Contenedor = Costo_Contenedor;
            this.idEmbarque = idEmbarque;
            this.Costo_Total = costoTotal;
        }
    }
    //AEREo---------------------------------------------------------------------
    public class DatosAereo
    {

        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Pago_en { get; set; }
        public int Cantidad { get; set; }
        public double Peso { get; set; }
        public double Volumen { get; set; }
        public string Descripcion { get; set; }
        public string Seguro { get; set; }
        public int Porcentaje { get; set; }
        public string Moneda { get; set; }
        public double CostoEnvio { get; set; }
        public double ValorDeclarado { get; set; }
        public string TipoServicio { get; set; }
        public DatosAereo() { }
        public DatosAereo(string Origen, string Destino, string Pago_en, int Cantidad, double Peso, double Volumen, string Descrip, string Seguro, int Porcentaje, string Moneda, double CostoEnvio, double ValorD, string TipoServicio)
        {
            this.Origen = Origen;
            this.Destino = Destino;
            this.Pago_en = Pago_en;
            this.Cantidad = Cantidad;
            this.Peso = Peso;
            this.Volumen = Volumen;
            this.Descripcion = Descrip;
            this.Seguro = Seguro;
            this.Porcentaje = Porcentaje;
            this.Moneda = Moneda;
            this.CostoEnvio = CostoEnvio;
            this.ValorDeclarado = ValorD;
            this.TipoServicio = TipoServicio;
        }

    }
    //Mapa--------------------------------------------------Pendiente
    public class Coordenadas
    {
        public double LatitudInicial { get; set; }
        public double LatitudFinal { get; set; }
        public double LongitudInicial { get; set; }
        public double LongitudFinal { get; set; }
        public Coordenadas() { }
        public Coordenadas(double LatitudInicial, double LatitudFinal, double LongitudInicial, double LongitudFinal)
        {
            this.LatitudInicial = LatitudInicial;
            this.LongitudFinal = LatitudFinal;
            this.LongitudInicial = LongitudInicial;
            this.LongitudFinal = LongitudFinal;
        }
    }

    //-----------------insert de La estacion 1-------------------------------

    public class Estacion1Propiedades
    {
        public string TansporteContenedor { get; set; }
        public string SentidoMovimiento { get; set; }
        public Estacion1Propiedades() { }
        public Estacion1Propiedades(string TransporteContenedor, string SentidoMovimiento)
        {
            this.TansporteContenedor = TransporteContenedor;
            this.SentidoMovimiento = SentidoMovimiento;
        }
    }
    //-----------------------insert de la salida de la Estacion 1--------
    public class SalidaEstacion1Propiedades
    {
        public int Cod_Embarque { get; set; }
        public string T_C_Salida { get; set; }
        public string Destino { get; set; }
        public string Puerto_Llegada { get; set; }
        public string Fecha_Salida { get; set; }
        public SalidaEstacion1Propiedades() { }
        public SalidaEstacion1Propiedades(int Cod_Embarque, string T_C_Salida, string Destino, string Puerto, string Fecha_Salida)
        {
            this.Cod_Embarque = Cod_Embarque;
            this.T_C_Salida = T_C_Salida;
            this.Destino = Destino;
            this.Puerto_Llegada = Puerto_Llegada;
            this.Fecha_Salida = Fecha_Salida;
        }
    }
    //-----------------insert de Llegada de la Estacion 1---------
    public class LlegadaEstacion1Propiedades
    {
        public string Cod_Barra { get; set; }
        public string Operador { get; set; }
        public string Origen { get; set; }
        public string Puerto_Salida { get; set; }
        public int Factura { get; set; }
        public string Incoterms { get; set; }
        public string Bill_Of_Lading { get; set; }
        public string Producto { get; set; }
        public string Packing_List { get; set; }
        public int Pedimento { get; set; }
        public int Cantidad { get; set; }
        public LlegadaEstacion1Propiedades() { }
        public LlegadaEstacion1Propiedades(string Cod_Barra, string Operador, string Origen, string Puerto_Salida, int Factura, string Incoterms, string Bill_Of_Lading, string Producto, string Packing_List, int Pedimento, int Cantidad)
        {
            this.Cod_Barra = Cod_Barra;
            this.Operador = Operador;
            this.Origen = Origen;
            this.Puerto_Salida = Puerto_Salida;
            this.Factura = Factura;
            this.Incoterms = Incoterms;
            this.Bill_Of_Lading = Bill_Of_Lading;
            this.Producto = Producto;
            this.Packing_List = Packing_List;
            this.Pedimento = Pedimento;
            this.Cantidad = Cantidad;

        }

    }
    ///-----------------insert de La estacion 2-------------------------------
    public class Estacion2Propiedades
    {
        public string TransporteContenedor { get; set; }
        public string SentidoMov { get; set; }
        public Estacion2Propiedades() { }
        public Estacion2Propiedades(string transContenedor,string SentidoMov)
        {
            this.TransporteContenedor = transContenedor;
            this.SentidoMov = SentidoMov;
        }
    }
    //-----------------insert de Llegada de la Estacion 2---------
    public class LlegadaEstacion2Propiedades
    {
        public int CodEmbarque { get; set; }
        public string PuertoSalida { get; set; }
        public int Factura { get; set; }
        public string PackingList { get; set; }
        public string Bill_Of_Lading { get; set; }
        public string Fecha_Salida { get; set; }
        public string Fecha_Llegada { get; set; }
        public string Destino { get; set; }
        public string Puerto { get; set; }
        public string Transporte { get; set; }
        public string Buque { get; set; }
        public string PuertoLlegada { get; set; }
        public string DestinoEn { get; set; }
        public string EstAduana { get; set; }
        public string TRetencion { get; set; }
        public LlegadaEstacion2Propiedades() { }
        public LlegadaEstacion2Propiedades(
            string PuertoSalida,int Factura,string PackingList,string Bill_Of_Lading,
            string Fecha_Salida,string Fecha_Llegada,string Destino,string Puerto,
            string Transporte,string Buque,string PuertoLlegada,string DestinoEn,
            string EstAduana,string TRetencion)
        {
            this.CodEmbarque = CodEmbarque;
            this.PuertoSalida = PuertoSalida;
            this.Factura = Factura;
            this.PackingList = PackingList;
            this.Bill_Of_Lading = Bill_Of_Lading;
            this.Fecha_Salida = Fecha_Salida;
            this.Fecha_Llegada = Fecha_Llegada;
            this.Destino = Destino;
            this.Puerto = Puerto;
            this.Transporte = Transporte;
            this.Buque = Buque;
            this.PuertoLlegada = PuertoLlegada;
            this.DestinoEn = DestinoEn;
            this.EstAduana = EstAduana;
            this.TRetencion = TRetencion;

    }
        
        
    }
    //-----------------------insert de la salida de la Estacion 2--------
    public class SalidaEstacion2Propiedades
    {
        public int CodEmbarque { get; set; }
        public string FechaLlegada { get; set; }
        public string Puerto { get; set; }
        public string DestinoEn { get; set; }
        public string EstAduana { get; set; }
        public string TRetencion { get; set; }
        public string Destino { get; set; }
        public string Transportista { get; set; }
        public int CartaPorte { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}