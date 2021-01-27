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
        public string TipoEm { get; set; }
        public int NPaquetes { get; set; }
        public double peso { get; set; }
        public double Volumen { get; set; }
        public double costo { get; set; }
        public int idEmbarque { get; set; }
        public DatosLCL() { }
        public DatosLCL(int NPaquetes, double peso, double Volumen, double costo,string TipoE,int idEmbarque)
        {
            
            this.NPaquetes = NPaquetes;
            this.peso = peso;
            this.Volumen = Volumen;
            this.costo = costo;
            this.TipoEm = TipoE;
            this.idEmbarque = idEmbarque;
        }
    }

}