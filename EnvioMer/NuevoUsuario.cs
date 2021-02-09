using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EnvioMer
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string apP = txtApellidoP.Text;
            string apM = txtApellidoM.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string query = $"INSERT INTO `usuario`(`Nombre`, `ApellidoP`, `ApellidoM`, `User`, `Pass`, `Tipo`, `Institucion`) " +
                                        $"VALUES ('{nom}','{apP}','{apM}','{user}','{pass}','alumno','{Login.institucion}')";
            try
            {                
                MySqlCommand comando = new MySqlCommand(query, Mysql.conexion.obtenerConexion());
                comando.ExecuteNonQuery();                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
