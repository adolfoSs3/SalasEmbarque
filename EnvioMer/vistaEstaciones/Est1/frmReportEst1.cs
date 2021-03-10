using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioMer.vistaEstaciones.Est1
{
    public partial class frmReportEst1 : Form
    {
        CREst1 reporte;
        public frmReportEst1()
        {
            InitializeComponent();
            LlenarReporte();
        }

        public void LlenarReporte()
        {
            reporte = new CREst1();

            reporte.SetParameterValue("CodBarra", ValEstaticEST1.Cod_Barra);
            reporte.SetParameterValue("Operador", ValEstaticEST1.Operador);
            reporte.SetParameterValue("Origen", ValEstaticEST1.Origen);
            reporte.SetParameterValue("Puerto_Salida", ValEstaticEST1.Puerto_Salida);
            reporte.SetParameterValue("Factura", ValEstaticEST1.Factura);
            reporte.SetParameterValue("Incoterms", ValEstaticEST1.Incoterms);
            reporte.SetParameterValue("Bill_Of_Lading", ValEstaticEST1.Bill_Of_Lading);
            reporte.SetParameterValue("Producto", ValEstaticEST1.Producto);
            reporte.SetParameterValue("Packing_List", ValEstaticEST1.Packing_List);
            reporte.SetParameterValue("Pedimento", ValEstaticEST1.Pedimento);
            reporte.SetParameterValue("Cantidad", ValEstaticEST1.Cantidad);

            reporte.SetParameterValue("Cod_Embarque", ValEstaticEST1.Cod_Embarque);
            reporte.SetParameterValue("T_C_Salida", ValEstaticEST1.T_C_Salida);
            reporte.SetParameterValue("Destino", ValEstaticEST1.Destino);
            reporte.SetParameterValue("Puerto_Llegada", ValEstaticEST1.Puerto_Llegada);
            reporte.SetParameterValue("Fecha_Salida", ValEstaticEST1.Fecha_Salida);

            ReportView.ReportSource = reporte;
        }
    }
}