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
    public partial class Pantalla19MantenedorAsignacionUsuariook : Form
    {
        public Pantalla19MantenedorAsignacionUsuariook()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla19MantenedorAsignacionUsuariook(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            CargarCombobox();
        }

        public void CargarCombobox()
        {
            string error = "";
            cmbPantalla19TrabajoTerreno.DropDownStyle = ComboBoxStyle.DropDownList;
            NEGTrabajoTerreno llamarTipo1 = new NEGTrabajoTerreno();
            cmbPantalla19TrabajoTerreno.DataSource = llamarTipo1.NEGlistarTrabajoTerreno(out error);
            cmbPantalla19TrabajoTerreno.ValueMember = "id_trabajoTerreno";
            cmbPantalla19TrabajoTerreno.DisplayMember = "id_trabajoTerreno";

            cmbPantalla19Usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            NEGUsuario llamarTipo2 = new NEGUsuario();
            cmbPantalla19Usuario.DataSource = llamarTipo2.NEGlistarUsuario(out error);
            cmbPantalla19Usuario.ValueMember = "Id_usuario";
            cmbPantalla19Usuario.DisplayMember = "Nombre_usuario";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pantalla19MantenedorAsignacionUsuariook_Load(object sender, EventArgs e)
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

        private void grboxPantalla3Texbox_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPantalla19TrabajoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrabajoTerreno trabajoTerreno = new TrabajoTerreno();
            trabajoTerreno.Id_trabajoTerreno = (int)cmbPantalla19TrabajoTerreno.SelectedValue;

            string error;
            NEGTrabajoTerreno listarTrabajoTerreno = new NEGTrabajoTerreno();

            dgvPantalla19Grilla.DataSource = listarTrabajoTerreno.NEGlistarTrabajoTerrenoPorID
            (trabajoTerreno.Id_trabajoTerreno, out error);
        }

        private void btnPantalla17Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajoTrabajador trabajoTrabajador = new TrabajoTrabajador();

                trabajoTrabajador.TrabajoTerreno = (int)cmbPantalla19TrabajoTerreno.SelectedValue;
                trabajoTrabajador.Usuario = (int)cmbPantalla19Usuario.SelectedValue;

                NEGTrabajoTrabajador negTrabajoTrabajador = new NEGTrabajoTrabajador();
                string msjError;
                negTrabajoTrabajador.registrarTrabajoTrabajador(trabajoTrabajador, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Usuario Asignado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
