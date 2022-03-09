using Capa2Persistencia;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGEstadoTrabajo
    {
        public List<EstadoTrabajo> NEGlistarEstadoTrabajo(out string error)
        {
            error = "";
            try
            {
                PEREstadoTrabajo accEstadoTrabajo = new PEREstadoTrabajo();
                return accEstadoTrabajo.PERlistarestado(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
