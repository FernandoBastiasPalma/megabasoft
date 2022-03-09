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
    public class PERActividad
    {
        public List<Actividad> PERlistarActividad(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from ACTIVIDAD";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Actividad> listaActividad = new List<Actividad>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Actividad Actividad = new Actividad();

                        Actividad.Id = int.Parse(miTabla.Rows[i]["ID_ACTIVIDAD"].ToString());
                        Actividad.Codigo = miTabla.Rows[i]["CODIGO_ACTIVIDAD"].ToString();
                        Actividad.Nombre = miTabla.Rows[i]["NOMBRE_ACTIVIDAD"].ToString();
                        Actividad.Descripcion = miTabla.Rows[i]["DESCRIPCION_ACTIVIDAD"].ToString();

                        listaActividad.Add(Actividad);
                    }

                    return listaActividad;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<Actividad> PERlistarActividadPorConsulta(string consulta, Actividad actividad, out string error) // metodo para listar Terreno
        {
            try
            {
                error = "";
                string query = "";
                if (consulta == "Codigo")
                {
                    query = "select * from ACTIVIDAD where CODIGO_ACTIVIDAD = '" + actividad.Codigo + "'";
                }
                if (consulta == "Id")
                {
                    query = "select * from ACTIVIDAD where ID_ACTIVIDAD = '" + actividad.Id + "'";
                }
                ConexionBD concexion = new ConexionBD();
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Actividad> listaactividad = new List<Actividad>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Actividad TipoActividad = new Actividad();

                        TipoActividad.Id = int.Parse(miTabla.Rows[i]["ID_ACTIVIDAD"].ToString());
                        TipoActividad.Codigo = miTabla.Rows[i]["CODIGO_ACTIVIDAD"].ToString();
                        TipoActividad.Nombre = miTabla.Rows[i]["NOMBRE_ACTIVIDAD"].ToString();
                        TipoActividad.Descripcion = miTabla.Rows[i]["DESCRIPCION_ACTIVIDAD"].ToString();

                        listaactividad.Add(TipoActividad);
                    }

                    return listaactividad;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool InsertarActividad(Actividad actividad, out string error) // metodo para insertar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[3];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = actividad.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre_Actividad";
                parametro2.Value = actividad.Nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = actividad.Descripcion;

                listaParametros[2] = parametro3;


                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "insertarActividad", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool ModificarActividad(Actividad actividad, out string error) // metodo para modificar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[3];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = actividad.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre_Actividad";
                parametro2.Value = actividad.Nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = actividad.Descripcion;

                listaParametros[2] = parametro3;


                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "actualizarActividad", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool EliminarActividad(Actividad actividad, out string error) // metodo para eliminar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[1];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = actividad.Codigo;

                listaParametros[0] = parametro1;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "EliminarActidad", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }
    }
}
