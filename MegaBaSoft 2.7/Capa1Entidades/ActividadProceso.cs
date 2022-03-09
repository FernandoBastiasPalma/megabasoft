using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class ActividadProceso
    {
        private int id_actividadProceso; 
        private int id_actividad;
        private int id_proceso;

        public ActividadProceso() { }

        public int Id_actividadProceso { get => id_actividadProceso; set => id_actividadProceso = value; }
        public int Id_actividad { get => id_actividad; set => id_actividad = value; }
        public int Id_proceso { get => id_proceso; set => id_proceso = value; }


        public ActividadProceso(int id_actividadProceso,
                                int id_actividad,
                                int id_proceso)
        {
            this.Id_actividadProceso = id_actividadProceso;
            this.Id_actividad = id_actividad;
            this.Id_proceso = id_proceso;
        }
    }
}
