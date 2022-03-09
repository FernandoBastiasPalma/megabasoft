using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class TipoTiempoActividad
    {
        private int id;
        private int actividadProceso;
        private int cantidadTiempo;
        private int tipotiempo;

        public TipoTiempoActividad() { }

        public int Id { get => id; set => id = value; }
        public int ActividadProceso { get => actividadProceso; set => actividadProceso = value; }
        public int CantidadTiempo { get => cantidadTiempo; set => cantidadTiempo = value; }
        public int Tipotiempo { get => tipotiempo; set => tipotiempo = value; }

        public TipoTiempoActividad(int id, int materia, int actividadProceso, int cantidadTiempo, int tipoTiempo)
        {
            this.Id = id;
            this.ActividadProceso = actividadProceso;
            this.CantidadTiempo = cantidadTiempo;
            this.Tipotiempo = tipoTiempo;
        }
    }
}
