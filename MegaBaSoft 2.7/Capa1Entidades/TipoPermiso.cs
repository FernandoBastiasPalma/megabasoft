using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class TipoPermiso
    {
        private int id;
        private string nombre;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public TipoPermiso() { }

        public TipoPermiso(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.descripcion = descripcion;

        }
    }
}
