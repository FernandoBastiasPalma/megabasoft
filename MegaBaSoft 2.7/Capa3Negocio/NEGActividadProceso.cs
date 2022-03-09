using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGActividadProceso
    {
        public void registrarActividadProceso(ActividadProceso actividadProceso, out string msjValida) // metodo para agregar ActividadProceso desde la persistencia
        {
            msjValida = "";


            if ((actividadProceso.Id_proceso) == 0)
            {
                msjValida = "El campo proceso viene vacio" + "\n";
            }

            if ((actividadProceso.Id_actividad) == 0)
            {
                msjValida += "El campo actividad viene vacio" + "\n";
            }


            if (msjValida.Equals(""))
            {
                PERActividadProceso accActididadProceso = new PERActividadProceso();

                bool exito = accActididadProceso.InsertarActividadProceso(actividadProceso, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso de la ActividadProceso proceso " + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public List<ActividadProceso> NEGlistarActividadProceso(out string error)
        {
            error = "";
            try
            {
                PERActividadProceso accActividadProceso = new PERActividadProceso();
                return accActividadProceso.PERlistarActividadProceso(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<ActividadProceso> NEGlistarActividadProcesoPorId(string id ,out string error)
        {
            error = "";
            try
            {
                PERActividadProceso accActividadProceso = new PERActividadProceso();
                return accActividadProceso.PERlistarActividadProcesoPorId(id, out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
