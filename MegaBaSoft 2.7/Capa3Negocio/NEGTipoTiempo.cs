using Capa2Persistencia;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGTipoTiempo
    {
        public List<TipoTiempo> NEGlistarTipoTiempo(out string error)
        {
            error = "";
            try
            {
                PERTipoTiempo accTipoTiempo = new PERTipoTiempo();
                return accTipoTiempo.PERlistarTipoTiempo(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
