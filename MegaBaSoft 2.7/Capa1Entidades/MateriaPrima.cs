using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MateriaPrima
    {
        private int id;
        private string codigo;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private int stock;
        private int costo;
        private int unidadMedida;

        public MateriaPrima() {}

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Costo { get => costo; set => costo = value; }
        public int UnidadMedida { get => unidadMedida; set => unidadMedida = value; }

        public MateriaPrima(int id, string codigo, string nombre, string descripcion, int cantidad
                          , int stock, int costo, int unidadMedida)

        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Stock = stock;
            this.Costo = costo;
            this.UnidadMedida = unidadMedida;
        }
    }
}
