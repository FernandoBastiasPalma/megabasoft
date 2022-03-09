using Capa2Persistencia;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGMateriaPrima
    {
        public List<MateriaPrima> NEGlistarUnidadMedida(out string error)
        {
            error = "";
            try
            {
                PERMateriaPrima accTipoUnidadMedida = new PERMateriaPrima();
                return accTipoUnidadMedida.PERlistarUnidadMedida(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<MateriaPrima> NEGlistarMateriaPrima(out string error)
        {
            error = "";
            try
            {
                PERMateriaPrima accTipoUnidadMedida = new PERMateriaPrima();
                return accTipoUnidadMedida.PERlistarMateriaPrima(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<MateriaPrima> NEGlistarMateriaPrimaPorCodigo(string Consulta,MateriaPrima materia, out string msjValida)
        {
            msjValida = "";

            try
            {
                if (Consulta.Equals("Codigo"))
                {
                    PERMateriaPrima accMateria = new PERMateriaPrima();

                    return accMateria.PERlistarMateriaPrimaPorCodigo("Codigo", materia,out msjValida);
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

        public void registrarMateria(MateriaPrima materia, out string msjValida) 
        {
            msjValida = "";


            if (String.IsNullOrEmpty(materia.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Descripcion))
            {
                msjValida += "El campo Descripcion viene vacio" + "\n";
            }

            if ((materia.Cantidad) == 0)
            {
                msjValida = "El campo Cantidad viene vacio" + "\n";
            }

            if ((materia.Stock) == 0)
            {
                msjValida += "El campo Stock viene vacio" + "\n";
            }

            if ((materia.Costo)==0)
            {
                msjValida += "El campo Costo viene vacio" + "\n";
            }

            if ((materia.UnidadMedida)==0)
            {
                msjValida += "El campo Unidad Medida viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERMateriaPrima accMateria = new PERMateriaPrima();

                bool exito = accMateria.InsertarMateria(materia, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Materia Prima " + materia.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void actualizarMateria(MateriaPrima materia, out string msjValida)
        {
            msjValida = "";


            if (String.IsNullOrEmpty(materia.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Descripcion))
            {
                msjValida += "El campo Descripcion viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Codigo))
            {
                msjValida = "El campo Cantidad viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Nombre))
            {
                msjValida += "El campo Stock viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Descripcion))
            {
                msjValida += "El campo Costo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(materia.Descripcion))
            {
                msjValida += "El campo Unidad Medida viene vacio" + "\n";
            }


            if (msjValida.Equals(""))
            {
                PERMateriaPrima accMateria = new PERMateriaPrima();

                bool exito = accMateria.ModificarMAteria(materia, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Materia Prima " + materia.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void eliminarMateria(MateriaPrima materia, out string msjValida) // metodo para eliminar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(materia.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

          
            if (msjValida.Equals(""))
            {
                PERMateriaPrima accMateria = new PERMateriaPrima();

                bool exito = accMateria.EliminarMateriaPrima(materia, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de eliminar Terreno nombre " + materia.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }
}
