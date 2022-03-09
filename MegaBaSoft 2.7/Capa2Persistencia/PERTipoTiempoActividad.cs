using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERTipoTiempoActividad
    {
        public bool insertarTipoTiempoActividad(TipoTiempoActividad tipoTiempoActividad, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                string sqlQuery = "insert into TIPOTIEMPO_ACTIVIDAD values (" + tipoTiempoActividad.ActividadProceso + "," +
                                                                               +tipoTiempoActividad.Tipotiempo + "," +
                                                                               +tipoTiempoActividad.CantidadTiempo + " )" ;
                return conexion.manipulaData(sqlQuery, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }

        }
    }
}
