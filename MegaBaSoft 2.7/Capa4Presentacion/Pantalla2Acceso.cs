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
    public partial class Pantalla2Acceso : Form
    {
        public Pantalla2Acceso()
        {
            InitializeComponent();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnPantalla2Acceder_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Rut_usuario = int.Parse(txtP2Run.Text);
            usuario.RutDv_usuario = char.Parse(txtP2RunDv.Text);
            usuario.Password_usuario = txtP2Password.Text;

            string aviso;

            NEGAcceso negUsuario = new NEGAcceso();
            usuario = negUsuario.AccesoUsuario(usuario, out aviso);

            if (aviso.Equals(""))
            {
                if (usuario.Id_permiso == 1)
                {
                    MessageBox.Show("Trabajador Ingresado!");

                    Pantalla10MenuTrabajador ventana = new Pantalla10MenuTrabajador(usuario);
                    this.Hide();
                    ventana.ShowDialog();
                    
                }
                if (usuario.Id_permiso == 2)
                {
                    MessageBox.Show("Agronomo Ingresado!");

                    Pantalla11MenuAgronomo ventana = new Pantalla11MenuAgronomo(usuario);
                    this.Hide();
                    ventana.ShowDialog();
                }
                if (usuario.Id_permiso == 3)
                {
                    MessageBox.Show("Accionista Ingresado!");

                    Pantalla12MenuAccionista ventana = new Pantalla12MenuAccionista(usuario);
                    this.Hide();
                    ventana.ShowDialog();
                }
                if (usuario.Id_permiso == 4)
                {
                    MessageBox.Show("Sistema Ingresado!");

                    Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuario);
                    this.Hide();
                    ventana.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(aviso);
            }
        }

        private void txtP2Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pantalla2Acceso_Load(object sender, EventArgs e)
        {

        }

        private void chkVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkP2VerPassword.Checked == true)
            {
                txtP2Password.UseSystemPasswordChar = false;
            }
            if (chkP2VerPassword.Checked == false)
            {
                txtP2Password.UseSystemPasswordChar = true;
            }
        }
    }
}
