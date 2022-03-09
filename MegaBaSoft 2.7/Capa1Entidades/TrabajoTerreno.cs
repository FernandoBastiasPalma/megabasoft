using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class TrabajoTerreno
    {

        private int id_trabajoTerreno; //tabla Trabajo Terreno
        private int id_terreno;
        private int id_actividadProceso;
        private int id_estado;
        private DateTime fecha_inicio;
        private DateTime fecha_termino;

        private int id_trabajoTrabajador; //tabla Trabajo Trabajador
        private int id_usuario;
        //private int id_trabajoTerreno;

        private int id_materiaTrabajo; //tabla Materia Prima
        private int id_materia;
        //private int id_trabajoTerreno;
        private int cantidad;

        public TrabajoTerreno() { }

        public int Id_trabajoTerreno { get => id_trabajoTerreno; set => id_trabajoTerreno = value; }
        public int Id_terreno { get => id_terreno; set => id_terreno = value; }
        public int Id_actividadProceso { get => id_actividadProceso; set => id_actividadProceso = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_termino { get => fecha_termino; set => fecha_termino = value; }
        public int Id_trabajoTrabajador { get => id_trabajoTrabajador; set => id_trabajoTrabajador = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_materiaTrabajo { get => id_materiaTrabajo; set => id_materiaTrabajo = value; }
        public int Id_materia { get => id_materia; set => id_materia = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public TrabajoTerreno(int id_trabajoTerreno,
                                int id_terreno,
                                int id_actividadProceso,
                                int id_estado,
                                DateTime fecha_inicio,
                                DateTime fecha_termino,
                                int id_trabajoTrabajador,
                                int id_usuario,
                                int id_materiaTrabajo,
                                int id_materia,
                                int cantidad)
        {
            this.Id_trabajoTerreno = id_trabajoTerreno;
            this.Id_terreno = id_terreno;
            this.Id_actividadProceso = id_actividadProceso;
            this.Id_estado = id_estado;
            this.Fecha_inicio = fecha_inicio;
            this.Fecha_termino = fecha_termino;
            this.Id_trabajoTrabajador = id_trabajoTrabajador;
            this.Id_usuario = id_usuario;
            this.Id_materiaTrabajo = id_materiaTrabajo;
            this.Id_materia = id_materia;
            this.Cantidad = cantidad;
        }
    }
}
