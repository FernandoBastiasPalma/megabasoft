using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class Actividad
    {
        private int id;
        private string codigo;
        private string nombre;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Actividad () { }

        public Actividad(int id, string codigo, string nombre,string descripcion)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;

        }
    }
}
