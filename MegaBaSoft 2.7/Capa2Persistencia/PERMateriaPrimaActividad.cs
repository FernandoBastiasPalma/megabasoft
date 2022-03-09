using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERMateriaPrimaActividad
    {
        public bool insertarMateriaPrimaActividad(MateriaPrimaActividad materiaPrimaActividad, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                string sqlQuery = "insert into MATERIAPRIMAACTIVIDAD values (" + materiaPrimaActividad.Materia + "," +
                                                                               + materiaPrimaActividad.ActividadProceso + "," +
                                                                               + materiaPrimaActividad.Cantidad + " )";
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
