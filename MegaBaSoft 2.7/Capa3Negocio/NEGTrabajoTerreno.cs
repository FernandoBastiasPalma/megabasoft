using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGTrabajoTerreno
    {
        public void registrarTrabajoTerreno(TrabajoTerreno trabajoTerreno, out string msjValida) // metodo para agregar TrabajoTerreno desde la persistencia
        {
            msjValida = "";


            if ((trabajoTerreno.Id_actividadProceso) == 0)
            {
                msjValida = "El campo Etapa viene vacio" + "\n";
            }
            
            if (msjValida.Equals(""))
            {
                PERTrabajoTerreno accTrabajoTerreno = new PERTrabajoTerreno();

                bool exito = accTrabajoTerreno.InsertarTrabajoTerreno(trabajoTerreno, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del TrabajoTerreno proceso " + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public List<TrabajoTerreno> NEGlistarTrabajoTerreno(out string error)
        {
            error = "";
            try
            {
                PERTrabajoTerreno accTrabajoTerreno = new PERTrabajoTerreno();
                return accTrabajoTerreno.PERlistarTrabajoTerreno(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<TrabajoTerreno> NEGlistarTrabajoTerrenoPorID(int id,out string error)
        {
            error = "";
            try
            {
                PERTrabajoTerreno accTrabajoTerreno = new PERTrabajoTerreno();
                return accTrabajoTerreno.PERlistarTrabajoTerrenoPorID(id,out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}

