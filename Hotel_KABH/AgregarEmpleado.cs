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


namespace Hotel_KABH
{
    public partial class AgregarEmpleado : Form
    {
        private Conexion nConexion = new Conexion();
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            string consulta = "INSERT INTO `empleado` (`id_empleado`, `nombre`, `apaterno`, `amaterno`, `turno`, `id_area`, `id_puesto`, `contrasena`) VALUES ('"+noempleadotextBox.Text+"', '"+nombretextBox.Text+"', '"+apaternotextBox.Text+"', '"+amaternotextBox.Text+"', '"+
                turnocomboBox.SelectedItem+"', '"+(areacomboBox.SelectedIndex+1) +"', '"+(puestocomboBox.SelectedIndex+1) +"', '"+passwordtextbox.Text+"');";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                }
                MessageBox.Show("Usuario Agregado Correctamente");
                dr.Close();
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
        }

        
    }
}
