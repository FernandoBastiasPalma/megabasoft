using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGpruebaConexion
    {
        public bool comprobarConectividadBD()
        {
            ConexionBD conectarBD = new ConexionBD();
            return conectarBD.comprobarConexion();
        }
    }
}
