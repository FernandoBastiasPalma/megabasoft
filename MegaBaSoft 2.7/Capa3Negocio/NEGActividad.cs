using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGActividad
    {
        public List<Actividad> NEGlistarActividad(out string error)
        {
            error = "";
            try
            {
                PERActividad accActividad = new PERActividad();
                return accActividad.PERlistarActividad(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<Actividad> NEGlistaractividadPorConsulta(string Consulta, Actividad actividad, out string msjValida) // metodo para listar terreno por el codigo
        {
            msjValida = "";

            try
            {
                if (Consulta.Equals("Codigo"))
                {
                    PERActividad accActividad = new PERActividad();

                    return accActividad.PERlistarActividadPorConsulta("Codigo", actividad, out msjValida);
                }
                if (Consulta.Equals("Id"))
                {
                    PERActividad accActividad = new PERActividad();

                    return accActividad.PERlistarActividadPorConsulta("Id", actividad, out msjValida);
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

        public void registrarActividad(Actividad actividad, out string msjValida) // metodo para agregar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(actividad.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(actividad.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(actividad.Descripcion))
            {
                msjValida += "El campo Descripcion viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERActividad accActividad = new PERActividad();

                bool exito = accActividad.InsertarActividad(actividad, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso de la actividad nombre " + actividad.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void modificarActividad(Actividad actividad, out string msjValida) // metodo para modificar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(actividad.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(actividad.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(actividad.Descripcion))
            {
                msjValida += "El campo Descripcion viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERActividad accTerreno = new PERActividad();

                bool exito = accTerreno.ModificarActividad(actividad, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de modificar Terreno nombre " + actividad.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void eliminarActividad(Actividad actividad, out string msjValida) // metodo para eliminar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(actividad.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

           

            if (msjValida.Equals(""))
            {
                PERActividad accActividad = new PERActividad();

                bool exito = accActividad.EliminarActividad(actividad, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de eliminar Terreno nombre " + actividad.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

    }
}
