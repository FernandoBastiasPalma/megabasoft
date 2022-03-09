using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class TrabajoTrabajador
    {
        private int id;
        private int usuario;
        private int trabajoTerreno;

        public TrabajoTrabajador() { }

        public int Id { get => id; set => id = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public int TrabajoTerreno { get => trabajoTerreno; set => trabajoTerreno = value; }

        public TrabajoTrabajador(int id,int usuario,int trabajoTerreno)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.TrabajoTerreno = trabajoTerreno;
        }
    }
}
