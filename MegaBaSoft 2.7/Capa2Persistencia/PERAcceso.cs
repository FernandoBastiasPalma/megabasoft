using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERAcceso
    {
        public Usuario AccesoUsuario(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from USUARIO where RUN_USUARIO =" + usuario.Rut_usuario +
                                                  " and RUNDV_USUARIO = " + usuario.RutDv_usuario +
                                                  " and PASSWORD_USUARIO = '" + usuario.Password_usuario + "';";

                DataTable miTabla = cnx.selecData(query,out error);

                if (miTabla.Rows.Count == 0)
                {
                    return null;
                }

                else
                {
                    Usuario usuarioAutenticado = new Usuario();
                    usuarioAutenticado.Rut_usuario = int.Parse(miTabla.Rows[0]["RUN_USUARIO"].ToString());
                    usuarioAutenticado.RutDv_usuario = char.Parse(miTabla.Rows[0]["RUNDV_USUARIO"].ToString());
                    usuarioAutenticado.Password_usuario = (miTabla.Rows[0]["PASSWORD_USUARIO"].ToString());
                    usuarioAutenticado.Id_permiso = int.Parse(miTabla.Rows[0]["ID_PERMISO"].ToString());

                    return usuarioAutenticado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
