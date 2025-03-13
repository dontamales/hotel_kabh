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
    public partial class proveedores : Form
    {
        Conexion mConexion = new Conexion();
        public proveedores()
        {
            InitializeComponent();
            string consulta = "SELECT proveedor.nombre_p, proveedor.pagina_web, proveedor_telefono.telefono_p , proveedor_direccion.calle_p  FROM proveedor JOIN proveedor_telefono ON proveedor.id_proveedor = proveedor_telefono.id_proveedor JOIN proveedor_direccion ON proveedor.id_proveedor = proveedor_direccion.id_proveedor;";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
