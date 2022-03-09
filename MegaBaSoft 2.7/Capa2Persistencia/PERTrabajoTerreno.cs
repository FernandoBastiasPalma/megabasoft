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
    public class PERTrabajoTerreno
    {
        public bool InsertarTrabajoTerreno(TrabajoTerreno trabajoTerreno, out string error) // metodo para insertar trabajoTerreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[5];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.Int;
                parametro1.ParameterName = "@id_terreno";
                parametro1.Value = trabajoTerreno.Id_terreno;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.ParameterName = "@id_actividadProceso";
                parametro2.Value = trabajoTerreno.Id_actividadProceso;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.Int;
                parametro3.ParameterName = "@id_estado";
                parametro3.Value = trabajoTerreno.Id_estado;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.DateTime;
                parametro4.ParameterName = "@fecha_inicio";
                parametro4.Value = trabajoTerreno.Fecha_inicio;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.DateTime;
                parametro5.ParameterName = "@fecha_termino";
                parametro5.Value = trabajoTerreno.Fecha_termino;

                listaParametros[4] = parametro5;

                
                
                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "InsertarTrabajoTerreno", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }



        }

        public List<TrabajoTerreno> PERlistarTrabajoTerreno(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from TRABAJO_TERRENO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<TrabajoTerreno> listaTrabajoTerreno= new List<TrabajoTerreno>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        TrabajoTerreno TrabajoTerreno = new TrabajoTerreno();

                        TrabajoTerreno.Id_trabajoTerreno = int.Parse(miTabla.Rows[i]["ID_TRABAJOTERRENO"].ToString());
                        TrabajoTerreno.Id_terreno = int.Parse(miTabla.Rows[i]["ID_TERRENO"].ToString());
                        TrabajoTerreno.Id_actividadProceso = int.Parse(miTabla.Rows[i]["ID_ACTIVIDADPROCESO"].ToString());
                        TrabajoTerreno.Id_estado = int.Parse(miTabla.Rows[i]["ID_ESTADO"].ToString());
                        TrabajoTerreno.Fecha_inicio = DateTime.Parse(miTabla.Rows[i]["FECHA_INICIO"].ToString());
                        TrabajoTerreno.Fecha_termino = DateTime.Parse(miTabla.Rows[i]["FECHA_TERMINO"].ToString());


                        listaTrabajoTerreno.Add(TrabajoTerreno);
                    }

                    return listaTrabajoTerreno;
                }
                return null;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<TrabajoTerreno> PERlistarTrabajoTerrenoPorID(int id,out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from TRABAJO_TERRENO where ID_TRABAJOTERRENO = " + id;
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<TrabajoTerreno> listaTrabajoTerreno = new List<TrabajoTerreno>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        TrabajoTerreno TrabajoTerreno = new TrabajoTerreno();

                        TrabajoTerreno.Id_trabajoTerreno = int.Parse(miTabla.Rows[i]["ID_TRABAJOTERRENO"].ToString());
                        TrabajoTerreno.Id_terreno = int.Parse(miTabla.Rows[i]["ID_TERRENO"].ToString());
                        TrabajoTerreno.Id_actividadProceso = int.Parse(miTabla.Rows[i]["ID_ACTIVIDADPROCESO"].ToString());
                        TrabajoTerreno.Id_estado = int.Parse(miTabla.Rows[i]["ID_ESTADO"].ToString());
                        TrabajoTerreno.Fecha_inicio = DateTime.Parse(miTabla.Rows[i]["FECHA_INICIO"].ToString());
                        TrabajoTerreno.Fecha_termino = DateTime.Parse(miTabla.Rows[i]["FECHA_TERMINO"].ToString());


                        listaTrabajoTerreno.Add(TrabajoTerreno);
                    }

                    return listaTrabajoTerreno;
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
