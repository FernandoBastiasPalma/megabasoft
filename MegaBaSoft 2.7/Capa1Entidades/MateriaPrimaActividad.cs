using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class MateriaPrimaActividad
    {
        private int id;
        private int materia;
        private int actividadProceso;
        private int cantidad;

        public MateriaPrimaActividad() { }

        public int Id { get => id; set => id = value; }
        public int Materia { get => materia; set => materia = value; }
        public int ActividadProceso { get => actividadProceso; set => actividadProceso = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public MateriaPrimaActividad(int id, int materia
                          , int actividadProceso, int cantidad)

        {
            this.Id = id;
            this.Materia = materia;
            this.ActividadProceso = actividadProceso;
            this.Cantidad = cantidad;
        }
    }
}
