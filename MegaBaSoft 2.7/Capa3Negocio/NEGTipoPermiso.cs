using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGTipoPermiso
    {
        public List<TipoPermiso> NEGlistarTipoPermiso(out string error)
        {
            error = "";
            try
            {
                PERTipoPermiso accTipoPermiso = new PERTipoPermiso();
                return accTipoPermiso.PERlistarTipoPermiso(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
