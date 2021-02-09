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
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable td;

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
            dataGridViewMapa.Columns[1].Visible = false;
            dataGridViewMapa.Columns[2].Visible = false;
            //-----------------------------------------------
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Latitudinicial, lninicial);
            gMapControl1.MinZoom = 0; //lo minimo para el usuario
            gMapControl1.MaxZoom = 20;//lo maximo para el usuario
            gMapControl1.Zoom = 30; //es el zoom inicial
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle (new PointLatLng(Latitudinicial, lninicial), GMarkerGoogleType.green);
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

        private void Mapa_DoubleClick(object sender, EventArgs e)
        {
            //double lat = gMapControl1.FromLocalToLatLng(e.X , e.Y).Lat;//checar error
            //double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;//chcar error
        }
    }
}
