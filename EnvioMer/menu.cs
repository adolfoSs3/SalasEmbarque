using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnvioMer
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        //codigo para Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam,int lparam);
        //----------------------------
        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                pictureBoxCerrar.Visible = false;
                pictureBoxAbrir.Visible = true;
            }
            
        }

        private void pictureBoxAbrir_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 70)
            {
                MenuVertical.Width = 250;
                pictureBoxCerrar.Visible = true;
                pictureBoxAbrir.Visible = false;
            }
        }

       
        private void picturX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picturMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;//el tamaño sera = a la pantalla principal
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;//de igual modo la localizacion
            picturRestaurar.Visible = true;
            picturMaximizar.Visible = false;
        }

        private void picturRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(999, 584);//restaura a la medida de mi formulario
            picturRestaurar.Visible = false;
            picturMaximizar.Visible = true;
        }

        private void picturMenos_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }
        //metodo Para abrir el formulario hijo al padre
        private void AbrirFCostos(object formCost)
        {
            if (panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh=formCost as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void bunifuFlatButtonCosto_Click(object sender, EventArgs e)
        {
            AbrirFCostos(new FormCostos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mysql.conexion.obtenerConexion();
            MessageBox.Show("exito");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFCostos(new Mapa());
        }
    }
}
