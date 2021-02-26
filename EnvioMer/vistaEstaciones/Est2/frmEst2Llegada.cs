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
            comboAduana.SelectedIndex = 0;
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            LlegadaE2.Cod_Embarque = int.Parse(txtCodEmbarque.Text);
            LlegadaE2.Fecha_Llegada = dateTimeFechaLlegada.Text;
            LlegadaE2.Puerto = txtPuesrtoLlegada.Text;
            LlegadaE2.Buque = txtBuque.Text;
            LlegadaE2.DestinoEn = txtDestinoEn.Text;
            LlegadaE2.EstAduana = comboAduana.Text;
            LlegadaE2.TRetencion = txtTRetencion.Text;
            funciones.LlegadaEst2Add(LlegadaE2);
            MessageBox.Show("Listo");
        }

        private void frmEst2Llegada_Load(object sender, EventArgs e)
        {
            fun.DataLlegadaEstacion2(dataGridProducto);//llena el datagrid
            fun.ConCodEmbarqueEst2(txtCodEmbarque);//llena solo el txtCodEmbarque
            fun.ConsultaLLegadaAEstacion2(txtPuertoSalida, txtFactura, txtPacking, txtBill_of);///llena los txt de la izquierda
            fun.ConsultaLLegadaAEstacion2LadoDerecho(txtFechaSAlida,txtDestino,txtPuerto,txtTransporte);
        }

        private void comboAduana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAduana.SelectedIndex.Equals(0))
            {
                label2.Visible = false;
                txtTRetencion.Visible = false;
            }
            else
            {
                label2.Visible = true;
                txtTRetencion.Visible = true;
            }
        }
    }
}
