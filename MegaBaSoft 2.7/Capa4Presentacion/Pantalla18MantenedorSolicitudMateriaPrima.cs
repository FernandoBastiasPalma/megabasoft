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
    public partial class Pantalla18MantenedorSolicitudMateriaPrima : Form
    {
        public Pantalla18MantenedorSolicitudMateriaPrima()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla18MantenedorSolicitudMateriaPrima(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            CargarCombobox();
        }

        public void CargarCombobox()
        {
            cmbPantalla18TrabajoTerreno.DropDownStyle = ComboBoxStyle.DropDownList;
            string error = "";
            NEGTrabajoTerreno llamarTipo1 = new NEGTrabajoTerreno();
            cmbPantalla18TrabajoTerreno.DataSource = llamarTipo1.NEGlistarTrabajoTerreno(out error);
            cmbPantalla18TrabajoTerreno.ValueMember = "id_actividadProceso";
            cmbPantalla18TrabajoTerreno.DisplayMember = "Id_actividadProceso";

            cmbPantalla18Materia.DropDownStyle = ComboBoxStyle.DropDownList;
            NEGMateriaPrima llamarTipo2 = new NEGMateriaPrima();
            cmbPantalla18Materia.ValueMember = "Id";
            cmbPantalla18Materia.DisplayMember = "Nombre";
            cmbPantalla18Materia.DataSource = llamarTipo2.NEGlistarMateriaPrima(out error);

            
        }

        private void Pantalla18MantenedorSolicitudMateriaPrima_Load(object sender, EventArgs e)
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
            else if (usuarioSistema.Id_permiso == 1)
            {
                Pantalla10MenuTrabajador ventana = new Pantalla10MenuTrabajador(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void btnPantalla18CargarGrilla_Click(object sender, EventArgs e)
        {
            TrabajoTerreno trabajoTerreno = new TrabajoTerreno();
            trabajoTerreno.Id_trabajoTerreno = (int)cmbPantalla18TrabajoTerreno.SelectedValue;

            string error;
            NEGTrabajoTerreno listarTrabajoTerreno = new NEGTrabajoTerreno();

            dgvPantalla18Grilla.DataSource = listarTrabajoTerreno.NEGlistarTrabajoTerrenoPorID
            (trabajoTerreno.Id_trabajoTerreno, out error);
        }

        private void btnPantalla17Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaTrabajo materiaTrabajo = new MateriaTrabajo();

                materiaTrabajo.Materia = (int)cmbPantalla18Materia.SelectedValue;
                materiaTrabajo.TrabajoTerreno = (int)cmbPantalla18TrabajoTerreno.SelectedValue;
                materiaTrabajo.Cantidad = (int)nupPantalla18Cantidad.Value;

                NEGMateriaTrabajo negNEGMateriaTrabajo = new NEGMateriaTrabajo();
                string msjError;
                negNEGMateriaTrabajo.registrarMateriaTrabajo(materiaTrabajo, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("MateriaTrabajo registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
