using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGTrabajoTrabajador
    {
        public void registrarTrabajoTrabajador(TrabajoTrabajador trabajoTrabajador, out string msjValida)
        // metodo para agregar MateriaPrimaActividad desde la persistencia
        {
            msjValida = "";

            if ((trabajoTrabajador.Usuario) == 0)
            {
                msjValida = "El campo usuario viene vacio" + "\n";
            }
            if ((trabajoTrabajador.TrabajoTerreno) == 0)
            {
                msjValida = "El campo trabajo viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                PERTrabajoTrabajador accPERTrabajoTrabajador = new PERTrabajoTrabajador();

                bool exito = accPERTrabajoTrabajador.insertarTrabajoTrabajador(trabajoTrabajador, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Susuario nombre " + trabajoTrabajador.Usuario + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }
}
