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
    public partial class Login : Form
    {
        


        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            try
            {
                //adapta esto a tu codigo es decir tu cadena de conexion plox por q truena culero
                
                MySqlCommand comando = new MySqlCommand($"SELECT User FROM usuario WHERE User = '{user}' AND Pass = '{pass}'", Mysql.conexion.obtenerConexion());                               

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    new menu().Show();
                    Hide();
                }
                else                
                    MessageBox.Show("Revise los datos que ingreso", "ERROR");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
