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


namespace EnvioMer.vistaEstaciones.Est3
{
    public partial class frmSal1Estacion3 : Form
    {
        funciones fun = new funciones();
        Salida1ClienteEstacion3 sal1Est3 = new Salida1ClienteEstacion3();
        public frmSal1Estacion3()
        {
            InitializeComponent();

        }

        private void frmEstacion3_Load(object sender, EventArgs e)
        {
            fun.DatosSalida1Estacion3(dataGridView1);
            fun.MostrarFleteyDireccionEst3(txtNFlete,txtDireccionSalida);
            fun.SalidaMostrarFacturaEst3(txtFactura);

        }

       

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
              try
            {
                sal1Est3.EntregaProd = txtEntregaProd.Text;
                sal1Est3.FechaLlegada = dateTimeFechaLlegada.Text;
                sal1Est3.Referencia = txtReferenciaEntrega.Text;
                sal1Est3.RecibidoPor = txtRecibidopor.Text;
                funciones.Salida1ClientesEstacion3(sal1Est3);
                MessageBox.Show("Los artículos fueron entregados en el domicilio indicado, la mercancía se entregó en condiciones optimas");
                Close();
            }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message + ex.StackTrace);
              }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNFlete_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
