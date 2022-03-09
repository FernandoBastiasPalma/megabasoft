using Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PEREstadoTrabajo
    {
        public List<EstadoTrabajo> PERlistarestado(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from ESTADOTRABAJO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<EstadoTrabajo> listaEstadoTrabajo = new List<EstadoTrabajo>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        EstadoTrabajo TipoEstadoTrabajo = new EstadoTrabajo();

                        TipoEstadoTrabajo.Id = int.Parse(miTabla.Rows[i]["ID_ESTADO"].ToString());
                        TipoEstadoTrabajo.Nombre = miTabla.Rows[i]["NOMBRE_ESTADO"].ToString();

                        listaEstadoTrabajo.Add(TipoEstadoTrabajo);
                    }

                    return listaEstadoTrabajo;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

    }
}
