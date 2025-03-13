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
    public partial class agregarreserva : Form
    {
        string fecha_reserva, fecha_llegada, fecha_salida;
        private Conexion nConexion = new Conexion();
        public agregarreserva()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            idclientetextbox.Text = "";
            idhabitaciontextbox.Text = "";
            costotextBox.Text = "";
            diastextBox.Text = "";
            tipotextbox.Text = "";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada1 = dateTimePicker1.Value;
             fecha_reserva = fechaSeleccionada1.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            string consulta = "INSERT INTO `reserva` (`id_cliente`, `id_habitacion`, `fecha_reserva`, `fecha_llegada`, `fecha_salida`, `tipo_habitacion`, `dias_reserva`, `costo_habitacion`) VALUES ('"+idclientetextbox.Text+"', '"+idhabitaciontextbox.Text+"', '"+fecha_reserva+"', '"+fecha_llegada+"', '"+fecha_salida+"', '"+tipotextbox.Text+"', '"+diastextBox.Text+"', '"+costotextBox.Text+"');";
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
            limpiar();
        }
    

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada1 = dateTimePicker2.Value;
             fecha_llegada = fechaSeleccionada1.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada1 = dateTimePicker3.Value;
             fecha_salida = fechaSeleccionada1.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
