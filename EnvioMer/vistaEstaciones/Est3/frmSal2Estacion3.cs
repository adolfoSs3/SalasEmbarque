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
    public partial class frmSal2Estacion3 : Form
    {
        funciones fun = new funciones();
        Salida2ClienteEstacion3 Salida2E3 = new Salida2ClienteEstacion3();
        public frmSal2Estacion3()
        {
            InitializeComponent();
        }

        private void frmSal2Estacion3_Load(object sender, EventArgs e)
        {
            fun.MostrardatosEstacion3salida2(txtNFlete,txtTransportista,txtCartaPorte);
            fun.DatosSalida1Estacion3(dataGridView1);

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text == "" || txtReferenciaE.Text == "" || txtRecibidoPor.Text == "" || txtDireccion.Text == "" || txtComentario.Text == "")
            {
                MessageBox.Show("Faltan Datos Por llenar");
            }else
            {
                Salida2E3.Cliente = txtCliente.Text;
                Salida2E3.ReferenciaE = txtReferenciaE.Text;
                Salida2E3.RecibidoPor = txtRecibidoPor.Text;
                Salida2E3.Direccion = txtDireccion.Text;
                Salida2E3.Comentarios = txtComentario.Text;
                funciones.Salida2Estacion3Add(Salida2E3);
                //Mostramos los datos insertados
                MessageBox.Show("Los artículos fueron entregados en el domicilio indicado, la mercancía se entregó en condiciones optimas");
                MySqlCommand comando = new MySqlCommand("SELECT * from salida2clienteestacion3", Mysql.conexion.obtenerConexion());
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView2.DataSource = tabla;
            }
            
        }

        private void BtnAgregarSalidaEstacion1_Click(object sender, EventArgs e)
        {
            new frmReportEst3().ShowDialog();
        }
    }
}
