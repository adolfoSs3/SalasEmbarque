using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvioMer.ambarque;

namespace EnvioMer
{
    public partial class FormCostos : Form
    {
        datos TodosLosDatos = new datos();
        public FormCostos()
        {
            InitializeComponent();
        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //metodo Para abrir el formulario hijo al padre
        private void Abrirform(object form)
        {
            if (PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        //define el titulo segun el embarque
        private void comboBoxTipoEnvio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string dato = Convert.ToString(comboBoxTipoEnvio.SelectedItem);
            if (dato == "FCL Contenedor Completo")
            {
                labelFCL.Visible = true;
            }
            else
                if (dato == "LCL Contenedor Compartido")
            {
                labelLCL.Visible = true;
            }
        }



       

        private void btnaceptar_Click(object sender, EventArgs e)
        {
                  
            string dato = comboBoxTipoEnvio.Text;

            if (dato == "FCL Contenedor Completo")
            {
                Abrirform(new FormFCL());
            }
            else
                if (dato == "LCL Contenedor Compartido")
            {
                Abrirform(new FormLCL());
            }
            
            //llenado de la tabla maritimo en mysql
           
            TodosLosDatos.OrCompra = Convert.ToInt32(idCompra.Text);
            TodosLosDatos.Incoterm = comboBoxIcoterm.Text;
            TodosLosDatos.TipEnvio = comboBoxTipoEnvio.Text;
            TodosLosDatos.TipMoneda = comboBoxMoneda.Text;
            TodosLosDatos.P_Origen = textBoxOrigenPuerto.Text;
            TodosLosDatos.P_destino = textBoxDestinoPuerto.Text;
            int retorno = funciones.agregarT(TodosLosDatos);

        }
    }
}
