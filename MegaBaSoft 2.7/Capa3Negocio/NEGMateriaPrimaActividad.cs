using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGMateriaPrimaActividad
    {
        public void registrarMateriaPrimaActividad(MateriaPrimaActividad materiaPrimaActividad, out string msjValida)
            // metodo para agregar MateriaPrimaActividad desde la persistencia
        {
            msjValida = "";


            if ((materiaPrimaActividad.Cantidad)==0)
            {
                msjValida = "El campo Cantidad viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                PERMateriaPrimaActividad accMateriaPrimaActividad = new PERMateriaPrimaActividad();

                bool exito = accMateriaPrimaActividad.insertarMateriaPrimaActividad(materiaPrimaActividad, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Terreno nombre " + materiaPrimaActividad.Id + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }
}
