using Capa1Entidades;
using Capa3Negocio;
using Clases;
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
    public partial class Pantalla8MantenedorTrabajoTerreno : Form
    {

        private Usuario usuarioSistema;

        public Pantalla8MantenedorTrabajoTerreno(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            cargaCombobox();
        }

        public Pantalla8MantenedorTrabajoTerreno()
        {
            InitializeComponent();
            cargaCombobox();
        }

        private void cargaCombobox()
        {
            cmbPantalla8ProcesoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPanatlla8Terreno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPantalla8estado.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";
            NEGActividadProceso llamarTipo1 = new NEGActividadProceso();
            cmbPantalla8ProcesoActividad.DataSource = llamarTipo1.NEGlistarActividadProceso(out error);
            cmbPantalla8ProcesoActividad.ValueMember = "id_actividadProceso";
            cmbPantalla8ProcesoActividad.DisplayMember = "Id_actividadProceso";

            NEGTerreno llamarTipoterreno = new NEGTerreno();
            cmbPanatlla8Terreno.ValueMember = "Id";
            cmbPanatlla8Terreno.DisplayMember = "Nombre";
            cmbPanatlla8Terreno.DataSource = llamarTipoterreno.NEGlistarTipoTerreno(out error);


            NEGEstadoTrabajo llamarEstado = new NEGEstadoTrabajo();
            cmbPantalla8estado.ValueMember = "Id";
            cmbPantalla8estado.DisplayMember = "Nombre";
            cmbPantalla8estado.DataSource = llamarEstado.NEGlistarEstadoTrabajo(out error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioSistema.Id_permiso == 4)
            {
                Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
            else if (usuarioSistema.Id_permiso == 1)
            {
                Pantalla10MenuTrabajador ventana = new Pantalla10MenuTrabajador(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void Pantalla8MantenedorTrabajoTerreno_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbPanatlla8Terreno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPantalla3Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajoTerreno trabajoTerreno = new TrabajoTerreno();

                trabajoTerreno.Id_actividadProceso = (int)cmbPantalla8ProcesoActividad.SelectedValue;
                trabajoTerreno.Id_terreno = (int)cmbPanatlla8Terreno.SelectedValue;
                trabajoTerreno.Id_estado = (int)cmbPantalla8estado.SelectedValue;
                trabajoTerreno.Fecha_inicio = DateTime.Parse(dtpPantalla8FechaInicio.Value.ToString());
                trabajoTerreno.Fecha_termino = DateTime.Parse(dtpPantalla8FechaTermino.Value.ToString());
                
                NEGTrabajoTerreno negTrabajoTerreno = new NEGTrabajoTerreno();
                string msjError;
                negTrabajoTerreno.registrarTrabajoTerreno(trabajoTerreno, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("TrabajoTerreno registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPantalla8Proceso.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void grboxPantalla3Texbox_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActividadProceso actividadProceso = new ActividadProceso();
            actividadProceso.Id_actividadProceso = (int)cmbPantalla8ProcesoActividad.SelectedValue;

            string error;
            NEGActividadProceso listarProceso = new NEGActividadProceso();

            dgvPantalla8Proceso.DataSource = listarProceso.NEGlistarActividadProcesoPorId
            (actividadProceso.Id_actividadProceso.ToString(),out error);
            
        }
    }
}
