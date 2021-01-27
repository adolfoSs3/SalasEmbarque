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
        GMapOverlay markeroverlay;
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
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Latitudinicial, lninicial);
            gMapControl1.MinZoom = 0; //lo minimo para el usuario
            gMapControl1.MaxZoom = 20;//lo maximo para el usuario
            gMapControl1.Zoom = 30; //es el zoom inicial
            gMapControl1.AutoScroll = true;

        }

      
    }
}
