namespace Hotel_KABH
{
    partial class Login
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
            this.Usuariotextbox = new System.Windows.Forms.TextBox();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titlebar = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuariotextbox
            // 
            this.Usuariotextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(124)))), ((int)(((byte)(133)))));
            this.Usuariotextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuariotextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usuariotextbox.ForeColor = System.Drawing.Color.White;
            this.Usuariotextbox.Location = new System.Drawing.Point(81, 384);
            this.Usuariotextbox.Name = "Usuariotextbox";
            this.Usuariotextbox.Size = new System.Drawing.Size(350, 25);
            this.Usuariotextbox.TabIndex = 0;
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(124)))), ((int)(((byte)(133)))));
            this.Passwordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordtextbox.ForeColor = System.Drawing.Color.White;
            this.Passwordtextbox.Location = new System.Drawing.Point(81, 465);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.PasswordChar = '*';
            this.Passwordtextbox.Size = new System.Drawing.Size(350, 25);
            this.Passwordtextbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(81, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "No Empleado";
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.Titlebar.Controls.Add(this.label3);
            this.Titlebar.Controls.Add(this.btnminimize);
            this.Titlebar.Controls.Add(this.btnclose);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(525, 50);
            this.Titlebar.TabIndex = 5;
            this.Titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.Titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // btnminimize
            // 
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.Image = global::Hotel_KABH.Properties.Resources.Minimize_Icon;
            this.btnminimize.Location = new System.Drawing.Point(469, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(16, 16);
            this.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnminimize.TabIndex = 7;
            this.btnminimize.TabStop = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = global::Hotel_KABH.Properties.Resources.Close_Icon;
            this.btnclose.Location = new System.Drawing.Point(497, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(16, 16);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnclose.TabIndex = 7;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 698);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 15);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_KABH.Properties.Resources.logo_KABHsinfondo___copia;
            this.pictureBox1.Location = new System.Drawing.Point(81, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bienvenido";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(525, 713);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.Usuariotextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Login";
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Usuariotextbox;
        private TextBox Passwordtextbox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel Titlebar;
        private PictureBox btnminimize;
        private PictureBox btnclose;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}