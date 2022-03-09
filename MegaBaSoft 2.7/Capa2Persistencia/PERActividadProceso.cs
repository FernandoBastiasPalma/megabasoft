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
    public class PERActividadProceso
    {
        public bool InsertarActividadProceso(ActividadProceso actividadProceso, out string error) // metodo para insertar actividadProceso
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[2];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@id_actividad";
                parametro1.Value = actividadProceso.Id_actividad;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@id_proceso";
                parametro2.Value = actividadProceso.Id_proceso;

                listaParametros[1] = parametro2;
                
                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "InsertarActividadProceso", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public List<ActividadProceso> PERlistarActividadProceso(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from ACTIVIDAD_PROCESO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<ActividadProceso> listaActividadProceso = new List<ActividadProceso>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        ActividadProceso ActividadProceso = new ActividadProceso();

                        ActividadProceso.Id_actividadProceso = int.Parse(miTabla.Rows[i]["ID_ACTIVIDADPROCESO"].ToString());
                        ActividadProceso.Id_proceso = int.Parse(miTabla.Rows[i]["ID_PROCESO"].ToString());
                        ActividadProceso.Id_actividad = int.Parse(miTabla.Rows[i]["ID_ACTIVIDAD"].ToString());
                        
                        listaActividadProceso.Add(ActividadProceso);
                    }

                    return listaActividadProceso;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<ActividadProceso> PERlistarActividadProcesoPorId(string id,out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from ACTIVIDAD_PROCESO where ID_PROCESO = "+ id;
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<ActividadProceso> listaActividadProceso = new List<ActividadProceso>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        ActividadProceso ActividadProceso = new ActividadProceso();

                        ActividadProceso.Id_actividadProceso = int.Parse(miTabla.Rows[i]["ID_ACTIVIDADPROCESO"].ToString());
                        ActividadProceso.Id_proceso = int.Parse(miTabla.Rows[i]["ID_PROCESO"].ToString());
                        ActividadProceso.Id_actividad = int.Parse(miTabla.Rows[i]["ID_ACTIVIDAD"].ToString());

                        listaActividadProceso.Add(ActividadProceso);
                    }

                    return listaActividadProceso;
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
