using Capa1Entidades;
using Capa3Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa4Presentacion
{
    public partial class Pantalla14ConsultaTrabajos : Form
    {
        public Pantalla14ConsultaTrabajos()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla14ConsultaTrabajos(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            cargaCombobox();
        }

        private void cargaCombobox()
        {
            cmbPantalla14ActividadProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            string error = "";
            NEGActividad llamarEstado1 = new NEGActividad();
            cmbPantalla14ActividadProceso.ValueMember = "Id";
            cmbPantalla14ActividadProceso.DisplayMember = "Nombre";
            cmbPantalla14ActividadProceso.DataSource = llamarEstado1.NEGlistarActividad(out error);

            cmbPantalla14Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            NEGEstadoTrabajo llamarEstado = new NEGEstadoTrabajo();
            cmbPantalla14Estado.ValueMember = "Id";
            cmbPantalla14Estado.DisplayMember = "Nombre";
            cmbPantalla14Estado.DataSource = llamarEstado.NEGlistarEstadoTrabajo(out error);

            cmbPantalla14Terreno.DropDownStyle = ComboBoxStyle.DropDownList;
            NEGTerreno llamarEstado3 = new NEGTerreno();
            cmbPantalla14Terreno.ValueMember = "Id";
            cmbPantalla14Terreno.DisplayMember = "Nombre";
            cmbPantalla14Terreno.DataSource = llamarEstado3.NEGlistarTipoTerreno(out error);


        }

        private void btnPantalla4Volver_Click(object sender, EventArgs e)
        {
            if (usuarioSistema.Id_permiso == 4)
            {
                Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
            else if (usuarioSistema.Id_permiso == 3)
            {
                Pantalla12MenuAccionista ventana = new Pantalla12MenuAccionista(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pantalla14ConsultaTrabajos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'megabasoftDataSet1.CONSULTARTRABAJO' Puede moverla o quitarla según sea necesario.
            //this.CONSULTARTRABAJOTableAdapter.Fill(this.megabasoftDataSet1.CONSULTARTRABAJO, cmbPantalla14Terreno.Text);

            this.reportViewer1.RefreshReport();
        }

        private void btnPantalla3Buscar_Click(object sender, EventArgs e)
        {
            consultaTrabajo traba = new consultaTrabajo();


            if (checkBox1.Checked == true)
            {
                traba.Terreno = cmbPantalla14Terreno.Text;
                this.CONSULTARTRABAJOTableAdapter.Fill(this.megabasoftDataSet1.CONSULTARTRABAJO, cmbPantalla14Terreno.Text, "", "");
                this.reportViewer1.RefreshReport();
            }

            if (checkBox2.Checked == true)
            {
                traba.Actividad = cmbPantalla14ActividadProceso.Text;
                this.CONSULTARTRABAJOTableAdapter.Fill(this.megabasoftDataSet1.CONSULTARTRABAJO, "", cmbPantalla14ActividadProceso.Text, "");
                this.reportViewer1.RefreshReport();
            }

            if (checkBox3.Checked == true)
            {
                traba.Estado = cmbPantalla14Estado.Text;
                this.CONSULTARTRABAJOTableAdapter.Fill(this.megabasoftDataSet1.CONSULTARTRABAJO, "", "", cmbPantalla14Estado.Text);
                this.reportViewer1.RefreshReport();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
