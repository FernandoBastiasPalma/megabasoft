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
    public class PERTipoTiempo
    {
        public List<TipoTiempo> PERlistarTipoTiempo(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from TIPOTTIEMPO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<TipoTiempo> listaTipoTiempo = new List<TipoTiempo>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        TipoTiempo TipoTiempo = new TipoTiempo();

                        TipoTiempo.Id = int.Parse(miTabla.Rows[i]["ID_TIPOTIEMPO"].ToString());
                        TipoTiempo.Nombre = miTabla.Rows[i]["NOMBRE_TIPOTIEMPO"].ToString();

                        listaTipoTiempo.Add(TipoTiempo);
                    }

                    return listaTipoTiempo;
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
