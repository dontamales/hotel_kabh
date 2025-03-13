using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_KABH
{
    public partial class r_prueba : Form
    {
        Conexion mConexion = new Conexion();
        public r_prueba()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //SELECT * FROM `reserva` WHERE 1
            //SELECT id_habitacion FROM reserva WHERE fecha_llegada > '2023-06-09 19:51:53' OR fecha_salida < ''
            string fechaSeleccionada = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string consulta = "SELECT id_habitacion FROM reserva WHERE fecha_llegada > '"+ fechaSeleccionada + "' OR fecha_salida< '"+ fechaSeleccionada + "'";
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
    }
}
