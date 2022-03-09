namespace Capa4Presentacion
{
    partial class Pantalla14ConsultaTrabajos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CONSULTARTRABAJOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.megabasoftDataSet1 = new Capa4Presentacion.megabasoftDataSet1();
            this.grboxPantalla3General = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPantalla3Buscar = new System.Windows.Forms.Button();
            this.btnPantalla4Volver = new System.Windows.Forms.Button();
            this.grboxPantalla3Texbox = new System.Windows.Forms.GroupBox();
            this.cmbPantalla14Terreno = new System.Windows.Forms.ComboBox();
            this.cmbPantalla14ActividadProceso = new System.Windows.Forms.ComboBox();
            this.cmbPantalla14Estado = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grboxPantalla3Label = new System.Windows.Forms.GroupBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRunyDv = new System.Windows.Forms.Label();
            this.CONSULTARTRABAJOTableAdapter = new Capa4Presentacion.megabasoftDataSet1TableAdapters.CONSULTARTRABAJOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CONSULTARTRABAJOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megabasoftDataSet1)).BeginInit();
            this.grboxPantalla3General.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grboxPantalla3Texbox.SuspendLayout();
            this.grboxPantalla3Label.SuspendLayout();
            this.SuspendLayout();
            // 
            // CONSULTARTRABAJOBindingSource
            // 
            this.CONSULTARTRABAJOBindingSource.DataMember = "CONSULTARTRABAJO";
            this.CONSULTARTRABAJOBindingSource.DataSource = this.megabasoftDataSet1;
            // 
            // megabasoftDataSet1
            // 
            this.megabasoftDataSet1.DataSetName = "megabasoftDataSet1";
            this.megabasoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.grboxPantalla3General.Location = new System.Drawing.Point(-2, 0);
            this.grboxPantalla3General.Name = "grboxPantalla3General";
            this.grboxPantalla3General.Size = new System.Drawing.Size(764, 454);
            this.grboxPantalla3General.TabIndex = 3;
            this.grboxPantalla3General.TabStop = false;
            this.grboxPantalla3General.Text = "Trabajo Terreno";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CONSULTARTRABAJOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa4Presentacion.consultaTrabajador.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 269);
            this.reportViewer1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPantalla3Buscar);
            this.groupBox1.Controls.Add(this.btnPantalla4Volver);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(499, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnPantalla3Buscar
            // 
            this.btnPantalla3Buscar.Location = new System.Drawing.Point(6, 32);
            this.btnPantalla3Buscar.Name = "btnPantalla3Buscar";
            this.btnPantalla3Buscar.Size = new System.Drawing.Size(231, 34);
            this.btnPantalla3Buscar.TabIndex = 4;
            this.btnPantalla3Buscar.Text = "Buscar";
            this.btnPantalla3Buscar.UseVisualStyleBackColor = true;
            this.btnPantalla3Buscar.Click += new System.EventHandler(this.btnPantalla3Buscar_Click);
            // 
            // btnPantalla4Volver
            // 
            this.btnPantalla4Volver.Location = new System.Drawing.Point(6, 80);
            this.btnPantalla4Volver.Name = "btnPantalla4Volver";
            this.btnPantalla4Volver.Size = new System.Drawing.Size(231, 34);
            this.btnPantalla4Volver.TabIndex = 8;
            this.btnPantalla4Volver.Text = "Volver";
            this.btnPantalla4Volver.UseVisualStyleBackColor = true;
            this.btnPantalla4Volver.Click += new System.EventHandler(this.btnPantalla4Volver_Click);
            // 
            // grboxPantalla3Texbox
            // 
            this.grboxPantalla3Texbox.Controls.Add(this.cmbPantalla14Terreno);
            this.grboxPantalla3Texbox.Controls.Add(this.cmbPantalla14ActividadProceso);
            this.grboxPantalla3Texbox.Controls.Add(this.cmbPantalla14Estado);
            this.grboxPantalla3Texbox.Controls.Add(this.checkBox3);
            this.grboxPantalla3Texbox.Controls.Add(this.checkBox2);
            this.grboxPantalla3Texbox.Controls.Add(this.checkBox1);
            this.grboxPantalla3Texbox.Location = new System.Drawing.Point(223, 19);
            this.grboxPantalla3Texbox.Name = "grboxPantalla3Texbox";
            this.grboxPantalla3Texbox.Size = new System.Drawing.Size(270, 111);
            this.grboxPantalla3Texbox.TabIndex = 1;
            this.grboxPantalla3Texbox.TabStop = false;
            // 
            // cmbPantalla14Terreno
            // 
            this.cmbPantalla14Terreno.FormattingEnabled = true;
            this.cmbPantalla14Terreno.Location = new System.Drawing.Point(7, 20);
            this.cmbPantalla14Terreno.Name = "cmbPantalla14Terreno";
            this.cmbPantalla14Terreno.Size = new System.Drawing.Size(121, 21);
            this.cmbPantalla14Terreno.TabIndex = 13;
            // 
            // cmbPantalla14ActividadProceso
            // 
            this.cmbPantalla14ActividadProceso.FormattingEnabled = true;
            this.cmbPantalla14ActividadProceso.Location = new System.Drawing.Point(6, 47);
            this.cmbPantalla14ActividadProceso.Name = "cmbPantalla14ActividadProceso";
            this.cmbPantalla14ActividadProceso.Size = new System.Drawing.Size(121, 21);
            this.cmbPantalla14ActividadProceso.TabIndex = 12;
            // 
            // cmbPantalla14Estado
            // 
            this.cmbPantalla14Estado.FormattingEnabled = true;
            this.cmbPantalla14Estado.Location = new System.Drawing.Point(6, 74);
            this.cmbPantalla14Estado.Name = "cmbPantalla14Estado";
            this.cmbPantalla14Estado.Size = new System.Drawing.Size(121, 21);
            this.cmbPantalla14Estado.TabIndex = 9;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(162, 75);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Filtrar";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(162, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Filtrar";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(162, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Filtrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grboxPantalla3Label
            // 
            this.grboxPantalla3Label.Controls.Add(this.lblApellidoP);
            this.grboxPantalla3Label.Controls.Add(this.lblNombre);
            this.grboxPantalla3Label.Controls.Add(this.lblRunyDv);
            this.grboxPantalla3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxPantalla3Label.Location = new System.Drawing.Point(6, 19);
            this.grboxPantalla3Label.Name = "grboxPantalla3Label";
            this.grboxPantalla3Label.Size = new System.Drawing.Size(211, 111);
            this.grboxPantalla3Label.TabIndex = 0;
            this.grboxPantalla3Label.TabStop = false;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(6, 77);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(51, 13);
            this.lblApellidoP.TabIndex = 2;
            this.lblApellidoP.Text = "ESTADO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "ACTIVIDAD DEL PROCESO";
            // 
            // lblRunyDv
            // 
            this.lblRunyDv.AutoSize = true;
            this.lblRunyDv.Location = new System.Drawing.Point(6, 24);
            this.lblRunyDv.Name = "lblRunyDv";
            this.lblRunyDv.Size = new System.Drawing.Size(60, 13);
            this.lblRunyDv.TabIndex = 0;
            this.lblRunyDv.Text = "TERRENO";
            // 
            // CONSULTARTRABAJOTableAdapter
            // 
            this.CONSULTARTRABAJOTableAdapter.ClearBeforeFill = true;
            // 
            // Pantalla14ConsultaTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.grboxPantalla3General);
            this.Name = "Pantalla14ConsultaTrabajos";
            this.Text = "MEGABASOFT: Consulta Trabajos";
            this.Load += new System.EventHandler(this.Pantalla14ConsultaTrabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CONSULTARTRABAJOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megabasoftDataSet1)).EndInit();
            this.grboxPantalla3General.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grboxPantalla3Texbox.ResumeLayout(false);
            this.grboxPantalla3Texbox.PerformLayout();
            this.grboxPantalla3Label.ResumeLayout(false);
            this.grboxPantalla3Label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxPantalla3General;
        private System.Windows.Forms.Button btnPantalla3Buscar;
        private System.Windows.Forms.GroupBox grboxPantalla3Texbox;
        private System.Windows.Forms.GroupBox grboxPantalla3Label;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRunyDv;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnPantalla4Volver;
        private System.Windows.Forms.ComboBox cmbPantalla14Estado;
        private System.Windows.Forms.ComboBox cmbPantalla14ActividadProceso;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CONSULTARTRABAJOBindingSource;
        private megabasoftDataSet1 megabasoftDataSet1;
        private megabasoftDataSet1TableAdapters.CONSULTARTRABAJOTableAdapter CONSULTARTRABAJOTableAdapter;
        private System.Windows.Forms.ComboBox cmbPantalla14Terreno;
    }
}