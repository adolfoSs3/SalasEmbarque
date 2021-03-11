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
        funciones fun = new funciones();
        FacturaParte1 Factu1 = new FacturaParte1();
        FacturaComercialP2PRopiedadesUnoo1 Factu2PArte1 = new FacturaComercialP2PRopiedadesUnoo1();
        FacturaComercialP2PRopiedadesDoos2 Factu2Parte2 = new FacturaComercialP2PRopiedadesDoos2();
        public FacturaComercial()
        {
            InitializeComponent();
            cmbPartiesTransa.SelectedIndex = 0;
            comboBoxReasonExport.SelectedIndex = 0;
        }

        private void FacturaComercial_Load(object sender, EventArgs e)
        {
            fun.Parte1Fact(txtFactura, txtIncoterm);//primera pestaña
        }
        //-----------------------Primera Parte-------------------------------
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
                        //limpia los campos
                        txtNidentifi.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtEmail.Clear();
                        txtCompanyName.Clear();
                        txtPais.Clear();
                        txtConoEmbarque.Clear();
                        txtFactura.Clear();
                        txtOrdenCompra.Clear();
                        txtTpago.Clear();

                        tabControl1.SelectedIndex = 1;
                    }

                }
            }
        }
        //----------------termino 1 Parte
        //----------------Segunda Parte
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNIdentifi2.Text == "" || txtNombre2.Text == "" || txtTelefono2.Text == "" || txtEmail2.Text == "" || txtNombreDirecion2.Text == "" || txtPais2.Text == "" || txtNIdentifi2to2.Text == "" || txtNombre2to2.Text == "" || txtTelefono2to2.Text == "" || txtEmail2to2.Text == "" || txtNombreDirecion2to2.Text == "" || txtPais2to2.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar");
            }
            else
            {
                tabControl1.SelectedIndex = 1;
                DialogResult result = MessageBox.Show("¿Esta seguro?", "Agregar", MessageBoxButtons.YesNo);
                {
                    if (result == DialogResult.Yes)
                    {
                        Factu2PArte1.NIdentifi = int.Parse(txtNIdentifi2.Text);
                        Factu2PArte1.Nombre = txtNombre2.Text;
                        Factu2PArte1.Telefono = txtTelefono2.Text;
                        Factu2PArte1.Email = txtEmail2.Text;
                        Factu2PArte1.Pais = txtPais2.Text;
                        Factu2PArte1.CompanyName = txtNombreDirecion2.Text;
                        //segundaParte 
                        Factu2Parte2.NIdentifi = int.Parse(txtNIdentifi2to2.Text);
                        Factu2Parte2.Nombre = txtNombre2to2.Text;
                        Factu2Parte2.Telefono = txtTelefono2to2.Text;
                        Factu2Parte2.Email = txtEmail2to2.Text;
                        Factu2Parte2.Pais = txtPais2to2.Text;
                        Factu2Parte2.CompanyName = txtNombreDirecion2to2.Text;
                        funciones.FacturaComercialParte2de1Add(Factu2PArte1);
                        funciones.FacturaComercialParte2de2Add(Factu2Parte2);
                        MessageBox.Show("Listo");
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txtNIdentifi2.Text==""|| txtNombre2.Text==""|| txtTelefono2.Text==""|| txtEmail2.Text==""|| txtPais2.Text==""|| txtNombreDirecion2.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar","Error");
            }else
            if (checkBox1.Checked == true)
            {
                txtNIdentifi2to2.Text = txtNIdentifi2.Text;
                txtNombre2to2.Text = txtNombre2.Text; ;
                txtTelefono2to2.Text = txtTelefono2.Text;
                txtEmail2to2.Text = txtEmail2.Text;
                txtPais2to2.Text = txtPais2.Text;
                txtNombreDirecion2to2.Text = txtNombreDirecion2.Text;
            }else
            if (checkBox1.Checked ==false) 
            {
                txtNIdentifi2to2.Clear();
                txtNombre2to2.Clear();
                txtTelefono2to2.Clear();
                txtEmail2to2.Clear();
                txtPais2to2.Clear();
                txtNombreDirecion2to2.Clear();
            }
        }


        private void bntAgregar_Click(object sender, EventArgs e)
        {
            fun.FactutaPate3(dataGMercancia);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #region Validacion
        private void txtNidentifi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNIdentifi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNIdentifi2to2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono2to2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            string val2 = textBox2.Text;
            string val3 = textBox3.Text;
            string val4 = textBox4.Text;
            string val5 = textBox5.Text;
            string val6 = textBox6.Text;
            string val7 = textBox7.Text;
            string[] row = { val1, val2, val3, val4, val5, val6, val7 };
            dataGMercancia.Rows.Add(row);
        }
    }
}
