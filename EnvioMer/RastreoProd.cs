using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvioMer.vistaEstaciones.Est1;
using EnvioMer.vistaEstaciones.Est2;

namespace EnvioMer
{
    public partial class RastreoProd : Form
    {
        Estacion1Propiedades Estacion1 = new Estacion1Propiedades();
        public RastreoProd()
        {
            InitializeComponent();
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                //---------
                Estacion1.TansporteContenedor = txtCodEmbarque1.Text;
                Estacion1.SentidoMovimiento = cbxSentidoMov1.Text;
                funciones.Estacion1Add(Estacion1);
                if (cbxSentidoMov1.SelectedIndex.Equals(0))
                {

                    new frmEst1Llegada().ShowDialog();
                }
                else
                if (cbxSentidoMov1.SelectedIndex.Equals(1))
                {
                    new frmEst1Salida().ShowDialog();
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error "+ Ex.Message);
            }
            
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            if (cbxSentidoMov2.SelectedIndex.Equals(0))
            {
                new frmEst2Llegada().ShowDialog();
            }
            else
            if (cbxSentidoMov2.SelectedIndex.Equals(1))
            {
                new frmEst2Salida().ShowDialog();
            }
        }

        private void cbxSentidoMov1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSentidoMov1.SelectedIndex.Equals(0))
            {
                label4.Visible = false;
                txtCodEmbarque1.Visible = false;
            }
            else
            {
                label4.Visible = true;
                txtCodEmbarque1.Visible = true;
            }
        }

        private void cbxSentidoMov2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSentidoMov2.SelectedIndex.Equals(0))
            {
                label3.Visible = true;
                txtCodEmbarque2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                txtCodEmbarque2.Visible = false;
            }
        }

       
    }
}
