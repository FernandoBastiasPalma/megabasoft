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
    public partial class Pantalla1Inicio : Form
    {
        public Pantalla1Inicio()
        {
            InitializeComponent();
        }

        private void Pantalla1Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnP1Inicio_Click(object sender, EventArgs e)
        {
            Pantalla2Acceso AgregarPantalla2Acceso = new Pantalla2Acceso();
            this.Hide();
            AgregarPantalla2Acceso.ShowDialog();
            
        }

        private void btnP1Test_Click(object sender, EventArgs e)
        {
            NEGpruebaConexion negTest = new NEGpruebaConexion();
            bool recibeRespuesta = negTest.comprobarConectividadBD();
            if (recibeRespuesta == true)
            {
                btnP1Test.Text = "Conectado a la base de datos";
                btnP1Test.ForeColor = Color.Green;
            }
            else
            {
                btnP1Test.Text = "No se logró la conexíón a la base de datos";
                btnP1Test.ForeColor = Color.Red;
            }
        }
    }
}
