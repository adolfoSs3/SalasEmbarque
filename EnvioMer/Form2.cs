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
using System.Configuration;


namespace EnvioMer
{
    public partial class FormCostos : Form
    {
        datos TodosLosDatos = new datos();
        DatosFCL DatosFCL = new DatosFCL();
        funciones Funciones = new funciones();
        DatosLCL DatosLCL = new DatosLCL();
        DatosAereo DatosAereo = new DatosAereo();
       
        
        public FormCostos()
        {
            InitializeComponent();
        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {                              
            string dato = comboBoxTipoEnvio.Text;

            if (dato == "FCL Contenedor Completo")
            {
                panelFCL.Visible = true;
                panelLCL.Visible = false;
                labelFCL.Visible = true;
                labelLCL.Visible = false;
            }
            else            
            if (dato == "LCL Contenedor Compartido")
            {
                panelLCL.Visible = true;
                panelFCL.Visible = false;
                labelLCL.Visible = true;
                labelFCL.Visible = false;
            }

            //llenado de la tabla maritimo en mysql
            try
            {
                TodosLosDatos.OrCompra = int.Parse(TXTidCompra.Text);
                TodosLosDatos.Incoterm = comboBoxIcoterm.Text;
                TodosLosDatos.TipEnvio = comboBoxTipoEnvio.Text;
                TodosLosDatos.TipMoneda = comboBoxMoneda.Text;
                TodosLosDatos.P_Origen = textBoxOrigenPuerto.Text;
                TodosLosDatos.P_destino = textBoxDestinoPuerto.Text;
                int retorno = funciones.agregarT(TodosLosDatos);
            }
            catch (Exception EX) {
                MessageBox.Show("Detalles" + EX);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosFCL.Cantidad = int.Parse(textCantidadPaquetesFCL.Text);
                DatosFCL.Tipo_Contenedor = comboTipoCont.Text;
                DatosFCL.Costo_Contenedor = double.Parse(textCostoXcontenedor.Text);
                DatosFCL.idEmbarque = int.Parse(TXTidCompra.Text);
                //multiplicacion para obtener el costo total este se agrega directo a la bd
                int Cantidad= int.Parse(textCantidadPaquetesFCL.Text);
                double CostoXC= double.Parse(textCostoXcontenedor.Text);
                double resultado = Cantidad * CostoXC;
                DatosFCL.Costo_Total = resultado;
           

            //condiciones para el Panel que contiene FCL
            DialogResult result = MessageBox.Show("¿Quieres agregar un contenedor completo(FCL)?", "Agregar", MessageBoxButtons.YesNo);
                {
                    if (result==DialogResult.Yes)
                    {
                        textCantidadPaquetesFCL.Clear();
                        textCostoXcontenedor.Clear();
                        int retorno = funciones.agregarfcl(DatosFCL);
                    MessageBox.Show("Agregado");
                    }
                else if (result == DialogResult.No)
                {
                   DialogResult r2= MessageBox.Show("¿Quieres Cambiar de contenedor?", "",MessageBoxButtons.YesNo);
                    {
                        if (r2 == DialogResult.Yes)
                        {
                            TXTidCompra.Clear();
                            panelFCL.Visible = false;
                                panelLCL.Visible = true;
                            textCantidadPaquetesFCL.Clear();
                            textCostoXcontenedor.Clear();
                        }
                        else if (r2 == DialogResult.No)
                        {
                            
                        }
                    }
                }
                    //Se muestran los datos de la tabla FCL
                    Funciones.ConsultaFCL(dataGridTablaFCL,TXTidCompra);
                    //se muestra el costo total de los contenedores
                    LblTotal.Text = Funciones.CostoFinalFCL(TXTidCompra).ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);                
            }
        }
        //------------------Campos LCL-----------------------------------        
       
        private void BtnAgregarLCL_Click(object sender, EventArgs e)
        {
            try
            {
                double Volumen = double.Parse(TxtVolumenLCL.Text);
                //.-----------------------------
                DatosLCL.PaqueteN = int.Parse(TxtNPaquetesLCL.Text);           
                DatosLCL.peso = double.Parse(TxtPesoLCL.Text);
                DatosLCL.Volumen = Volumen;
                DatosLCL.costo = double.Parse(TxtCostoLCL.Text);
                DatosLCL.idEmbarque = Convert.ToInt32(TXTidCompra.Text);
                if (Volumen>=14.0) {
                    MessageBox.Show("DEMASIADO VOLUMEN PARA UN ENVÍO LCL, El volumen cotizado es demasiado alto para que el envío tenga un precio óptimo. Por favor cotiza un contenedor completo para optimizar tu envío.");
                    TxtVolumenLCL.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Quieres agregar un contenedor(LCL)?", "Agregar", MessageBoxButtons.YesNo);
                    {
                        if (result == DialogResult.Yes)
                        {
                            TxtCostoLCL.Clear();
                            TxtVolumenLCL.Clear();
                            TxtPesoLCL.Clear();
                            int retorno = funciones.agregar(DatosLCL);
                            MessageBox.Show("Agregado");
                        }
                        else if (result == DialogResult.No)
                        {
                            DialogResult r2 = MessageBox.Show("¿Quieres Cambiar de contenedor?", "", MessageBoxButtons.YesNo);
                            {
                                if (r2 == DialogResult.Yes)
                                {
                                    TXTidCompra.Clear();
                                    panelFCL.Visible = true;
                                    panelLCL.Visible = false;
                                    TxtCostoLCL.Clear();
                                    TxtVolumenLCL.Clear();
                                    TxtPesoLCL.Clear();
                                }
                                else if (r2 == DialogResult.No)
                                {

                                }
                            }
                        }
                        //Se muestran los datos de la tabla FCL
                        Funciones.ConsultaLCL(dataGridTablaLCL, TXTidCompra);
                        //se muestra el costo total de los contenedores
                        labelLCLTotal.Text = Funciones.CostoFinalLCL(TXTidCompra).ToString();
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }
        }

        //----------------Aereo---------------------------------------------

        private void comboSeguriSN_SelectedIndexChanged(object sender, EventArgs e)
        {           //valida si el usuario decea tener Seguro
            string a = Convert.ToString(comboSeguriSN.SelectedItem); ;
            if (a == "SI")
            {
                comboPorcentaje.Visible = true;
                comboSeguriSN.Text = a;               
            }
            else if (a == "NO")
            {
                comboPorcentaje.Visible = false;
                comboPorcentaje.Text = 0.ToString();
            }
        }

        private void Btngregar_Click(object sender, EventArgs e)
        {
          try
          {
                //variables para realisa el calcular el precio del envio
                double precio = double.Parse(textValorDeclarado.Text);
                int cantidad = int.Parse(textCantidad.Text);
                double envio = double.Parse(textCostoEnvio.Text);
                int porcentaje = int.Parse(comboPorcentaje.Text);
                double total, seguro;
                seguro = (((precio * cantidad) + envio)*porcentaje)/100;
                total= (precio * cantidad) + envio+seguro;
                //-------------------------------------------------------
                labelSeguro.Text = seguro.ToString();
                labelCEnvio.Text = total.ToString();
                //----------------------------------------------------

                DatosAereo.Origen = textOrigen.Text;
                DatosAereo.Destino = textDestino.Text;
                DatosAereo.Pago_en = comboPagoEn.Text;
                DatosAereo.Cantidad = int.Parse(textCantidad.Text);
                DatosAereo.Peso = double.Parse(textPeso.Text);
                DatosAereo.Volumen = double.Parse(textVolumen.Text);
                DatosAereo.Descripcion = TxtDescripcion.Text;
                DatosAereo.Porcentaje = int.Parse(comboPorcentaje.Text);
                DatosAereo.Moneda = combomonedaAEreo.Text;
                DatosAereo.CostoEnvio = double.Parse(textCostoEnvio.Text);
                DatosAereo.ValorDeclarado = double.Parse(textValorDeclarado.Text);
                DatosAereo.Seguro = comboSeguriSN.Text;
                DatosAereo.TipoServicio = comboServicio.Text;
                funciones.AgregarAereos(DatosAereo);
                MessageBox.Show("Agregado");
                Funciones.ConsultaAereo(dataGridAereo);

                textOrigen.Text="Origen";
                textDestino.Text="Destino";
                comboPagoEn.Text="Pago en ";
                textCantidad.Text="Cantidad";
                textPeso.Text="Peso Kg";
                textVolumen.Text="olumen m3";
                TxtDescripcion.Text="Descripción";
                comboPorcentaje.Text="Cantidad";
                combomonedaAEreo.Text="Moneda";
                textCostoEnvio.Text="Costo Del Envio";
                textValorDeclarado.Text="Valor declarado";
          }
          catch(Exception ex)
          {
                MessageBox.Show("Error en " + ex.Message);
          }
        }

        private void dataGridAereo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {//no se cambie el contenido del combo
            combomonedaAEreo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServicio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region validacion
        private void TXTidCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtNPaquetesLCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPesoLCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtVolumenLCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCostoLCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCantidadPaquetesFCL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCostoXcontenedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCostoEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textVolumen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textValorDeclarado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        } 
        #endregion

        private void TXTidCompra_Leave(object sender, EventArgs e)
        {
            MySqlConnection connection;
            string connectionQuery = ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString;
            bool status;

            try
            {
                connection = new MySqlConnection(connectionQuery);
                MySqlCommand comando = new MySqlCommand();
                connection.Open();
                comando.Connection = connection;
                comando.CommandText = $"SELECT `OrdenCompra` FROM `maritimo` WHERE `OrdenCompra` = '{TXTidCompra.Text}'";
                comando.Prepare();
                MySqlDataReader reader = comando.ExecuteReader();
                status = reader.Read() ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                status = false;
            }

            if (status.Equals(true))
            {
                MessageBox.Show("La orden de producción ya Existe", "ERROR");
                TXTidCompra.Focus();
            }
        }
    }
}
