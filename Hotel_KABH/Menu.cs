using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hotel_KABH
{
    public partial class Menu : Form
    {
        public Menu(int tipo, string nombre, string apellidos){
            InitializeComponent();
            Usuariolabel.Text = nombre;
            Apellidoslabel.Text = apellidos;
            if (tipo == 1)
            {
                EmpleadosButton.Visible = true;
                EmpleadosButton.Visible = true;
                Tipolabel.Text = "Administrador";
            }
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //this.WindowState = FormWindowState.Minimized;
        //Cambiar el Anchor de botones Close, mmini
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if(MenuVert.Width == 208)
            {
                MenuVert.Width= 62;
                label1.Visible = false;
                Usuariolabel.Visible = false;
                Apellidoslabel.Visible= false;
                Tipolabel.Visible = false;
            } else
            {
                label1.Visible= true;
                MenuVert.Width = 208;
                Usuariolabel.Visible = true;
                Apellidoslabel.Visible = true;
                Tipolabel.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        private void maximizarpb_Click(object sender, EventArgs e)
        {
            lx = this.Location.X; ly = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            maximizarpb.Visible= false;
            restaurarpb.Visible= true;
        }

        private void restaurarpb_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            this.Location = new Point(lx, ly);
            maximizarpb.Visible = true;
            restaurarpb.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object formhijo)
        {
            if(this.ContenedorPanel.Controls.Count > 0)
                this.ContenedorPanel.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.ContenedorPanel.Controls.Add(fh);
            this.ContenedorPanel.Tag = fh;
            fh.Show();
        }

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void EmpleadosButton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MostrarEmpleado_Eliminable());
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.ContenedorPanel.Region = region;
            this.Invalidate();
        }

        private void ClientesAgrebutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new agregarClientes());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void articulosbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new articulos());
        }

        private void reservabutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new reserva());
        }

        private void proveedoresbutton_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new proveedores());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

    }
}
