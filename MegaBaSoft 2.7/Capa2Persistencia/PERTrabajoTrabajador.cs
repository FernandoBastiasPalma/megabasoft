using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERTrabajoTrabajador
    {
        public bool insertarTrabajoTrabajador(TrabajoTrabajador trabajoTrabajador, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                string sqlQuery = "insert into TRABAJO_TRABAJADOR values (" + trabajoTrabajador.Usuario + "," +
                                                                               +trabajoTrabajador.TrabajoTerreno + " )";
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
