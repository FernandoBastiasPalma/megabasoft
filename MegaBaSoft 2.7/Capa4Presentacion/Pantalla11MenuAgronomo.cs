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
    public partial class Pantalla11MenuAgronomo : Form
    {
        private Usuario usuarioSistema;

        public Pantalla11MenuAgronomo()
        {
            InitializeComponent();
        }

        public Pantalla11MenuAgronomo(Usuario usuario)
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
            Pantalla3MantenedorUsuario ventana = new Pantalla3MantenedorUsuario(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla4MantenedorTerreno ventana = new Pantalla4MantenedorTerreno(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla7MantenedorProductoVenta ventana = new Pantalla7MantenedorProductoVenta(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla6MantenedorMateriaPrima ventana = new Pantalla6MantenedorMateriaPrima(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla9MantenedorActividad ventana = new Pantalla9MantenedorActividad(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla5MantenedorProceso ventana = new Pantalla5MantenedorProceso(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantalla16MantenedorProcesoProducto ventana = new Pantalla16MantenedorProcesoProducto(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void Pantalla11MenuAgronomo_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pantalla17MantenedorAsignacionCiclo ventana = new Pantalla17MantenedorAsignacionCiclo(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pantalla19MantenedorAsignacionUsuariook ventana = new Pantalla19MantenedorAsignacionUsuariook(usuarioSistema);
            this.Hide();
            ventana.ShowDialog();
        }
    }
}
