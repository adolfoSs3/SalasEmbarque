using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            }
            else            
            if (dato == "LCL Contenedor Compartido")
            {
                panelLCL.Visible = true;
                panelFCL.Visible = false;
                labelLCL.Visible = true;
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
        {
            combomonedaAEreo.DropDownStyle = ComboBoxStyle.DropDownList;//no se cambie el contenido del combo
            comboPagoEn.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSeguriSN.DropDownStyle = ComboBoxStyle.DropDownList;
            combomonedaAEreo.DropDownStyle = ComboBoxStyle.DropDownList;
            string a = Convert.ToString(comboSeguriSN.SelectedItem); ;

            if (a == "SI")
            {
                comboPorcentaje.Visible = true;
                DatosAereo.Seguro = a;
               
            }
            else if (a == "NO")
            {
                comboPorcentaje.Visible = false;
                DatosAereo.Porcentaje = 0;
            }
        }

        private void Btngregar_Click(object sender, EventArgs e)
        {
          

            {
                
                DatosAereo.Origen = textOrigen.Text;
                DatosAereo.Destino = textDestino.Text;
                DatosAereo.Pago_en = comboPagoEn.Text;
                DatosAereo.Cantidad = int.Parse(textCantidad.Text);
                DatosAereo.Peso = double.Parse(textPeso.Text);
                DatosAereo.Volumen = double.Parse(textVolumen.Text);
                DatosAereo.Descripcion = TxtDescripcion.Text;
               
                DatosAereo.Moneda = combomonedaAEreo.Text;
                DatosAereo.CostoEnvio = double.Parse(textCostoEnvio.Text);

                funciones.AgregarAereos(DatosAereo);
                MessageBox.Show("Agregado");

            }
          



        }

       
    }
}
