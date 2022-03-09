using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TipoTiempo
    {
        private int id;
        private string nombre;
        private string tipo;

        public TipoTiempo() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public TipoTiempo(int id, string nombre, string tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Tipo = tipo;
        }
    }
}
