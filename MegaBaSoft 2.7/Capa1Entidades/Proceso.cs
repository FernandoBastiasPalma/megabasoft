using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class Proceso
    {
        private int id;
        private string nombre;
        private int producto;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Producto { get => producto; set => producto = value; }

        public Proceso() { }

        public Proceso(int id, string nombre, int producto)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Producto = producto;
        }
    }
}
