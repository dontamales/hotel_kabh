namespace Hotel_KABH
{
    partial class EliminarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noempleadotextBox
            // 
            this.noempleadotextBox.Location = new System.Drawing.Point(200, 64);
            this.noempleadotextBox.Name = "noempleadotextBox";
            this.noempleadotextBox.Size = new System.Drawing.Size(148, 27);
            this.noempleadotextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Empleado:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(194, 125);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(94, 29);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 218);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noempleadotextBox);
            this.Name = "EliminarEmpleado";
            this.Text = "EliminarEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox noempleadotextBox;
        private Label label1;
        private Button EliminarButton;
    }
}