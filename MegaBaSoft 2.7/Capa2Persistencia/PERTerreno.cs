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
    public class PERTerreno
    {
        public List<Terreno> PERlistarterreno(out string error) // metodo para listar Terreno
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from TERRENO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Terreno> listaTerreno = new List<Terreno>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Terreno TipoTerreno = new Terreno();

                        TipoTerreno.Id = int.Parse(miTabla.Rows[i]["ID_TERRENO"].ToString());
                        TipoTerreno.Codigo = miTabla.Rows[i]["CODIGO_TERRENO"].ToString();
                        TipoTerreno.Nombre = miTabla.Rows[i]["NOMBRE_TERRENO"].ToString();
                        TipoTerreno.Descripcion = miTabla.Rows[i]["DESCRIPCION_TERRENO"].ToString();

                        listaTerreno.Add(TipoTerreno);
                    }

                    return listaTerreno;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<Terreno> PERlistarterrenoPorCodigo(string consulta,Terreno terreno,out string error) // metodo para listar Terreno
        {
            try
            {
                error = "";
                string query = "";
                if (consulta == "Codigo")
                {
                     query = "select * from TERRENO where CODIGO_TERRENO = '" + terreno.Codigo + "'";
                }

                ConexionBD concexion = new ConexionBD();
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Terreno> listaTerreno = new List<Terreno>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Terreno TipoTerreno = new Terreno();

                        TipoTerreno.Id = int.Parse(miTabla.Rows[i]["ID_TERRENO"].ToString());
                        TipoTerreno.Codigo = miTabla.Rows[i]["CODIGO_TERRENO"].ToString();
                        TipoTerreno.Nombre = miTabla.Rows[i]["NOMBRE_TERRENO"].ToString();
                        TipoTerreno.Descripcion = miTabla.Rows[i]["DESCRIPCION_TERRENO"].ToString();

                        listaTerreno.Add(TipoTerreno);
                    }

                    return listaTerreno;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool InsertarTerreno(Terreno terreno, out string error) // metodo para insertar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[3];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = terreno.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre_terreno";
                parametro2.Value = terreno.Nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = terreno.Descripcion;

                listaParametros[2] = parametro3;
                

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "insertarTerreno", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool ModificarTerreno(Terreno terreno, out string error) // metodo para modificar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[3];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = terreno.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre_terreno";
                parametro2.Value = terreno.Nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = terreno.Descripcion;

                listaParametros[2] = parametro3;


                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "actualizarTerreno", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool EliminarTerreno(Terreno terreno, out string error) // metodo para eliminar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[1];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = terreno.Codigo;

                listaParametros[0] = parametro1;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "EliminarTerreno", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

    }
}
