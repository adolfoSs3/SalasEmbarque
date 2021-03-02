using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioMer.vistaEstaciones.Est1
{
    public partial class frmEst1Salida : Form
    {
        funciones Funcion = new funciones();
        SalidaEstacion1Propiedades SalidaEST1 = new SalidaEstacion1Propiedades();
        RastreoProd RastreoProcucto = new RastreoProd();
        public frmEst1Salida()
        {
            InitializeComponent();
        }
        
        private void BtnAgregarSalidaEstacion1_Click(object sender, EventArgs e)
        {
             try
            {
                

                SalidaEST1.Cod_Embarque = int.Parse(txtCod.Text);
                SalidaEST1.T_C_Salida = Convert.ToString(txtC_T_Salida.Text);
                SalidaEST1.Destino = Convert.ToString(txtDestino.Text);
                SalidaEST1.Puerto_Llegada = Convert.ToString(txtPuertoLlegada.Text);
                SalidaEST1.Fecha_Salida = dateTimeFechaSalida1.Text;//Checar sise puede Desde las propiedades Cambiar a tipo texto
                
                funciones.SalidaEst1Add(SalidaEST1);
                MessageBox.Show("Listo");
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error" + Ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
