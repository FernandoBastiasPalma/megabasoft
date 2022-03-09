using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGMateriaTrabajo
    {
        public void registrarMateriaTrabajo(MateriaTrabajo materiaTrabajo, out string msjValida)
        // metodo para agregar MateriaPrimaActividad desde la persistencia
        {
            msjValida = "";

            if ((materiaTrabajo.TrabajoTerreno) == 0)
            {
                msjValida = "El campo Trabajo viene vacio" + "\n";
            }
            if ((materiaTrabajo.Materia) == 0)
            {
                msjValida = "El campo Materia viene vacio" + "\n";
            }
            if ((materiaTrabajo.Cantidad) == 0)
            {
                msjValida = "El campo Cantidad viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                PERMateriaTrabajo accPERMateriaTrabajo = new PERMateriaTrabajo();

                bool exito = accPERMateriaTrabajo.insertarMateriaTrabajo(materiaTrabajo, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Trabajo nombre " + materiaTrabajo.TrabajoTerreno + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }
}
