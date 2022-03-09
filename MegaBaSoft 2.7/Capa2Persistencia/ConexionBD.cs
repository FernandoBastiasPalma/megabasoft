using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class ConexionBD
    {
        string cadena = @"Data Source=DESKTOP-KNB0UNO;Initial Catalog=megabasoft;Integrated Security=True";
        private SqlDataAdapter sqlAdaptador;

        public bool comprobarConexion()
        {
            string error = "";

            try
            {
                // Creamos el objeto gestor de conexión
                SqlConnection conectar = new SqlConnection();
                // Le establecemos la cadena de conexión
                conectar.ConnectionString = cadena;
                // Abrimos la conexión
                conectar.Open();
                // Cerramos la conexión
                conectar.Close();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool manipulaData(string manipulaSql, out string error)
        {
            try
            {
                error = "";
                // Creamos el objeto gestor de conexión
                SqlConnection conexion = new SqlConnection();
                // Le establecemos la cadena de conexión
                conexion.ConnectionString = cadena;
                // Abrimos la conexión
                SqlCommand sqlComando = new SqlCommand(manipulaSql, conexion);
                conexion.Open();
                int aux = sqlComando.ExecuteNonQuery();
                conexion.Close();
                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public DataTable selecData(string consultaSql, out string error)
        {
            try
            {
                error = "";
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = cadena;
                DataTable miTablaDatos = new DataTable();
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(consultaSql, conexion);

                conexion.Open();
                sqlAdaptador.Fill(miTablaDatos);
                conexion.Close();

                return miTablaDatos;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool ejecutaProcedimientoAlmacenadoManipulacion(SqlParameter[] listaDeParametros, string nombreSP, out string error)
        {
            try
            {
                error = "";
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = cadena;
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(nombreSP, conexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < listaDeParametros.Length; i++)
                {
                    sqlAdaptador.SelectCommand.Parameters.Add(listaDeParametros[i]);
                }

                conexion.Open();

                int aux = sqlAdaptador.SelectCommand.ExecuteNonQuery();

                conexion.Close();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }
    }
}
