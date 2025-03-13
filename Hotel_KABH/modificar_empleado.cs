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
    public partial class modificar_empleado : Form
    {
        private Conexion nConexion = new Conexion();
        public modificar_empleado(string id_empleado)
        {
            InitializeComponent();
            consulta(id_empleado);
        }
        private void consulta(string id)
        {
            int id_emp;
            MySqlDataReader dr;
            string consulta = "SELECT * FROM `empleado` WHERE id_empleado = '"+id+"'";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id_emp = dr.GetInt32("id_empleado");
                    string nombre = dr.GetString("nombre");
                    string apaterno = dr.GetString("apaterno");
                    string amaterno = dr.GetString("amaterno");
                    string turno = dr.GetString("turno");
                    int id_area = dr.GetInt32("id_area");
                    int id_puesto = dr.GetInt32("id_puesto");
                    string contra = dr.GetString("contrasena");

                    nombretextBox.Text = nombre;
                    apaternotextBox.Text = apaterno;
                    amaternotextBox.Text = amaterno;
                    passwordtextbox.Text = contra;
                    areacomboBox.SelectedIndex = id_area -1 ;
                    puestocomboBox.SelectedIndex= id_puesto -1 ;
                    turnocomboBox.SelectedIndex = turnocomboBox.Items.IndexOf(turno) ;

                }
                MessageBox.Show("Usuario Agregado Correctamente");
                dr.Close();
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
        }
    }
}
