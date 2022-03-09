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
    public partial class Pantalla5MantenedorProceso : Form
    {
        public Pantalla5MantenedorProceso()
        {
            InitializeComponent();
        }
        
        private Usuario usuarioSistema;

        public Pantalla5MantenedorProceso(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            cargaCombobox();
        }

        private void cargaCombobox()
        {
            cbxPantalla5Proceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPantalla5Actividad.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";
            NEGProceso llamarTipo1 = new NEGProceso();
            cbxPantalla5Proceso.ValueMember = "Id";
            cbxPantalla5Proceso.DisplayMember = "Nombre";
            cbxPantalla5Proceso.DataSource = llamarTipo1.NEGlistarProceso(out error);

            NEGActividad llamarTipo2 = new NEGActividad();
            cbxPantalla5Actividad.ValueMember = "Id";
            cbxPantalla5Actividad.DisplayMember = "Nombre";
            cbxPantalla5Actividad.DataSource = llamarTipo2.NEGlistarActividad(out error);
            
        }

        private void Pantalla5MantenedorProceso_Load(object sender, EventArgs e)
        {

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

        private void cbxPantalla5ProductoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRunyDv_Click(object sender, EventArgs e)
        {

        }

        private void btnPantalla3Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ActividadProceso actividadProceso = new ActividadProceso(); 
                
                NEGActividadProceso negActividadProceso = new NEGActividadProceso();
                string msjError="";

                foreach (DataGridViewRow row in dgvPantalla5Ciclo.Rows)
                {
                    
                    if ((row.Cells["dgvIdProceso"].Value !=null) || (row.Cells["dgvIdActividad"].Value!=null))
                    {
                        actividadProceso.Id_proceso = (int)row.Cells["dgvIdProceso"].Value;
                        actividadProceso.Id_actividad = (int)row.Cells["dgvIdActividad"].Value;

                        negActividadProceso.registrarActividadProceso(actividadProceso, out msjError);
                    }
                }

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("ActividadProceso registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Proceso proceso = (Proceso)cbxPantalla5Proceso.SelectedItem;
            Actividad actividad = (Actividad)cbxPantalla5Actividad.SelectedItem;
            dgvPantalla5Ciclo.Rows.Add(proceso.Id,proceso.Nombre,actividad.Id,actividad.Nombre);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPantalla5Ciclo.Rows.Clear();
        }

        private void dgvMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
