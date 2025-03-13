using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_KABH
{
    public partial class agregarClientes : Form
    {
        private Conexion conm = new Conexion();
        private MySqlConnection Conexiones;
        private MySqlTransaction Transaccion;
        public agregarClientes()
        {
            InitializeComponent();
            Conexiones = conm.ConectarDB();
            Transaccion = Conexiones.BeginTransaction();
        }

        private void direccioncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (direccioncheckBox.Checked == true) {
                paneldireccion.Visible= true;
            } else {
                paneldireccion.Visible = false;
            }
        }
        private void limpiar()
        {
            idtextBox.Text = "";
            nombretextBox.Text = "";
            apaternotextBox.Text = "";
            amaternotextBox.Text = "";
            identextBox.Text = "";
            emailtextBox.Text = "";
            telstextBox.Text = "";
            calletextBox.Text = "";
            coloniatextBox.Text = "";
            numerotextBox.Text = "";
            codpostaltextBox.Text = "";
            iddirecttextBox.Text = "";
            ciudadtextBox.Text = "Ciudad Juárez";
            paneldireccion.Visible = false;
            direccioncheckBox.Checked = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            limpiar();
            Transaccion.Rollback();
            conm.DesconectarDB();
            this.Close();
        }

        private void agregarclienbutton_Click(object sender, EventArgs e)
        {
            string cac = "INSERT INTO `cliente` (`id_cliente`, `nombre_cliente`, `apaterno_cliente`, `amaterno_cliente`, `identificacion`) VALUES ('"+idtextBox.Text+"', '"+nombretextBox.Text+"', '"+apaternotextBox.Text+"', '"+amaternotextBox.Text+"', '"+identextBox.Text+"');";
            string cact = "INSERT INTO `cliente_telefono` (`id_cliente`, `telefono_c`) VALUES ('"+idtextBox.Text+"', '"+telstextBox.Text+"');";
            string cace = "INSERT INTO `cliente_email` (`id_cliente`, `email_cliente`) VALUES ('"+idtextBox.Text+"', '"+emailtextBox.Text+"');";
            if (direccioncheckBox.Checked == true)
            {
                string cacd = "INSERT INTO `cliente_direccion` (`id_cliente`, `id_direccion_cliente`, `calle_c`, `numero_c`, `colonia_c`, `codpostal_c`, `ciudad_c`) VALUES ('"+ idtextBox.Text + "', '"+ iddirecttextBox.Text + "', '"+calletextBox.Text+"', '"+numerotextBox.Text+"', '"+coloniatextBox.Text+"', '"+codpostaltextBox.Text+"', '"+ciudadtextBox.Text+"');";
                MySqlCommand sql4 = new MySqlCommand(cacd, Conexiones, Transaccion);
                sql4.ExecuteNonQuery();
            }
            MySqlCommand sql = new MySqlCommand(cac, Conexiones, Transaccion);
            MySqlCommand sql2 = new MySqlCommand(cact, Conexiones, Transaccion);
            MySqlCommand sql3 = new MySqlCommand(cace, Conexiones, Transaccion);
            sql.ExecuteNonQuery();
            sql2.ExecuteNonQuery();
            sql3.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Clientes Agregados Correctamente");
        }

        private void insertarbutton_Click(object sender, EventArgs e)
        {
            Transaccion.Commit();
            conm.DesconectarDB();
            Conexiones = conm.ConectarDB();
            Transaccion = Conexiones.BeginTransaction();
        }
    }
}
