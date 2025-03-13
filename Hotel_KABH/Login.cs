using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace Hotel_KABH
{
    public partial class Login : Form
    {
        public Point mouseLocation;
        private Conexion nConexion = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string apellidos = "";
            int tipo = 0;
            MySqlDataReader dr;
            string consulta = "SELECT * FROM `empleado` WHERE `id_empleado` = '" + Usuariotextbox.Text + "' AND `contrasena` = '" + Passwordtextbox.Text + "'";
            if (nConexion.ConectarDB() != null)
            {
                MySqlCommand cmd = new MySqlCommand(consulta);
                cmd.Connection = nConexion.ConectarDB();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    while (dr.Read()) {
                        nombre = dr.GetString("nombre");
                        apellidos = dr.GetString("apaterno");
                        apellidos += " " + dr.GetString("amaterno");
                        tipo = dr.GetInt32("id_puesto");
                    }
                } else {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }

                dr.Close();
            }
            else
            {
                MessageBox.Show("Problemas de conexión a la BD");
            }
            if (tipo == 1) {
                MessageBox.Show("Bienvenido "+ nombre + ", has entrado como Administrador");
                this.Hide();
                Menu fm = new Menu(tipo, nombre, apellidos);
                fm.Show();
            } else if (tipo == 2) {
                MessageBox.Show("Bienvenido "+ nombre + ", has entrado como Empleado");
                this.Hide();
                Menu fm1 = new Menu(tipo, nombre, apellidos);
                fm1.Show();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation= new Point(-e.X,-e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gfxPath = new GraphicsPath();
            Rectangle rect = button1.ClientRectangle;
            int radius = 20; // ajusta este valor para cambiar el radio del borde redondeado
            gfxPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gfxPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            gfxPath.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            gfxPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            gfxPath.CloseFigure();
            button1.Region = new Region(gfxPath);
        }
    }
}
