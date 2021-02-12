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
        public DatosLCL(int PaqueteNum, double peso, double Volumen, double costo,int idEmbarque)
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
        public DatosFCL(int Cantidad, string Tipo_Contenedor,double Costo_Contenedor,int idEmbarque, double costoTotal)
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
        public DatosAereo() {}
        public DatosAereo(string Origen, string Destino,string Pago_en,int Cantidad,double Peso,double Volumen,string Descrip,string Seguro,int Porcentaje,string Moneda,double CostoEnvio,double ValorD,string TipoServicio)
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
    //Mapa--------------------------------------------------
    public class Coordenadas
    {
        public double LatitudInicial { get; set; }
        public double LatitudFinal { get; set; }
        public double LongitudInicial { get; set; }
        public double LongitudFinal { get; set; }
        public Coordenadas() { }
        public Coordenadas(double LatitudInicial, double LatitudFinal,double LongitudInicial, double LongitudFinal)
        {
            this.LatitudInicial = LatitudInicial;
            this.LongitudFinal = LatitudFinal;
            this.LongitudInicial = LongitudInicial;
            this.LongitudFinal = LongitudFinal;
        }
    }
}