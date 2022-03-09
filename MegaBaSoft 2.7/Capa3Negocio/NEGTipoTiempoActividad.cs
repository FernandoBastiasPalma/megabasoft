using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGTipoTiempoActividad
    {
        public void registrarTipoTiempoActividad(TipoTiempoActividad tipoTiempoActividad, out string msjValida) // metodo para agregar TipoTiempoActividad desde la persistencia
        {
            msjValida = "";


            if ((tipoTiempoActividad.CantidadTiempo) == 0)
            {
                msjValida = "El campo Cantidad viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                PERTipoTiempoActividad accPERTipoTiempoActividad = new PERTipoTiempoActividad();

                bool exito = accPERTipoTiempoActividad.insertarTipoTiempoActividad(tipoTiempoActividad, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del TipoTiempoActividad nombre " + tipoTiempoActividad.Id + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }
}
