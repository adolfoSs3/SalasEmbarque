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
using System.Configuration;

namespace EnvioMer
{
    public partial class Login : Form
    {
        //crea esta tabla en tu BD y pon tu usuario pa probar
                //        CREATE TABLE `usuario` (
                //  `ID` int (11) NOT NULL AUTO_INCREMENT,
                //  `Nombre` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
                //  `ApellidoP` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
                //  `ApellidoM` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
                //  `User` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
                //  `Pass` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
                //  `Tipo` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
                //  `Institucion` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
                //  PRIMARY KEY(`ID`)
                //) ENGINE=InnoDB AUTO_INCREMENT = 2 DEFAULT CHARSET = utf8 COLLATE=utf8_unicode_ci;



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


                //MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["SQL_Conection"].ConnectionString);
                MySqlCommand comando = new MySqlCommand();
                connection.Open();
                comando.Connection = connection;
                comando.CommandText = "SELECT User FROM usuario WHERE User = @Usuario AND Pass = @pass";
                comando.Prepare();
                comando.Parameters.AddWithValue("@Usuario", user);
                comando.Parameters.AddWithValue("@pass", pass);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    new menu().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Revise los datos que ingreso", "ERROR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
