using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class consultaTrabajo
    {
      
            private string terreno;
            private string actividad;
            private string estado;
            private string usuario;

            public consultaTrabajo() { }

            public string Terreno { get => terreno; set => terreno = value; }
            public string Actividad { get => actividad; set => actividad = value; }
            public string Estado { get => estado; set => estado = value; }
            public string Usuario { get => usuario; set => usuario = value; }
            public object Codigo { get; set; }

            public consultaTrabajo(string terreno,
                                    string actividad,
                                     string estado,
                                    string usuario)

            {
                this.terreno = terreno;
                this.actividad = actividad;
                this.estado = estado;
                this.usuario = usuario;
            }


        }
    }

