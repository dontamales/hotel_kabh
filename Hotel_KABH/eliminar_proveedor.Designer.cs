namespace Hotel_KABH
{
    partial class eliminar_proveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idporvetextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Proveedor";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(153, 116);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(94, 29);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Proveedor:";
            // 
            // idporvetextbox
            // 
            this.idporvetextbox.Location = new System.Drawing.Point(177, 58);
            this.idporvetextbox.Name = "idporvetextbox";
            this.idporvetextbox.Size = new System.Drawing.Size(148, 27);
            this.idporvetextbox.TabIndex = 3;
            // 
            // eliminar_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 179);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idporvetextbox);
            this.Controls.Add(this.label1);
            this.Name = "eliminar_proveedor";
            this.Text = "eliminar_proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button EliminarButton;
        private Label label2;
        private TextBox idporvetextbox;
    }
}