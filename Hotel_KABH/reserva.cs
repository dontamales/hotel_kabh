using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_KABH
{
    public partial class reserva : Form
    {
        Conexion mConexion = new Conexion();
        public reserva()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //SELECT * FROM `reserva` WHERE 1
            //SELECT id_habitacion FROM reserva WHERE fecha_llegada > '2023-06-09 19:51:53' OR fecha_salida < ''
            string fechaSeleccionada = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string consulta = "SELECT id_cliente, fecha_reserva, fecha_llegada, fecha_salida FROM reserva WHERE fecha_llegada <= '" + fechaSeleccionada + "' AND fecha_salida >= '" + fechaSeleccionada + "'";
            if (mConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = mConexion.ConectarDB();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable habitacionesDisponibles = new DataTable();
                adapter.Fill(habitacionesDisponibles);
                dataGridView1.DataSource = habitacionesDisponibles;
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            agregarreserva ag = new agregarreserva();
            ag.Show();
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            eliminarreserva el = new eliminarreserva();
            el.Show();
        }
    }
}
