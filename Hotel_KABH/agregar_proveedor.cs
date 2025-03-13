using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Hotel_KABH
{
    public partial class agregar_proveedor : Form
    {
        private Conexion conm = new Conexion();
        private MySqlConnection Conexiones;
        private MySqlTransaction Transaccion;
        public agregar_proveedor()
        {
            InitializeComponent();
            Conexiones = conm.ConectarDB();
            Transaccion = Conexiones.BeginTransaction();
        }
        private void limpiar()
        {
            idproveedortextBox.Text = "";
            nombre_ptextbox.Text = "";
            paginatextbox.Text = "";
            calletextBox.Text = "";
            numerotextbox.Text = "";
            coloniatextbox.Text = "";
            codpostaltextbox.Text = "";
            ciudadtextbox.Text = "Ciudad Juárez";
            telefonotextbox.Text = "";
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string pap = "INSERT INTO `proveedor` (`id_proveedor`, `nombre_p`, `pagina_web`) VALUES ('"+idproveedortextBox.Text+"', '"+nombre_ptextbox.Text+"', '"+paginatextbox.Text+"');";
            string papt = "INSERT INTO `proveedor_telefono` (`id_proveedor`, `telefono_p`) VALUES ('"+idproveedortextBox.Text+"', '"+telefonotextbox.Text+"');";
            string papd = "INSERT INTO `proveedor_direccion` (`id_proveedor`, `id_direccion_p`, `calle_p`, `numero_p`, `colonia_p`, `codpostal_p`, `ciudad_p`) VALUES ('50', NULL, 'Matachic', '3823', 'Anahuac', '32240', 'Ciudad Juarez');";
            
            MySqlCommand sql = new MySqlCommand(pap, Conexiones, Transaccion);
            MySqlCommand sql2 = new MySqlCommand(papt, Conexiones, Transaccion);
            MySqlCommand sql3 = new MySqlCommand(papd, Conexiones, Transaccion);
            sql.ExecuteNonQuery();
            sql2.ExecuteNonQuery();
            sql3.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Clientes Agregados Correctamente");
            Transaccion.Commit();
            conm.DesconectarDB();
            Conexiones = conm.ConectarDB();
            Transaccion = Conexiones.BeginTransaction();
        }
    }
}
