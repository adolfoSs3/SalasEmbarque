using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EnvioMer
{
    public partial class Mapa : Form
    {
        funciones Funcionnnes = new funciones();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable td;
        //------------------------------------
        double[] ArrLatidud = new double[10]; // Declaración del array
        double[] ArrLongitud = new double[10];
        

        //------------------------------------

        int filaseleccionada = 0;
        double Latitudinicial = 19.039670;
        double lninicial = -98.219604;

        public Mapa()
        {
            InitializeComponent();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            td = new DataTable();           
            td.Columns.Add(new DataColumn("Descripción", typeof(string)));
            td.Columns.Add(new DataColumn("Latitud", typeof(double)));
            td.Columns.Add(new DataColumn("Longitud",typeof(double)));
          

            td.Rows.Add("Ubicación 1", Latitudinicial, lninicial);
            dataGridViewMapa.DataSource = td;

            //hacer que el usuario no pueda visualizar las columnas Latitud y longitud
            //dataGridViewMapa.Columns[1].Visible = false;
            //dataGridViewMapa.Columns[2].Visible = false;
            //-----------------------------------------------
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Latitudinicial, lninicial);
            gMapControl1.MinZoom = 0; //lo minimo para el usuario
            gMapControl1.MaxZoom = 20;//lo maximo para el usuario
            gMapControl1.Zoom = 50; //es el zoom inicial
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle (new PointLatLng(Latitudinicial, lninicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);//agregamos al mapa

            //texto en el marcador
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{1} \n Longitud:{1}", Latitudinicial, lninicial);

            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void Mapa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            //asignamos valores a las cajas de texto y despues mandamos a la bd
            filaseleccionada = e.RowIndex;
            txtDescripcion.Text = dataGridViewMapa.Rows[filaseleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridViewMapa.Rows[filaseleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridViewMapa.Rows[filaseleccionada].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
            //se posicione el foco del mapa en ese punto 
            gMapControl1.Position = marker.Position;
        }

      

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //se posiciona en el txt en la latitud y la longitud
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            //validacion para que se llenen los datos del destino
            string la = Convert.ToString(txtlatitud2.Text);
            string lg = Convert.ToString(txtLongitud2.Text);
            string la2 = Convert.ToString(txtLongitud.Text);
            if (la == ""& lg=="") {
                txtdescripcion2.Text = txtDescripcion.Text;
                txtlatitud2.Text = txtLatitud.Text;
                txtLongitud2.Text = txtLongitud.Text;

                txtDescripcion.Clear();
                txtLatitud.Clear();
                txtLongitud.Clear();

            }else
                if (la2 == la)
            {
                txtDescripcion.Clear();
                txtLatitud.Clear();
                txtLongitud.Clear();
            }
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);                      
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //agrega los datos al DatiGrid...
            td.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);
            //manda nuevamente los datos al otro grupo de Textbox 
            txtdescripcion2.Text=txtDescripcion.Text;
            
            //------------Prueba------------------------------
            Funcionnnes.CalcularDistancia(txtdescripcion2,dataGridViewPrueba,txtLatitud,txtlatitud2,txtLongitud,txtLongitud2);
            // al mismo tiempo limpia lisde el primer grupo
           

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            dataGridViewMapa.Rows.RemoveAt(filaseleccionada);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}