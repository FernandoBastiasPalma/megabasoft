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
    public class PERUsuario
    {
        public bool InsertarUsuario(Usuario usuario, out string error) // metodo para insertar usuarios
        {

            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[7];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@rut_usuario";
                parametro1.Value = usuario.Rut_usuario;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@rutDV_usuario";
                parametro2.Value = usuario.RutDv_usuario;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@nombre_usuario";
                parametro3.Value = usuario.Nombre_usuario;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.VarChar;
                parametro4.ParameterName = "@apellidoP_usuario";
                parametro4.Value = usuario.ApellidoP_usuario;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.VarChar;
                parametro5.ParameterName = "@apellidoM_usuario";
                parametro5.Value = usuario.ApellidoM_usuario;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.Int;
                parametro6.ParameterName = "@password_usuario";
                parametro6.Value = usuario.Password_usuario;

                listaParametros[5] = parametro6;

                SqlParameter parametro7 = new SqlParameter();
                parametro7.SqlDbType = SqlDbType.Int;
                parametro7.ParameterName = "@permiso";
                parametro7.Value = usuario.Id_permiso;

                listaParametros[6] = parametro7;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "RegistrarUsuario", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool ModificarUsuario(Usuario usuario, out string error) // metodo para modificar usuarios
        {

            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[7];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@rut_usuario";
                parametro1.Value = usuario.Rut_usuario;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@rutDV_usuario";
                parametro2.Value = usuario.RutDv_usuario;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@nombre_usuario";
                parametro3.Value = usuario.Nombre_usuario;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.VarChar;
                parametro4.ParameterName = "@apellidoP_usuario";
                parametro4.Value = usuario.ApellidoP_usuario;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.VarChar;
                parametro5.ParameterName = "@apellidoM_usuario";
                parametro5.Value = usuario.ApellidoM_usuario;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.Int;
                parametro6.ParameterName = "@password_usuario";
                parametro6.Value = usuario.Password_usuario;

                listaParametros[5] = parametro6;

                SqlParameter parametro7 = new SqlParameter();
                parametro7.SqlDbType = SqlDbType.Int;
                parametro7.ParameterName = "@permiso";
                parametro7.Value = usuario.Id_permiso;

                listaParametros[6] = parametro7;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "ActualizarUsuario", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool EliminarUsuario(Usuario usuario, out string error) // metodo para eliminar Usuario
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[2];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@rut_usuario";
                parametro1.Value = usuario.Rut_usuario;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@rutDV_usuario";
                parametro2.Value = usuario.RutDv_usuario;

                listaParametros[1] = parametro2;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "EliminarUsuario", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public List<Usuario> PERlistarUsuarioPorRun(string consulta, Usuario usuario, out string error) // metodo para listar Usuario por run
        {
            try
            {
                error = "";
                string query = "";
                if (consulta == "Run")
                {
                    query = "select * from USUARIO where RUN_USUARIO = '" + usuario.Rut_usuario + "'and RUNDV_USUARIO =" + "'" + usuario.RutDv_usuario + "'";
                }

                ConexionBD concexion = new ConexionBD();
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Usuario> listaUsuario = new List<Usuario>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Usuario TipoUsuario = new Usuario();

                        TipoUsuario.Rut_usuario = int.Parse(miTabla.Rows[i]["RUN_USUARIO"].ToString());
                        TipoUsuario.RutDv_usuario = char.Parse(miTabla.Rows[i]["RUNDV_USUARIO"].ToString());
                        TipoUsuario.Nombre_usuario = miTabla.Rows[i]["NOMBRE_USUARIO"].ToString();
                        TipoUsuario.ApellidoP_usuario = miTabla.Rows[i]["APELLIDOP_USUARIO"].ToString();
                        TipoUsuario.ApellidoM_usuario = miTabla.Rows[i]["APELLIDOM_USUARIO"].ToString();
                        TipoUsuario.Password_usuario = miTabla.Rows[i]["PASSWORD_USUARIO"].ToString();
                        TipoUsuario.Id_permiso = int.Parse(miTabla.Rows[i]["ID_PERMISO"].ToString());

                        listaUsuario.Add(TipoUsuario);
                    }

                    return listaUsuario;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<Usuario> PERlistarUsuario(out string error) // metodo para listar Usuario
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from USUARIO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Usuario> listaUsuario = new List<Usuario>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Usuario TipoUsuario = new Usuario();
                        TipoUsuario.Id_usuario = int.Parse(miTabla.Rows[i]["ID_USUARIO"].ToString());
                        TipoUsuario.Rut_usuario = int.Parse(miTabla.Rows[i]["RUN_USUARIO"].ToString());
                        TipoUsuario.RutDv_usuario = char.Parse(miTabla.Rows[i]["RUNDV_USUARIO"].ToString());
                        TipoUsuario.Nombre_usuario = miTabla.Rows[i]["NOMBRE_USUARIO"].ToString();
                        TipoUsuario.ApellidoP_usuario = miTabla.Rows[i]["APELLIDOP_USUARIO"].ToString();
                        TipoUsuario.ApellidoM_usuario = miTabla.Rows[i]["APELLIDOM_USUARIO"].ToString();
                        TipoUsuario.Password_usuario = miTabla.Rows[i]["PASSWORD_USUARIO"].ToString();
                        TipoUsuario.Id_permiso = int.Parse(miTabla.Rows[i]["ID_PERMISO"].ToString());

                        listaUsuario.Add(TipoUsuario);
                    }

                    return listaUsuario;
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
