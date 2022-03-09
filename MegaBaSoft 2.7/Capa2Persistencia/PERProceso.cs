using Capa1Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2Persistencia
{
    public class PERProceso
    {
        public List<Proceso> PERlistarProceso(out string error) // metodo para listar Proceso
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from PROCESO";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Proceso> listaProceso = new List<Proceso>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Proceso TipoProceso = new Proceso();

                        TipoProceso.Id = int.Parse(miTabla.Rows[i]["ID_PROCESO"].ToString());
                        TipoProceso.Nombre = miTabla.Rows[i]["NOMBRE_PROCESO"].ToString();
                        TipoProceso.Producto = int.Parse(miTabla.Rows[i]["ID_PRODUCTO"].ToString());

                        listaProceso.Add(TipoProceso);
                    }

                    return listaProceso;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<Proceso> PERlistarProcesoPorID(int id,out string error) // metodo para listar Proceso
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from PROCESO where ID_PROCESO = " + id;
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Proceso> listaProceso = new List<Proceso>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Proceso TipoProceso = new Proceso();

                        TipoProceso.Id = int.Parse(miTabla.Rows[i]["ID_PROCESO"].ToString());
                        TipoProceso.Nombre = miTabla.Rows[i]["NOMBRE_PROCESO"].ToString();
                        TipoProceso.Producto = int.Parse(miTabla.Rows[i]["ID_PRODUCTO"].ToString());

                        listaProceso.Add(TipoProceso);
                    }

                    return listaProceso;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool InsertarProceso(Proceso proceso, out string error) // metodo para insertar Proceso
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[2];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@nombreproceso";
                parametro1.Value = proceso.Nombre;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@producto";
                parametro2.Value = proceso.Producto;

                listaParametros[1] = parametro2;
                
                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "AgregarProceso", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

    }
}
