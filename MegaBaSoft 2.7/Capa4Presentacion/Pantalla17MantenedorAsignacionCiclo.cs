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
    public partial class Pantalla17MantenedorAsignacionCiclo : Form
    {
        public Pantalla17MantenedorAsignacionCiclo()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla17MantenedorAsignacionCiclo(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            CargaCobobox();
        }

        private void CargaCobobox()
        {
            cmbPantalla17ActividadProceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPantalla17Proceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPantalla17Actividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPantalla17Materia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPantalla17TipoTiempo.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";
            NEGActividadProceso llamarTipo1 = new NEGActividadProceso();
            cmbPantalla17ActividadProceso.DataSource = llamarTipo1.NEGlistarActividadProceso(out error);
            cmbPantalla17ActividadProceso.ValueMember = "id_actividadProceso";
            cmbPantalla17ActividadProceso.DisplayMember = "Id_actividadProceso";

            ActividadProceso actividadProceso = (ActividadProceso)cmbPantalla17ActividadProceso.SelectedItem;

            int AUXproceso = actividadProceso.Id_proceso;
            int AUXactividad = actividadProceso.Id_actividad;
            NEGProceso llamarTipo5 = new NEGProceso();
            cmbPantalla17Proceso.DataSource = llamarTipo5.NEGlistarProcesoPorId(AUXproceso, out error);
            cmbPantalla17Proceso.ValueMember = "Id";
            cmbPantalla17Proceso.DisplayMember = "Nombre";
            
            Actividad actividad = new Actividad();
            actividad.Id = AUXactividad;
            NEGActividad llamarTipo2 = new NEGActividad();
            cmbPantalla17Actividad.DataSource = llamarTipo2.NEGlistaractividadPorConsulta("Id", actividad, out error);
            cmbPantalla17Actividad.ValueMember = "Id";
            cmbPantalla17Actividad.DisplayMember = "Nombre";
            

            NEGMateriaPrima llamarTipo3 = new NEGMateriaPrima();
            cmbPantalla17Materia.ValueMember = "Id";
            cmbPantalla17Materia.DisplayMember = "Nombre";
            cmbPantalla17Materia.DataSource = llamarTipo3.NEGlistarMateriaPrima(out error);

            NEGTipoTiempo llamarTipo4 = new NEGTipoTiempo();
            cmbPantalla17TipoTiempo.ValueMember = "Id";
            cmbPantalla17TipoTiempo.DisplayMember = "Nombre";
            cmbPantalla17TipoTiempo.DataSource = llamarTipo4.NEGlistarTipoTiempo(out error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioSistema.Id_permiso == 4)
            {
                Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
            else if (usuarioSistema.Id_permiso == 2)
            {
                Pantalla11MenuAgronomo ventana = new Pantalla11MenuAgronomo(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void Pantalla17MantenedorAsignacionCiclo_Load(object sender, EventArgs e)
        {

        }

        private void btnPantalla6Modificar_Click(object sender, EventArgs e)
        {
            Proceso proceso = (Proceso)cmbPantalla17Proceso.SelectedItem;
            Actividad actividad = (Actividad)cmbPantalla17Actividad.SelectedItem;
            MateriaPrima materia = (MateriaPrima)cmbPantalla17Materia.SelectedItem;
            TipoTiempo tipotiempo = (TipoTiempo)cmbPantalla17TipoTiempo.SelectedItem;
            
            dgvPantalla17VistaGeneral.Rows.Add(proceso.Id, proceso.Nombre, 
                                              actividad.Id, actividad.Nombre,
                                              materia.Id,materia.Nombre ,
                                              (int)nupPantalla17Cantidad.Value,
                                              tipotiempo.Id,
                                              tipotiempo.Nombre,
                                              (int)nupPantalla17CantidadTiempo.Value);
        }

        private void btnPantalla17Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrimaActividad materiaPrimaActividad = new MateriaPrimaActividad();
                NEGMateriaPrimaActividad negMateriaPrimaActividad = new NEGMateriaPrimaActividad();

                TipoTiempoActividad tipoTiempoActividad = new TipoTiempoActividad();
                NEGTipoTiempoActividad negTipoTiempoActividad = new NEGTipoTiempoActividad();

                string msjError = "";

                foreach (DataGridViewRow row in dgvPantalla17VistaGeneral.Rows)
                {
                    if ((row.Cells["dgvIDproceso"].Value != null) || (row.Cells["dgvIDactividad"].Value != null))
                    {
                        materiaPrimaActividad.Materia = (int)row.Cells["dgvIDmateria"].Value;
                        materiaPrimaActividad.ActividadProceso = (int)row.Cells["dgvIDproceso"].Value;
                        materiaPrimaActividad.Cantidad = (int)row.Cells["dgvCantidad"].Value;

                        tipoTiempoActividad.ActividadProceso = (int)row.Cells["dgvIDproceso"].Value;
                        tipoTiempoActividad.CantidadTiempo = (int)row.Cells["dgvCantidadTiempo"].Value;
                        tipoTiempoActividad.Tipotiempo = (int)row.Cells["dgvIDtiempo"].Value;

                        negMateriaPrimaActividad.registrarMateriaPrimaActividad(materiaPrimaActividad, out msjError);
                        negTipoTiempoActividad.registrarTipoTiempoActividad(tipoTiempoActividad, out msjError);
                    }
                }

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Agignacion registrada correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPantalla17VistaGeneral.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void cmbPantalla17ActividadProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActividadProceso actividadProceso = (ActividadProceso)cmbPantalla17ActividadProceso.SelectedItem;
            string error = "";
            int AUXproceso = actividadProceso.Id_proceso;
            int AUXactividad = actividadProceso.Id_actividad;
            NEGProceso llamarTipo5 = new NEGProceso();
            cmbPantalla17Proceso.DataSource = llamarTipo5.NEGlistarProcesoPorId(AUXproceso, out error);
            cmbPantalla17Proceso.ValueMember = "Id";
            cmbPantalla17Proceso.DisplayMember = "Nombre";

            Actividad actividad = new Actividad();
            actividad.Id = AUXactividad;
            NEGActividad llamarTipo2 = new NEGActividad();
            cmbPantalla17Actividad.DataSource = llamarTipo2.NEGlistaractividadPorConsulta("Id", actividad, out error);
            cmbPantalla17Actividad.ValueMember = "Id";
            cmbPantalla17Actividad.DisplayMember = "Nombre";
        }

        private void cmbPantalla17Proceso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
