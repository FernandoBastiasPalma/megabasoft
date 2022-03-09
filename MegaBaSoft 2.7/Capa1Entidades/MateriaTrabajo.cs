using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class MateriaTrabajo
    {
        private int id;
        private int materia;
        private int trabajoTerreno;
        private int cantidad;

        public MateriaTrabajo() { }

        public int Id { get => id; set => id = value; }
        public int Materia { get => materia; set => materia = value; }
        public int TrabajoTerreno { get => trabajoTerreno; set => trabajoTerreno = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public MateriaTrabajo(int id, int materia, int trabajoTerreno,int cantidad)
        {
            this.Id = id;
            this.Materia = materia;
            this.TrabajoTerreno = trabajoTerreno;
            this.Cantidad = cantidad;
        }
    }
}
