using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGProceso
    {
        public void registrarProceso(Proceso proceso, out string msjValida) // metodo para agregar proceso desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(proceso.Nombre))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }
            
            if (msjValida.Equals(""))
            {
                PERProceso accProceso = new PERProceso();

                bool exito = accProceso.InsertarProceso(proceso, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Terreno nombre " + proceso.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public List<Proceso> NEGlistarProceso(out string error) // metodo para listar proceso desde la persistencia
        {
            error = "";

            try
            {
                PERProceso accProceso = new PERProceso();
                return accProceso.PERlistarProceso(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<Proceso> NEGlistarProcesoPorId(int id,out string error) // metodo para listar proceso desde la persistencia
        {
            error = "";

            try
            {
                PERProceso accProceso = new PERProceso();
                return accProceso.PERlistarProcesoPorID(id,out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
