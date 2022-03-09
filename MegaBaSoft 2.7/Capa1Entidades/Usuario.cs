using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa1Entidades
{
    public class Usuario
    {
        private int id_usuario;
        private int rut_usuario;
        private char rutDv_usuario;
        private string nombre_usuario;
        private string apellidoP_usuario;
        private string apellidoM_usuario;
        private string password_usuario;
        private int id_permiso;

        public Usuario() { }

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Rut_usuario { get => rut_usuario; set => rut_usuario = value; }
        public char RutDv_usuario { get => rutDv_usuario; set => rutDv_usuario = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string ApellidoP_usuario { get => apellidoP_usuario; set => apellidoP_usuario = value; }
        public string ApellidoM_usuario { get => apellidoM_usuario; set => apellidoM_usuario = value; }
        public string Password_usuario { get => password_usuario; set => password_usuario = value; }
        public int Id_permiso { get => id_permiso; set => id_permiso = value; }
        

        public Usuario( int id_usuario,
                        int rut_usuario,
                        char rutDv_usuario,
                        string nombre_usuario,
                        string apellidoP_usuario,
                        string apellidoM_usuario,
                        string password_usuario,
                        int id_permiso)
        {
            this.Id_usuario = id_usuario;
            this.Rut_usuario = rut_usuario;
            this.RutDv_usuario = rutDv_usuario;
            this.Nombre_usuario = nombre_usuario;
            this.ApellidoP_usuario = apellidoP_usuario;
            this.ApellidoM_usuario = apellidoM_usuario;
            this.Password_usuario = password_usuario;
            this.Id_permiso = id_permiso;
        }

        public Usuario (int rut_usuario,
                        char rutDv_usuario,
                        string password_usuario)
        {
            this.rut_usuario = rut_usuario;
            this.rutDv_usuario = rutDv_usuario;
            this.password_usuario = password_usuario;
        }
    }
}
