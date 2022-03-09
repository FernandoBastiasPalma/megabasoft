using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERMateriaTrabajo
    {
        public bool insertarMateriaTrabajo(MateriaTrabajo materiaTrabajo, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                string sqlQuery = "insert into MATERIA_TRABAJO values (" + materiaTrabajo.Materia + "," +
                                                                         +materiaTrabajo.TrabajoTerreno + "," +
                                                                         +materiaTrabajo.Cantidad + " )";
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
