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
    public partial class FacturaComercial : Form
    {
        funciones fun =new funciones();
        FacturaParte1 Factu1 = new FacturaParte1();
        public FacturaComercial()
        {
            InitializeComponent();
        }

        private void FacturaComercial_Load(object sender, EventArgs e)
        {
            fun.Parte1Fact(txtFactura,txtIncoterm);
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            if (txtNidentifi.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtCompanyName.Text == "" || txtPais.Text == "" || txtConoEmbarque.Text == "" || txtOrdenCompra.Text == "" || txtTpago.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar");
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Esta seguro?", "Agregar", MessageBoxButtons.YesNo);
                {
                    if (result == DialogResult.Yes)
                    {
                        Factu1.NIdentifi = int.Parse(txtNidentifi.Text);
                        Factu1.Nombre = txtNombre.Text;
                        Factu1.Telefono = txtTelefono.Text;
                        Factu1.Email = txtEmail.Text;
                        Factu1.CompanyName = txtCompanyName.Text;
                        Factu1.Pais = txtPais.Text;
                        Factu1.PartiesTransaction = cmbPartiesTransa.Text;
                        Factu1.Fecha = dateTimeFecha.Text;
                        Factu1.ConoEmbarque = txtConoEmbarque.Text;
                        Factu1.NFactura = int.Parse(txtFactura.Text);
                        Factu1.OrdenCompra = int.Parse(txtOrdenCompra.Text);
                        Factu1.TPago = txtTpago.Text;
                        Factu1.Incoterm = txtIncoterm.Text;
                        Factu1.ReasonEx = comboBoxReasonExport.Text;
                        funciones.FacturaComercialParte1Add(Factu1);
                        MessageBox.Show("Listo");
                    }

                }
            }
               

        }
    }
}
