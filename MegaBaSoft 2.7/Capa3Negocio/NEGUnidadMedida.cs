using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGUnidadMedida
    {
        public List<UnidadMedida> NEGlistarUnidadMedida(out string error)
        {
            error = "";
            try
            {
                PERUnidadmedida accTipoUnidadMedida = new PERUnidadmedida();
                return accTipoUnidadMedida.PERlistarUnidadMedida(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
