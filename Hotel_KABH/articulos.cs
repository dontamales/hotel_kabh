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
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Hotel_KABH
{
    public partial class articulos : Form
    {
        private Conexion nConexion = new Conexion();
        public articulos()
        {
            InitializeComponent();
            actualizartabla();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void actualizartabla()
        {
            string consulta = "SELECT nombre_a, stock, precio FROM `articulo` WHERE 1";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
            //SELECT nombre_a, stock, precio FROM `articulo` WHERE 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            string consulta = "UPDATE articulo SET articulo.stock = articulo.stock + '"+stocktextBox.Text+"' WHERE id_articulo = '"+ (rellecomboBox.SelectedIndex + 1) + "'";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
            actualizartabla();
        }

        private void Sacarbutton_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            string consulta = "UPDATE articulo SET articulo.stock = articulo.stock - '" + stocktextBox.Text + "' WHERE id_articulo = '" + (rellecomboBox.SelectedIndex + 1) + "'";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
            actualizartabla();
        }
    }
}
