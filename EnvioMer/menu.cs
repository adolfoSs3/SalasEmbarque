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
        private Button currentBtn;
        internal Panel leftBorderBtn;
        //private frmMenuP vistaMenuP;
        public menu()
        {
            InitializeComponent();

            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(3, 70);
            MenuVertical.Controls.Add(leftBorderBtn);
        }
        //codigo para Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam,int lparam);
        //----------------------------

        private struct RGBcolores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color colorB = Color.FromArgb(243, 247, 247);
        }

        private void CargarPaneLeftBtn(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(3, 70);
            MenuVertical.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button          
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(160, 3, 29);
                currentBtn.ForeColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(43, 45, 66);
                currentBtn.ForeColor = Color.Gainsboro;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width.Equals(200))
                MenuVertical.Width = 60;
            else
                MenuVertical.Width = 200;
        }        
       
        private void picturX_Click(object sender, EventArgs e)
        {
            try
            {
              Application.Exit();
            }
            catch (Exception )
            {
                Dispose();
                Application.Exit();                
            }                        
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

        private void picturMenos_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112,0xf012,0);
        }

        //metodo Para abrir el formulario hijo al padre
        private void AbrirFCostos(object formCost)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            Form fh=formCost as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
        }
      
        private void BTNEmbarque_Click(object sender, EventArgs e)
        {
            AbrirFCostos(new FormCostos());
            ActivateButton(sender, RGBcolores.colorB);
        }

        private void BTNMapa_Click(object sender, EventArgs e)
        {
            AbrirFCostos(new Mapa());
            ActivateButton(sender, RGBcolores.colorB);
        }

        private void btnIncoterm_Click(object sender, EventArgs e)
        {
            AbrirFCostos(new Incotems());
            ActivateButton(sender, RGBcolores.colorB);
        }
    }
}
