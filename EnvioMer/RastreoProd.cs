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
using EnvioMer.vistaEstaciones.Est3;

namespace EnvioMer
{
    public partial class RastreoProd : Form
    {
        Estacion1Propiedades Estacion1 = new Estacion1Propiedades();
        Estacion2Propiedades Estacion2 = new Estacion2Propiedades();
        Estacion3Propiedades estacion3 = new Estacion3Propiedades();

        public RastreoProd()
        {
            InitializeComponent();
            cbxSentidoMov1.SelectedIndex = 0;
            cbxSentidoMov2.SelectedIndex = 0;
            comboTipEntrega.SelectedIndex = 0;
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {

            frmEst1Salida sal =new frmEst1Salida();
            AddOwnedForm(sal);
            sal.txtCod.Text = txtCodEmbarque1.Text;
            
            try
            {
                //---------
                Estacion1.TansporteContenedor = txtCodTransporte1.Text;
                Estacion1.SentidoMovimiento = cbxSentidoMov1.Text;
                funciones.Estacion1Add(Estacion1);
                if (cbxSentidoMov1.SelectedIndex.Equals(0))
                {

                    new frmEst1Llegada().ShowDialog();
                }
                else
                if (cbxSentidoMov1.SelectedIndex.Equals(1))
                {
                    sal.ShowDialog();
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error "+ Ex.Message);
            }
            
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {   //Pasar el valor del txtCodTransporte2 al formulario frmEst2Salida, para su insercion
            frmEst2Llegada Llegada2 = new frmEst2Llegada();
            AddOwnedForm(Llegada2);
            Llegada2.textBox1.Text = txtCodEmbarque2.Text;
            //-----------------------------------------------
            Estacion2.TransporteContenedor = txtCodTransporte2.Text;
            Estacion2.SentidoMov = cbxSentidoMov2.Text;
            funciones.Estacion2Add(Estacion2);
            if (cbxSentidoMov2.SelectedIndex.Equals(0))
            {
                Llegada2.ShowDialog();
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

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
           
            if (txtCodFlete3.Text==""&& txtCodTransporte3.Text == "")
            {
                MessageBox.Show("Te falta llenar campos");
            }
            else
            {
                estacion3.trnstCon = txtCodTransporte3.Text;
                estacion3.CodFlete = int.Parse(txtCodFlete3.Text);
                estacion3.TipoEntrega = comboTipEntrega.Text;
                funciones.llenarEstacion3(estacion3);

                if (comboTipEntrega.SelectedIndex.Equals(0))
                {
                    new frmSal1Estacion3().ShowDialog();
                }
                else
            if (comboTipEntrega.SelectedIndex.Equals(1))
                {
                    new frmSal2Estacion3().ShowDialog();
                }
               
            }
        }
    }
}
