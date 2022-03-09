using Capa1Entidades;
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
    public partial class Pantalla12MenuAccionista : Form
    {
        private Usuario usuarioSistema;

        public Pantalla12MenuAccionista()
        {
            InitializeComponent();
        }
        public Pantalla12MenuAccionista(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla2Acceso ventana = new Pantalla2Acceso();
            this.Hide();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla14ConsultaTrabajos ventana = new Pantalla14ConsultaTrabajos(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla15ConsultaProductividad ventana = new Pantalla15ConsultaProductividad(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void Pantalla12MenuAccionista_Load(object sender, EventArgs e)
        {

        }
    }
}
