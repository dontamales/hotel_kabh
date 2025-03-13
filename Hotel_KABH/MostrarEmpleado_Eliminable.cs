using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Hotel_KABH
{
    public partial class MostrarEmpleado_Eliminable : Form
    {
        Conexion mConexion = new Conexion();
        public MostrarEmpleado_Eliminable()
        {
            InitializeComponent();
            string consulta = "SELECT empleado.id_empleado,empleado.nombre, empleado.apaterno, empleado.amaterno, area.descripcion, puesto.salario FROM empleado JOIN area ON empleado.id_area = area.id_area JOIN puesto ON empleado.id_puesto = puesto.id_puesto;";
            if (mConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = mConexion.ConectarDB();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            AgregarEmpleado af = new AgregarEmpleado();
            af.Show();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            EliminarEmpleado ef = new EliminarEmpleado();
            ef.Show();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var valorCelda = dataGridView1.SelectedRows[0].Cells[0].Value;

                if (valorCelda != null)
                {
                    string id_employed = valorCelda.ToString();

                    modificar_empleado me = new modificar_empleado(id_employed);
                    me.Show();
                }
            }
        }
    }
}
