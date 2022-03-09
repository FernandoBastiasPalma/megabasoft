using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa2Persistencia;

namespace Capa3Negocio
{
    public class NEGAcceso
    {
        public Usuario AccesoUsuario(Usuario usuario, out string msjValida)
        {
            try
            {

                msjValida = "";

                if (usuario.Rut_usuario==0)
                {
                    msjValida = "El campo Run viene vacio" + "\n";
                }

                if (usuario.RutDv_usuario==0)
                {
                    msjValida += "El campo Digito Verificador viene vacio" + "\n";
                }

                if (String.IsNullOrEmpty(usuario.Password_usuario))
                {
                    msjValida += "El campo Password viene vacio" + "\n";
                }

                if (msjValida.Equals(""))
                {
                    PERAcceso PERusuario = new PERAcceso();
                    Usuario usuario1 = PERusuario.AccesoUsuario(usuario, out msjValida);

                    if (usuario1 == null)
                    {
                        msjValida += "El password y/o el usuario no coinciden";
                    }

                    return usuario1;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
