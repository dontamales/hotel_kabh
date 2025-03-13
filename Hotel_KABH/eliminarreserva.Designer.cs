namespace Hotel_KABH
{
    partial class eliminarreserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(154, 113);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(94, 29);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Cliente:";
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(198, 51);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(148, 27);
            this.idtextbox.TabIndex = 3;
            // 
            // eliminarreserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 187);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtextbox);
            this.Name = "eliminarreserva";
            this.Text = "eliminarreserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EliminarButton;
        private Label label1;
        private TextBox idtextbox;
    }
}