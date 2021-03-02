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
    public partial class frmEst1Llegada : Form
    {
        LlegadaEstacion1Propiedades LlegadaEstacion1 = new LlegadaEstacion1Propiedades();
        public frmEst1Llegada()
        {
            InitializeComponent();
            comboBoxIcoterm.SelectedIndex = 0;
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            try
            {
                LlegadaEstacion1.Cod_Barra = txtCod_Barra.Text;
                LlegadaEstacion1.Operador = txtOperador.Text;
                LlegadaEstacion1.Origen = txtOrigen.Text;
                LlegadaEstacion1.Puerto_Salida = txtPuSalida.Text;
                LlegadaEstacion1.Factura = int.Parse(txtFactura.Text);
                LlegadaEstacion1.Incoterms = comboBoxIcoterm.Text;
                LlegadaEstacion1.Bill_Of_Lading = txtBillLadinf.Text;
                LlegadaEstacion1.Producto = txtProducto.Text;
                LlegadaEstacion1.Packing_List = txtPacking.Text;
                LlegadaEstacion1.Pedimento = int.Parse(txtPedimento.Text);
                LlegadaEstacion1.Cantidad = int.Parse(txtCantidad.Text);
                funciones.LlegadaEstacion1Add(LlegadaEstacion1);
                MessageBox.Show("Listo");
            }
            catch (Exception Ex)
            {

                MessageBox.Show("ERROR " + Ex.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCod_Barra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBillLadinf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPacking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPedimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
