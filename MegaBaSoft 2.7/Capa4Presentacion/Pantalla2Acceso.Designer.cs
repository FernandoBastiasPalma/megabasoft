namespace Capa4Presentacion
{
    partial class Pantalla2Acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla2Acceso));
            this.grboxP2ImagenAcceso = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grboxP2Controles = new System.Windows.Forms.GroupBox();
            this.grboxP2Label = new System.Windows.Forms.GroupBox();
            this.lbRunYdv = new System.Windows.Forms.Label();
            this.lblPasswords = new System.Windows.Forms.Label();
            this.grboxP2Textbox = new System.Windows.Forms.GroupBox();
            this.chkP2VerPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP2RunDv = new System.Windows.Forms.TextBox();
            this.txtP2Run = new System.Windows.Forms.TextBox();
            this.txtP2Password = new System.Windows.Forms.TextBox();
            this.btnPantalla2Acceder = new System.Windows.Forms.Button();
            this.grboxP2ImagenAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grboxP2Controles.SuspendLayout();
            this.grboxP2Label.SuspendLayout();
            this.grboxP2Textbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxP2ImagenAcceso
            // 
            this.grboxP2ImagenAcceso.Controls.Add(this.pictureBox1);
            this.grboxP2ImagenAcceso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grboxP2ImagenAcceso.Location = new System.Drawing.Point(12, 12);
            this.grboxP2ImagenAcceso.Name = "grboxP2ImagenAcceso";
            this.grboxP2ImagenAcceso.Size = new System.Drawing.Size(419, 225);
            this.grboxP2ImagenAcceso.TabIndex = 0;
            this.grboxP2ImagenAcceso.TabStop = false;
            this.grboxP2ImagenAcceso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grboxP2Controles
            // 
            this.grboxP2Controles.Controls.Add(this.grboxP2Label);
            this.grboxP2Controles.Controls.Add(this.grboxP2Textbox);
            this.grboxP2Controles.Controls.Add(this.btnPantalla2Acceder);
            this.grboxP2Controles.Location = new System.Drawing.Point(12, 243);
            this.grboxP2Controles.Name = "grboxP2Controles";
            this.grboxP2Controles.Size = new System.Drawing.Size(419, 195);
            this.grboxP2Controles.TabIndex = 1;
            this.grboxP2Controles.TabStop = false;
            // 
            // grboxP2Label
            // 
            this.grboxP2Label.Controls.Add(this.lbRunYdv);
            this.grboxP2Label.Controls.Add(this.lblPasswords);
            this.grboxP2Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grboxP2Label.Location = new System.Drawing.Point(6, 19);
            this.grboxP2Label.Name = "grboxP2Label";
            this.grboxP2Label.Size = new System.Drawing.Size(194, 125);
            this.grboxP2Label.TabIndex = 6;
            this.grboxP2Label.TabStop = false;
            // 
            // lbRunYdv
            // 
            this.lbRunYdv.AutoSize = true;
            this.lbRunYdv.Location = new System.Drawing.Point(41, 39);
            this.lbRunYdv.Name = "lbRunYdv";
            this.lbRunYdv.Size = new System.Drawing.Size(80, 13);
            this.lbRunYdv.TabIndex = 9;
            this.lbRunYdv.Text = "RUN + DIGITO";
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.lblPasswords.Location = new System.Drawing.Point(41, 79);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(70, 13);
            this.lblPasswords.TabIndex = 9;
            this.lblPasswords.Text = "PASSWORD";
            this.lblPasswords.Click += new System.EventHandler(this.label2_Click);
            // 
            // grboxP2Textbox
            // 
            this.grboxP2Textbox.Controls.Add(this.chkP2VerPassword);
            this.grboxP2Textbox.Controls.Add(this.label3);
            this.grboxP2Textbox.Controls.Add(this.txtP2RunDv);
            this.grboxP2Textbox.Controls.Add(this.txtP2Run);
            this.grboxP2Textbox.Controls.Add(this.txtP2Password);
            this.grboxP2Textbox.Location = new System.Drawing.Point(206, 19);
            this.grboxP2Textbox.Name = "grboxP2Textbox";
            this.grboxP2Textbox.Size = new System.Drawing.Size(207, 125);
            this.grboxP2Textbox.TabIndex = 5;
            this.grboxP2Textbox.TabStop = false;
            this.grboxP2Textbox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkP2VerPassword
            // 
            this.chkP2VerPassword.AutoSize = true;
            this.chkP2VerPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkP2VerPassword.Location = new System.Drawing.Point(6, 102);
            this.chkP2VerPassword.Name = "chkP2VerPassword";
            this.chkP2VerPassword.Size = new System.Drawing.Size(90, 17);
            this.chkP2VerPassword.TabIndex = 7;
            this.chkP2VerPassword.Text = "Ver password";
            this.chkP2VerPassword.UseVisualStyleBackColor = true;
            this.chkP2VerPassword.CheckedChanged += new System.EventHandler(this.chkVerPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // txtP2RunDv
            // 
            this.txtP2RunDv.Location = new System.Drawing.Point(151, 32);
            this.txtP2RunDv.Name = "txtP2RunDv";
            this.txtP2RunDv.Size = new System.Drawing.Size(50, 20);
            this.txtP2RunDv.TabIndex = 2;
            // 
            // txtP2Run
            // 
            this.txtP2Run.Location = new System.Drawing.Point(6, 32);
            this.txtP2Run.Name = "txtP2Run";
            this.txtP2Run.Size = new System.Drawing.Size(120, 20);
            this.txtP2Run.TabIndex = 1;
            // 
            // txtP2Password
            // 
            this.txtP2Password.Location = new System.Drawing.Point(6, 76);
            this.txtP2Password.Name = "txtP2Password";
            this.txtP2Password.Size = new System.Drawing.Size(195, 20);
            this.txtP2Password.TabIndex = 3;
            this.txtP2Password.UseSystemPasswordChar = true;
            this.txtP2Password.TextChanged += new System.EventHandler(this.txtP2Password_TextChanged);
            // 
            // btnPantalla2Acceder
            // 
            this.btnPantalla2Acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantalla2Acceder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPantalla2Acceder.Location = new System.Drawing.Point(6, 150);
            this.btnPantalla2Acceder.Name = "btnPantalla2Acceder";
            this.btnPantalla2Acceder.Size = new System.Drawing.Size(407, 39);
            this.btnPantalla2Acceder.TabIndex = 4;
            this.btnPantalla2Acceder.Text = "Acceder";
            this.btnPantalla2Acceder.UseVisualStyleBackColor = true;
            this.btnPantalla2Acceder.Click += new System.EventHandler(this.btnPantalla2Acceder_Click);
            // 
            // Pantalla2Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.grboxP2Controles);
            this.Controls.Add(this.grboxP2ImagenAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pantalla2Acceso";
            this.Text = "MEGABASOFT: Ingreso Usuario";
            this.Load += new System.EventHandler(this.Pantalla2Acceso_Load);
            this.grboxP2ImagenAcceso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grboxP2Controles.ResumeLayout(false);
            this.grboxP2Label.ResumeLayout(false);
            this.grboxP2Label.PerformLayout();
            this.grboxP2Textbox.ResumeLayout(false);
            this.grboxP2Textbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxP2ImagenAcceso;
        private System.Windows.Forms.GroupBox grboxP2Controles;
        private System.Windows.Forms.GroupBox grboxP2Label;
        private System.Windows.Forms.Label lbRunYdv;
        private System.Windows.Forms.Label lblPasswords;
        private System.Windows.Forms.GroupBox grboxP2Textbox;
        private System.Windows.Forms.TextBox txtP2RunDv;
        private System.Windows.Forms.TextBox txtP2Run;
        private System.Windows.Forms.TextBox txtP2Password;
        private System.Windows.Forms.Button btnPantalla2Acceder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkP2VerPassword;
    }
}