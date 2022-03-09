namespace Capa4Presentacion
{
    partial class Pantalla15ConsultaProductividad
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
            this.components = new System.ComponentModel.Container();
            this.gastoTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.megabasoftDataSet = new Capa4Presentacion.megabasoftDataSet();
            this.grboxPantalla3General = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPantalla3Buscar = new System.Windows.Forms.Button();
            this.btnPantalla4Volver = new System.Windows.Forms.Button();
            this.grboxPantalla3Texbox = new System.Windows.Forms.GroupBox();
            this.cmbPantalla15Terreno = new System.Windows.Forms.ComboBox();
            this.grboxPantalla3Label = new System.Windows.Forms.GroupBox();
            this.lblRunyDv = new System.Windows.Forms.Label();
            this.gastoTotalTableAdapter = new Capa4Presentacion.megabasoftDataSetTableAdapters.gastoTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gastoTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megabasoftDataSet)).BeginInit();
            this.grboxPantalla3General.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grboxPantalla3Texbox.SuspendLayout();
            this.grboxPantalla3Label.SuspendLayout();
            this.SuspendLayout();
            // 
            // gastoTotalBindingSource
            // 
            this.gastoTotalBindingSource.DataMember = "gastoTotal";
            this.gastoTotalBindingSource.DataSource = this.megabasoftDataSet;
            // 
            // megabasoftDataSet
            // 
            this.megabasoftDataSet.DataSetName = "megabasoftDataSet";
            this.megabasoftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grboxPantalla3General
            // 
            this.grboxPantalla3General.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grboxPantalla3General.Controls.Add(this.reportViewer1);
            this.grboxPantalla3General.Controls.Add(this.groupBox1);
            this.grboxPantalla3General.Controls.Add(this.grboxPantalla3Texbox);
            this.grboxPantalla3General.Controls.Add(this.grboxPantalla3Label);
            this.grboxPantalla3General.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxPantalla3General.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grboxPantalla3General.Location = new System.Drawing.Point(0, -2);
            this.grboxPantalla3General.Name = "grboxPantalla3General";
            this.grboxPantalla3General.Size = new System.Drawing.Size(754, 455);
            this.grboxPantalla3General.TabIndex = 4;
            this.grboxPantalla3General.TabStop = false;
            this.grboxPantalla3General.Text = "Trabajo Terreno";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa4Presentacion.informeProductividad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 316);
            this.reportViewer1.TabIndex = 10;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPantalla3Buscar);
            this.groupBox1.Controls.Add(this.btnPantalla4Volver);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(499, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnPantalla3Buscar
            // 
            this.btnPantalla3Buscar.Location = new System.Drawing.Point(10, 23);
            this.btnPantalla3Buscar.Name = "btnPantalla3Buscar";
            this.btnPantalla3Buscar.Size = new System.Drawing.Size(227, 37);
            this.btnPantalla3Buscar.TabIndex = 4;
            this.btnPantalla3Buscar.Text = "Buscar";
            this.btnPantalla3Buscar.UseVisualStyleBackColor = true;
            this.btnPantalla3Buscar.Click += new System.EventHandler(this.btnPantalla3Buscar_Click);
            // 
            // btnPantalla4Volver
            // 
            this.btnPantalla4Volver.Location = new System.Drawing.Point(10, 75);
            this.btnPantalla4Volver.Name = "btnPantalla4Volver";
            this.btnPantalla4Volver.Size = new System.Drawing.Size(227, 37);
            this.btnPantalla4Volver.TabIndex = 8;
            this.btnPantalla4Volver.Text = "Volver";
            this.btnPantalla4Volver.UseVisualStyleBackColor = true;
            this.btnPantalla4Volver.Click += new System.EventHandler(this.btnPantalla4Volver_Click);
            // 
            // grboxPantalla3Texbox
            // 
            this.grboxPantalla3Texbox.Controls.Add(this.cmbPantalla15Terreno);
            this.grboxPantalla3Texbox.Location = new System.Drawing.Point(223, 19);
            this.grboxPantalla3Texbox.Name = "grboxPantalla3Texbox";
            this.grboxPantalla3Texbox.Size = new System.Drawing.Size(270, 99);
            this.grboxPantalla3Texbox.TabIndex = 1;
            this.grboxPantalla3Texbox.TabStop = false;
            // 
            // cmbPantalla15Terreno
            // 
            this.cmbPantalla15Terreno.FormattingEnabled = true;
            this.cmbPantalla15Terreno.Location = new System.Drawing.Point(37, 16);
            this.cmbPantalla15Terreno.Name = "cmbPantalla15Terreno";
            this.cmbPantalla15Terreno.Size = new System.Drawing.Size(141, 21);
            this.cmbPantalla15Terreno.TabIndex = 0;
            // 
            // grboxPantalla3Label
            // 
            this.grboxPantalla3Label.Controls.Add(this.lblRunyDv);
            this.grboxPantalla3Label.Location = new System.Drawing.Point(6, 19);
            this.grboxPantalla3Label.Name = "grboxPantalla3Label";
            this.grboxPantalla3Label.Size = new System.Drawing.Size(211, 99);
            this.grboxPantalla3Label.TabIndex = 0;
            this.grboxPantalla3Label.TabStop = false;
            // 
            // lblRunyDv
            // 
            this.lblRunyDv.AutoSize = true;
            this.lblRunyDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunyDv.Location = new System.Drawing.Point(6, 24);
            this.lblRunyDv.Name = "lblRunyDv";
            this.lblRunyDv.Size = new System.Drawing.Size(60, 13);
            this.lblRunyDv.TabIndex = 0;
            this.lblRunyDv.Text = "TERRENO";
            // 
            // gastoTotalTableAdapter
            // 
            this.gastoTotalTableAdapter.ClearBeforeFill = true;
            // 
            // Pantalla15ConsultaProductividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.grboxPantalla3General);
            this.Name = "Pantalla15ConsultaProductividad";
            this.Text = "MEGABASOFT: Consulta Productividad";
            this.Load += new System.EventHandler(this.Pantalla15ConsultaProductividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gastoTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megabasoftDataSet)).EndInit();
            this.grboxPantalla3General.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grboxPantalla3Texbox.ResumeLayout(false);
            this.grboxPantalla3Label.ResumeLayout(false);
            this.grboxPantalla3Label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxPantalla3General;
        private System.Windows.Forms.Button btnPantalla4Volver;
        private System.Windows.Forms.Button btnPantalla3Buscar;
        private System.Windows.Forms.GroupBox grboxPantalla3Texbox;
        private System.Windows.Forms.GroupBox grboxPantalla3Label;
        private System.Windows.Forms.Label lblRunyDv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPantalla15Terreno;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gastoTotalBindingSource;
        private megabasoftDataSet megabasoftDataSet;
        private megabasoftDataSetTableAdapters.gastoTotalTableAdapter gastoTotalTableAdapter;
    }
}