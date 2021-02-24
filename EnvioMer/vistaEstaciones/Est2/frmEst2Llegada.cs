using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioMer.vistaEstaciones.Est2
{
    public partial class frmEst2Llegada : Form
    {
        funciones fun = new funciones();
        LlegadaEstacion2Propiedades LlegadaE2 = new LlegadaEstacion2Propiedades();
        public frmEst2Llegada()
        {
            InitializeComponent();
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            LlegadaE2.CodEmbarque = int.Parse(txtCod2.Text);
            LlegadaE2.PuertoSalida = txtPuertoSalida.Text;
            LlegadaE2.Factura = int.Parse(txtFactura.Text);
            LlegadaE2.PackingList = txtPacking.Text;
            LlegadaE2.Bill_Of_Lading = txtBill_of.Text;
            LlegadaE2.Fecha_Salida = dateTimeFechaSalida.Text;
            LlegadaE2.Fecha_Llegada = dateTimeFechaLlegada.Text;
            LlegadaE2.Destino = txtDestino.Text;
            LlegadaE2.Puerto = txtPuerto.Text;
            LlegadaE2.Transporte = txtTransporte.Text;
            LlegadaE2.Buque = txtBuque.Text;
            LlegadaE2.PuertoLlegada = txtPuesrtoLlegada.Text;
            LlegadaE2.DestinoEn = txtDestinoEn.Text;
            LlegadaE2.EstAduana = txtAduana.Text;
            LlegadaE2.TRetencion = txtTRetencion.Text;
            funciones.LlegadaEst2Add(LlegadaE2);
            MessageBox.Show("Listo");
        }

        private void frmEst2Llegada_Load(object sender, EventArgs e)
        {
            fun.ConsultaLLegadaAEstacion2(dataGridProducto);
        }
    }
}
