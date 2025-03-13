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
    public partial class eliminar_proveedor : Form
    {
        private Conexion nConexion = new Conexion();
        public eliminar_proveedor()
        {
            InitializeComponent();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
                string consulta = "DELETE FROM `proveedor` WHERE `id_proveedor` = '" + idporvetextbox.Text+"';" +
                    "DELETE FROM `proveedor_direccion` WHERE `id_proveedor` = '"+ idporvetextbox.Text + "';" +
                    "DELETE FROM `proveedor_telefono` WHERE `id_proveedor` = '"+idporvetextbox.Text+"';";
                if (nConexion.ConectarDB() != null)
                {
                    MySqlCommand cmd = new MySqlCommand(consulta);
                    cmd.Connection = nConexion.ConectarDB();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Proveedor Eliminado Exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró al proveedor con el ID especificado");
                    }
                }
                else
                {
                    MessageBox.Show("Problemas de conexión a la BD");
                }
        }
    }
}
