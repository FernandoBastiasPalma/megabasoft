using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class UnidadMedida
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public UnidadMedida() { }

        public UnidadMedida(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        
    }
}
