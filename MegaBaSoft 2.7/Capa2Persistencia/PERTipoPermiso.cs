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
    public class PERTipoPermiso
    {
        public List<TipoPermiso> PERlistarTipoPermiso(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from PERMISO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<TipoPermiso> listaTipoPermiso = new List<TipoPermiso>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        TipoPermiso TipoPermiso = new TipoPermiso();

                        TipoPermiso.Id = int.Parse(miTabla.Rows[i]["ID_PERMISO"].ToString());
                        TipoPermiso.Nombre = miTabla.Rows[i]["NOMBRE_PERMISO"].ToString();

                        listaTipoPermiso.Add(TipoPermiso);
                    }

                    return listaTipoPermiso;
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
