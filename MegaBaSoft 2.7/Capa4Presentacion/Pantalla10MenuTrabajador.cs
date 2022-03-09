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
    public partial class Pantalla10MenuTrabajador : Form
    {
        

        public Pantalla10MenuTrabajador()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla10MenuTrabajador(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
        }

        private void Pantalla10MenuTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla8MantenedorTrabajoTerreno ventana = new Pantalla8MantenedorTrabajoTerreno(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla2Acceso ventana = new Pantalla2Acceso();
            this.Hide();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla18MantenedorSolicitudMateriaPrima ventana = new Pantalla18MantenedorSolicitudMateriaPrima(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }
    }
}
