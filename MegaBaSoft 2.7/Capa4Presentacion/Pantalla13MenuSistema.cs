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
    public partial class Pantalla13MenuSistema : Form
    {
        private Usuario usuarioSistema;

        public Pantalla13MenuSistema()
        {
            InitializeComponent();
        }

        public Pantalla13MenuSistema(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            Pantalla14ConsultaTrabajos ventana = new Pantalla14ConsultaTrabajos(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla1Inicio Pantalla = new Pantalla1Inicio();
            this.Hide();
            Pantalla.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla2Acceso Pantalla = new Pantalla2Acceso();
            this.Hide();
            Pantalla.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla2Acceso ventana = new Pantalla2Acceso();
            this.Hide();
            ventana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla3MantenedorUsuario ventana = new Pantalla3MantenedorUsuario(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla4MantenedorTerreno ventana = new Pantalla4MantenedorTerreno(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pantalla5MantenedorProceso ventana = new Pantalla5MantenedorProceso(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantalla6MantenedorMateriaPrima ventana = new Pantalla6MantenedorMateriaPrima(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla7MantenedorProductoVenta ventana = new Pantalla7MantenedorProductoVenta(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Pantalla9MantenedorActividad ventana = new Pantalla9MantenedorActividad(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla8MantenedorTrabajoTerreno ventana = new Pantalla8MantenedorTrabajoTerreno(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Pantalla10MenuTrabajador ventana = new Pantalla10MenuTrabajador(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Pantalla11MenuAgronomo ventana = new Pantalla11MenuAgronomo(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Pantalla12MenuAccionista ventana = new Pantalla12MenuAccionista(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void Pantalla13MenuSistema_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Pantalla15ConsultaProductividad ventana = new Pantalla15ConsultaProductividad(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Pantalla16MantenedorProcesoProducto ventana = new Pantalla16MantenedorProcesoProducto(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }
    }
}
