namespace Capa4Presentacion
{
    partial class Pantalla1Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla1Inicio));
            this.btnP1Inicio = new System.Windows.Forms.Button();
            this.btnP1Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnP1Inicio
            // 
            this.btnP1Inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnP1Inicio.BackgroundImage")));
            this.btnP1Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnP1Inicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnP1Inicio.FlatAppearance.BorderSize = 0;
            this.btnP1Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP1Inicio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnP1Inicio.Location = new System.Drawing.Point(50, 264);
            this.btnP1Inicio.Name = "btnP1Inicio";
            this.btnP1Inicio.Size = new System.Drawing.Size(240, 99);
            this.btnP1Inicio.TabIndex = 0;
            this.btnP1Inicio.UseVisualStyleBackColor = true;
            this.btnP1Inicio.Click += new System.EventHandler(this.btnP1Inicio_Click);
            // 
            // btnP1Test
            // 
            this.btnP1Test.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnP1Test.BackgroundImage")));
            this.btnP1Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnP1Test.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnP1Test.FlatAppearance.BorderSize = 0;
            this.btnP1Test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP1Test.Location = new System.Drawing.Point(664, 381);
            this.btnP1Test.Name = "btnP1Test";
            this.btnP1Test.Size = new System.Drawing.Size(125, 57);
            this.btnP1Test.TabIndex = 1;
            this.btnP1Test.Text = "Test de Conexion";
            this.btnP1Test.UseVisualStyleBackColor = true;
            this.btnP1Test.Click += new System.EventHandler(this.btnP1Test_Click);
            // 
            // Pantalla1Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnP1Test);
            this.Controls.Add(this.btnP1Inicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pantalla1Inicio";
            this.Text = "Pantalla1Inicio";
            this.Load += new System.EventHandler(this.Pantalla1Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnP1Inicio;
        private System.Windows.Forms.Button btnP1Test;
    }
}