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
    public partial class Pantalla3MantenedorUsuario : Form
    {
        private Usuario usuarioSistema;
        
        public Pantalla3MantenedorUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            cargaCombobox();
        }

        public Pantalla3MantenedorUsuario()
        {
            InitializeComponent();
        }

        private void cargaCombobox()
        {
            cbxPantalla3TipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";
            NEGTipoPermiso llamarTipoP = new NEGTipoPermiso();
            cbxPantalla3TipoUsuario.ValueMember = "Id";
            cbxPantalla3TipoUsuario.DisplayMember = "Nombre";
            cbxPantalla3TipoUsuario.DataSource = llamarTipoP.NEGlistarTipoPermiso(out error);
        }

            private void grboxPantalla3Label_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Rut_usuario = int.Parse(txtPantalla3Run.Text);
                usuario.RutDv_usuario = char.Parse(txtPantalla3RunDv.Text);
                usuario.Nombre_usuario = txtPantalla3Nombre.Text;
                usuario.ApellidoP_usuario = txtPantalla3ApellidoP.Text;
                usuario.ApellidoM_usuario = txtPantalla3ApellidoM.Text;
                usuario.Password_usuario = txtPantalla3Password.Text;
                usuario.Id_permiso = cbxPantalla3TipoUsuario.SelectedIndex + 1;

                NEGUsuario negUsuario = new NEGUsuario();
                string msjError;
                negUsuario.modificarUsuario(usuario, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Usuario modificado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla3MantenedorUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnPantalla3Volver_Click(object sender, EventArgs e)
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

        private void chkVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkP3VerPassword.Checked == true)
            {
                txtPantalla3Password.UseSystemPasswordChar = true;
            }
            if (chkP3VerPassword.Checked == false)
            {
                txtPantalla3Password.UseSystemPasswordChar = false;
            }
        }

        private void btnPantalla3Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Rut_usuario = int.Parse(txtPantalla3Run.Text);
                usuario.RutDv_usuario = char.Parse(txtPantalla3RunDv.Text);
                usuario.Nombre_usuario = txtPantalla3Nombre.Text;
                usuario.ApellidoP_usuario = txtPantalla3ApellidoP.Text;
                usuario.ApellidoM_usuario = txtPantalla3ApellidoM.Text;
                usuario.Password_usuario = txtPantalla3Password.Text;
                usuario.Id_permiso = (int)cbxPantalla3TipoUsuario.SelectedValue;

                NEGUsuario negUsuario = new NEGUsuario();
                string msjError;
                negUsuario.registrarUsuario(usuario, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Usuario registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla3Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Rut_usuario = int.Parse(txtPantalla3Run.Text);
                usuario.RutDv_usuario = char.Parse(txtPantalla3RunDv.Text);
                usuario.Nombre_usuario = txtPantalla3Nombre.Text;
                usuario.ApellidoP_usuario = txtPantalla3ApellidoP.Text;
                usuario.ApellidoM_usuario = txtPantalla3ApellidoM.Text;
                usuario.Password_usuario = txtPantalla3Password.Text;
                usuario.Id_permiso = (int)cbxPantalla3TipoUsuario.SelectedValue;

                string msjValida = "";
                if (txtPantalla3Run.Text != "" && txtPantalla3RunDv.Text != "")
                {

                    usuario.Rut_usuario = int.Parse(txtPantalla3Run.Text);
                    usuario.RutDv_usuario = char.Parse(txtPantalla3RunDv.Text);

                    List<Usuario> listaUsuario = new List<Usuario>();

                    NEGUsuario negUsuario = new NEGUsuario();
                    listaUsuario = negUsuario.NEGlistarUsuarioPorRun("Run", usuario, out msjValida);

                    if (msjValida.Equals(""))
                    {
                        txtPantalla3Run.Text = (listaUsuario[0].Rut_usuario).ToString();
                        txtPantalla3RunDv.Text = (listaUsuario[0].RutDv_usuario).ToString();
                        txtPantalla3Nombre.Text = (listaUsuario[0].Nombre_usuario).ToString();
                        txtPantalla3ApellidoP.Text = (listaUsuario[0].ApellidoP_usuario).ToString();
                        txtPantalla3ApellidoM.Text = (listaUsuario[0].ApellidoM_usuario).ToString();
                        txtPantalla3Password.Text = (listaUsuario[0].Password_usuario).ToString();
                        cbxPantalla3TipoUsuario.Text = (listaUsuario[0].Id_permiso).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error durante la Busqueda: " + msjValida, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Busqueda Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPantalla3Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Rut_usuario = int.Parse(txtPantalla3Run.Text);
                usuario.RutDv_usuario = char.Parse(txtPantalla3RunDv.Text);

                NEGUsuario negUsuario = new NEGUsuario();
                string msjError;
                negUsuario.eliminarUsuario(usuario, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Usuario eliminado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtPantalla3Run_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxPantalla3TipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
