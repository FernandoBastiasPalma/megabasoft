using Capa2Persistencia;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGTerreno
    {
        public List<Terreno> NEGlistarTipoTerreno(out string error) // metodo para listar terreno desde la persistencia
        {
            error = "";

            try
            {
                PERTerreno accTipoTerreno = new PERTerreno();
                return accTipoTerreno.PERlistarterreno(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<Terreno> NEGlistarTerrenoPorCodigo(string Consulta, Terreno terreno, out string msjValida) // metodo para listar terreno por el codigo
        {
            msjValida = "";

            try
            {
                if (Consulta.Equals("Codigo"))
                {
                    PERTerreno accTerreno = new PERTerreno();

                    return accTerreno.PERlistarterrenoPorCodigo("Codigo", terreno, out msjValida);
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
        
        public void registrarTerreno(Terreno terreno, out string msjValida) // metodo para agregar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(terreno.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(terreno.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(terreno.Descripcion))
            {
                msjValida += "El campo Descripcion viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERTerreno accTerreno = new PERTerreno();

                bool exito = accTerreno.InsertarTerreno(terreno, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Terreno nombre " + terreno.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void modificarTerreno(Terreno terreno, out string msjValida) // metodo para modificar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(terreno.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(terreno.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(terreno.Descripcion))
            {
                msjValida += "El campo Descripcion viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERTerreno accTerreno = new PERTerreno();

                bool exito = accTerreno.ModificarTerreno(terreno, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de modificar Terreno nombre " + terreno.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void eliminarTerreno(Terreno terreno, out string msjValida) // metodo para eliminar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(terreno.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERTerreno accTerreno = new PERTerreno();

                bool exito = accTerreno.EliminarTerreno(terreno, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de eliminar Terreno nombre " + terreno.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }

}
