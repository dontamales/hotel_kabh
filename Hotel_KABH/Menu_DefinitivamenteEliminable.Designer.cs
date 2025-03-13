namespace Hotel_KABH
{
    partial class Menu_DefinitivamenteEliminable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.agregarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.mostrarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarbutton
            // 
            this.agregarbutton.Location = new System.Drawing.Point(105, 49);
            this.agregarbutton.Name = "agregarbutton";
            this.agregarbutton.Size = new System.Drawing.Size(244, 142);
            this.agregarbutton.TabIndex = 0;
            this.agregarbutton.Text = "Agregar";
            this.agregarbutton.UseVisualStyleBackColor = true;
            this.agregarbutton.Visible = false;
            this.agregarbutton.Click += new System.EventHandler(this.agregarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(423, 49);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(277, 142);
            this.eliminarbutton.TabIndex = 1;
            this.eliminarbutton.Text = "Eliminar Empleado";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Visible = false;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // mostrarbutton
            // 
            this.mostrarbutton.Location = new System.Drawing.Point(254, 224);
            this.mostrarbutton.Name = "mostrarbutton";
            this.mostrarbutton.Size = new System.Drawing.Size(269, 169);
            this.mostrarbutton.TabIndex = 2;
            this.mostrarbutton.Text = "Mostrar Empleados";
            this.mostrarbutton.UseVisualStyleBackColor = true;
            this.mostrarbutton.Click += new System.EventHandler(this.mostrarbutton_Click);
            // 
            // Menu_DefinitivamenteEliminable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.agregarbutton);
            this.Name = "Menu_DefinitivamenteEliminable";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private Button agregarbutton;
        private Button eliminarbutton;
        private Button mostrarbutton;
    }
}