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
    public partial class Menu_DefinitivamenteEliminable : Form
    {
        public Menu_DefinitivamenteEliminable(int tipo)
        {
            InitializeComponent();
            if(tipo == 1) {
                agregarbutton.Visible= true;
                eliminarbutton.Visible= true;
            }
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            AgregarEmpleado af = new AgregarEmpleado();
            af.Show();
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            EliminarEmpleado ef = new EliminarEmpleado();
            ef.Show();
        }

        private void mostrarbutton_Click(object sender, EventArgs e)
        {
            MostrarEmpleado_Eliminable mf = new MostrarEmpleado_Eliminable();
mf.Show();
        }
    }
}
