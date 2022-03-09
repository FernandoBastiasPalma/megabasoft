using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERUnidadmedida
    {
        public List<UnidadMedida> PERlistarUnidadMedida(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from UNIDADMEDIDA";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<UnidadMedida> listaUnidadMedida = new List<UnidadMedida>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        UnidadMedida TipoUnidadMedida = new UnidadMedida();

                        TipoUnidadMedida.Id = int.Parse(miTabla.Rows[i]["ID_UNIDADMEDIDA"].ToString());
                        TipoUnidadMedida.Nombre = miTabla.Rows[i]["NOMBRE_UNIDADMEDIDA"].ToString();

                        listaUnidadMedida.Add(TipoUnidadMedida);
                    }

                    return listaUnidadMedida;
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
