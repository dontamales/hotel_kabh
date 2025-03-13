namespace Hotel_KABH
{
    partial class MostrarEmpleado_Eliminable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnclose = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(632, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.AutoSize = true;
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(791, 59);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(18, 20);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AgregarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarButton.Location = new System.Drawing.Point(715, 132);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgregarButton.Size = new System.Drawing.Size(94, 29);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = false;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ModificarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModificarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModificarButton.Location = new System.Drawing.Point(715, 196);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModificarButton.Size = new System.Drawing.Size(94, 29);
            this.ModificarButton.TabIndex = 3;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = false;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarButton.Location = new System.Drawing.Point(715, 263);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EliminarButton.Size = new System.Drawing.Size(94, 29);
            this.EliminarButton.TabIndex = 4;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MostrarEmpleado_Eliminable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 473);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarEmpleado_Eliminable";
            this.Text = "MostrarEmpleado_Eliminable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label btnclose;
        private Button AgregarButton;
        private Button ModificarButton;
        private Button EliminarButton;
    }
}