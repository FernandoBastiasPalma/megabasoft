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
    public partial class Pantalla15ConsultaProductividad : Form
    {
        public Pantalla15ConsultaProductividad()
        {
            InitializeComponent();

        }
        private Usuario usuarioSistema;

        public Pantalla15ConsultaProductividad(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            CargarCombobox();

        }

        public void CargarCombobox()
        {
            cmbPantalla15Terreno.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";

            NEGTerreno llamarTerreno = new NEGTerreno();
            cmbPantalla15Terreno.ValueMember = "Id";
            cmbPantalla15Terreno.DisplayMember = "Codigo";
            cmbPantalla15Terreno.DataSource = llamarTerreno.NEGlistarTipoTerreno(out error);
        }
        
        private void btnPantalla4Volver_Click(object sender, EventArgs e)
        {
            if (usuarioSistema.Id_permiso == 4)
            {
                Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
            else if (usuarioSistema.Id_permiso == 3)
            {
                Pantalla12MenuAccionista ventana = new Pantalla12MenuAccionista(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla15ConsultaProductividad_Load(object sender, EventArgs e)
        {
           
        }

        private void txtPantalla3Run_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPantalla3Buscar_Click(object sender, EventArgs e)
        {
            consultaTrabajo traba = new consultaTrabajo();

            traba.Terreno = cmbPantalla15Terreno.Text;
            this.gastoTotalTableAdapter.Fill(this.megabasoftDataSet.gastoTotal, cmbPantalla15Terreno.Text);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
