using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGUsuario
    {
        public void registrarUsuario(Usuario usuario, out string msjValida) // metodo para agregar Usuario desde la persistencia
        {
            msjValida = "";


            if ((usuario.Rut_usuario)==0)
            {
                msjValida = "El campo run viene vacio" + "\n";
            }

            if ((usuario.RutDv_usuario)==0)
            {
                msjValida += "El campo digito verificador viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.Nombre_usuario))
            {
                msjValida += "El campo nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.ApellidoP_usuario))
            {
                msjValida += "El campo apellido paterno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.ApellidoM_usuario))
            {
                msjValida += "El campo apellido materno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.Password_usuario))
            {
                msjValida += "El campo password viene vacio" + "\n";
            }

            if ((usuario.Id_permiso)==0)
            {
                msjValida += "El campo permiso viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERUsuario accUsuario = new PERUsuario();

                bool exito = accUsuario.InsertarUsuario(usuario, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Usuario run " + usuario.Rut_usuario + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void modificarUsuario(Usuario usuario, out string msjValida) // metodo para modificar Usuario desde la persistencia
        {
            msjValida = "";


            if ((usuario.Rut_usuario) == 0)
            {
                msjValida = "El campo run viene vacio" + "\n";
            }

            if ((usuario.RutDv_usuario) == 0)
            {
                msjValida += "El campo digito verificador viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.Nombre_usuario))
            {
                msjValida += "El campo nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.ApellidoP_usuario))
            {
                msjValida += "El campo apellido paterno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.ApellidoM_usuario))
            {
                msjValida += "El campo apellido materno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario.Password_usuario))
            {
                msjValida += "El campo password viene vacio" + "\n";
            }

            if ((usuario.Id_permiso) == 0)
            {
                msjValida += "El campo permiso viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERUsuario accUsuario = new PERUsuario();

                bool exito = accUsuario.ModificarUsuario(usuario, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de modificacion del Usuario run " + usuario.Rut_usuario + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void eliminarUsuario(Usuario usuario, out string msjValida) // metodo para eliminar Usuario desde la persistencia
        {
            msjValida = "";


            if ((usuario.Rut_usuario) == 0)
            {
                msjValida = "El campo run viene vacio" + "\n";
            }

            if ((usuario.RutDv_usuario) == 0)
            {
                msjValida += "El campo digito verificador viene vacio" + "\n";
            }
            
            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERUsuario accUsuario = new PERUsuario();

                bool exito = accUsuario.EliminarUsuario(usuario, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de eliminar del Usuario run " + usuario.Rut_usuario + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public List<Usuario> NEGlistarUsuarioPorRun(string Consulta, Usuario usuario, out string msjValida) // metodo para listar usuario por el run
        {
            msjValida = "";

            try
            {
                if (Consulta.Equals("Run"))
                {
                    PERUsuario accUsuario = new PERUsuario();

                    return accUsuario.PERlistarUsuarioPorRun("Run", usuario, out msjValida);
                }
                else
                {
                    msjValida = "No has seleccionado ningún tipo de consulta";
                    return null;
                }
            }
            catch (Exception ex)
            {
                msjValida += "/n" + ex.Message;
                return null;
            }
        }

        public List<Usuario> NEGlistarUsuario( out string msjValida) // metodo para listar usuario por el run
        {
            msjValida = "";

            try
            {
                PERUsuario accTipoUsuario = new PERUsuario();
                return accTipoUsuario.PERlistarUsuario(out msjValida);
            }
            catch (Exception ex)
            {
                msjValida += "/n" + ex.Message;
                return null;
            }
        }
    }
}
