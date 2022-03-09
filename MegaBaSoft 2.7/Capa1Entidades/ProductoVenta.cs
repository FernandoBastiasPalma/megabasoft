using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class ProductoVenta
    {
        private int id;
        private string codigo;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public ProductoVenta() { }

        public ProductoVenta(int id, string codigo, string nombre)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;

        }
    }
}
