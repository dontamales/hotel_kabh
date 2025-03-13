namespace Hotel_KABH
{
    partial class AgregarEmpleado
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
            this.noempleadotextBox = new System.Windows.Forms.TextBox();
            this.apaternotextBox = new System.Windows.Forms.TextBox();
            this.amaternotextBox = new System.Windows.Forms.TextBox();
            this.areacomboBox = new System.Windows.Forms.ComboBox();
            this.puestocomboBox = new System.Windows.Forms.ComboBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.turnocomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // noempleadotextBox
            // 
            this.noempleadotextBox.Location = new System.Drawing.Point(204, 58);
            this.noempleadotextBox.Name = "noempleadotextBox";
            this.noempleadotextBox.Size = new System.Drawing.Size(125, 27);
            this.noempleadotextBox.TabIndex = 0;
            // 
            // apaternotextBox
            // 
            this.apaternotextBox.Location = new System.Drawing.Point(204, 144);
            this.apaternotextBox.Name = "apaternotextBox";
            this.apaternotextBox.Size = new System.Drawing.Size(239, 27);
            this.apaternotextBox.TabIndex = 1;
            // 
            // amaternotextBox
            // 
            this.amaternotextBox.Location = new System.Drawing.Point(204, 194);
            this.amaternotextBox.Name = "amaternotextBox";
            this.amaternotextBox.Size = new System.Drawing.Size(239, 27);
            this.amaternotextBox.TabIndex = 2;
            // 
            // areacomboBox
            // 
            this.areacomboBox.FormattingEnabled = true;
            this.areacomboBox.Items.AddRange(new object[] {
            "Recepción",
            "Reservas",
            "Mantenimiento",
            "Limpieza",
            "Administración",
            "Seguridad"});
            this.areacomboBox.Location = new System.Drawing.Point(204, 296);
            this.areacomboBox.Name = "areacomboBox";
            this.areacomboBox.Size = new System.Drawing.Size(125, 28);
            this.areacomboBox.TabIndex = 4;
            // 
            // puestocomboBox
            // 
            this.puestocomboBox.FormattingEnabled = true;
            this.puestocomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.puestocomboBox.Location = new System.Drawing.Point(204, 346);
            this.puestocomboBox.Name = "puestocomboBox";
            this.puestocomboBox.Size = new System.Drawing.Size(125, 28);
            this.puestocomboBox.TabIndex = 5;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(204, 394);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(177, 27);
            this.passwordtextbox.TabIndex = 7;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(188, 458);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(94, 29);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "No. Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(117, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Turno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(126, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(108, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Puesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(72, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(143, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Agregar Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(103, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre:";
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(204, 101);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(239, 27);
            this.nombretextBox.TabIndex = 19;
            // 
            // turnocomboBox
            // 
            this.turnocomboBox.FormattingEnabled = true;
            this.turnocomboBox.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.turnocomboBox.Location = new System.Drawing.Point(204, 244);
            this.turnocomboBox.Name = "turnocomboBox";
            this.turnocomboBox.Size = new System.Drawing.Size(128, 28);
            this.turnocomboBox.TabIndex = 20;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 530);
            this.Controls.Add(this.turnocomboBox);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.puestocomboBox);
            this.Controls.Add(this.areacomboBox);
            this.Controls.Add(this.amaternotextBox);
            this.Controls.Add(this.apaternotextBox);
            this.Controls.Add(this.noempleadotextBox);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox noempleadotextBox;
        private TextBox apaternotextBox;
        private TextBox amaternotextBox;
        private ComboBox areacomboBox;
        private ComboBox puestocomboBox;
        private TextBox passwordtextbox;
        private Button AgregarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox nombretextBox;
        private ComboBox turnocomboBox;
    }
}