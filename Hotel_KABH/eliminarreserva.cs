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
    public partial class eliminarreserva : Form
    {
        private Conexion nConexion = new Conexion();
        public eliminarreserva()
        {
            InitializeComponent();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM `reserva` WHERE `id_cliente` = '" + idtextbox.Text + "'";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario Eliminado Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario con el ID especificado");
                }
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
        }
    }
}
