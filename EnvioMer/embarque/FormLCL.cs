using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioMer.ambarque
{
    public partial class FormLCL : Form
    {
        DatosLCL DLCL = new DatosLCL();
        FormCostos Costtos = new FormCostos();
        public FormLCL()
        {
            InitializeComponent();
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {

            DLCL.TipoEm = Costtos.TXTMAritimo.Text;
            DLCL.idEmbarque = Convert.ToInt32(Costtos.idCompra.Text);

            int cantidad = Convert.ToInt32(textBCantidadPaquetesLCL.Text);
            for (int cont=0; cont >= cantidad; cont++)
            {
                
                DLCL.NPaquetes = cont;
                DLCL.peso = double.Parse(textPesoLCL.Text);
                DLCL.Volumen = double.Parse(textVolumenLCL.Text);
                DLCL.costo = double.Parse(textCostoLCL.Text);
                
                MessageBox.Show("Agregado", "Paquete numero " + cont);
                int retorno = funciones.agregar(DLCL);
                if (retorno > 0)
                {
                    MessageBox.Show("Listo");
                }
                else { MessageBox.Show("Error"); }
            }
            
           
        }

        
    }
}
