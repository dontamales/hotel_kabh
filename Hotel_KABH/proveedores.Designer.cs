namespace Hotel_KABH
{
    partial class proveedores
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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarButton.Location = new System.Drawing.Point(690, 252);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EliminarButton.Size = new System.Drawing.Size(94, 29);
            this.EliminarButton.TabIndex = 8;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ModificarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModificarButton.Location = new System.Drawing.Point(690, 185);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModificarButton.Size = new System.Drawing.Size(94, 29);
            this.ModificarButton.TabIndex = 7;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = false;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AgregarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarButton.Location = new System.Drawing.Point(690, 121);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgregarButton.Size = new System.Drawing.Size(94, 29);
            this.AgregarButton.TabIndex = 6;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(632, 354);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_KABH.Properties.Resources.CerrarNuevo;
            this.pictureBox1.Location = new System.Drawing.Point(724, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "proveedores";
            this.Text = "proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button EliminarButton;
        private Button ModificarButton;
        private Button AgregarButton;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}