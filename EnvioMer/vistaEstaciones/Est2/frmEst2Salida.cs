using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EnvioMer.vistaEstaciones.Est2
{
    public partial class frmEst2Salida : Form
    {
        SalidaEstacion2Propiedades Salida = new SalidaEstacion2Propiedades();
        funciones fun = new funciones();
        public frmEst2Salida()
        {
            InitializeComponent();
        }

        private void frmEst2Salida_Load(object sender, EventArgs e)
        {
            fun.MostrardatosEstacion2Salida(txtFechaLlegada, txtDestinoEn, txtPuerto, txtAduana, txtTRetencion);
            fun.DatosSalida1Estacion3(dataGridView1);
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                Salida.Flete = int.Parse(txtFlete.Text);
                Salida.CodEmbarque = int.Parse(txtCodEmbarque.Text);
                Salida.Destino = txtDestinoSalida.Text;
                Salida.Transportista = txtTransportista.Text;
                Salida.CartaPorte = int.Parse(txtCartaPorte.Text);
                Salida.Direccion = txtDireccionSalida.Text;
                Salida.FechaSalida = dateTimeFechaSalida.Text;
                funciones.SalidaEstacion2Add(Salida);
                MessageBox.Show("Listo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.StackTrace);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCartaPorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
