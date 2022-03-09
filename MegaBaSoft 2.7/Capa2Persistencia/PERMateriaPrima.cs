using Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa1Entidades;

namespace Capa2Persistencia
{
    public class PERMateriaPrima
    {
        public List<MateriaPrima> PERlistarUnidadMedida(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from UNIDADMEDIDA";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<MateriaPrima> listaUnidadMedida = new List<MateriaPrima>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        MateriaPrima TipoUnidadMedida = new MateriaPrima();

                        TipoUnidadMedida.Id = int.Parse(miTabla.Rows[i]["ID_UNIDADMEDIDA"].ToString());
                        TipoUnidadMedida.Nombre = miTabla.Rows[i]["NOMBRE_UNIDADMEDIDA"].ToString();

                        listaUnidadMedida.Add(TipoUnidadMedida);
                    }

                    return listaUnidadMedida;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<MateriaPrima> PERlistarMateriaPrima(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from MATERIAPRIMA";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        MateriaPrima MateriaPrima = new MateriaPrima();

                        MateriaPrima.Id = int.Parse(miTabla.Rows[i]["ID_MATERIA"].ToString());
                        MateriaPrima.Codigo = miTabla.Rows[i]["CODIGO_MATERIA"].ToString();
                        MateriaPrima.Nombre = miTabla.Rows[i]["NOMBRE_MATERIA"].ToString();
                        MateriaPrima.Descripcion = miTabla.Rows[i]["DESCRIPCION_MATERIA"].ToString();
                        MateriaPrima.Cantidad = int.Parse(miTabla.Rows[i]["CANTIDAD_MATERIA"].ToString());
                        MateriaPrima.Stock = int.Parse(miTabla.Rows[i]["STOCK_MATERIA"].ToString());
                        MateriaPrima.Costo = int.Parse(miTabla.Rows[i]["COSTO_MATERIA"].ToString());
                        MateriaPrima.UnidadMedida = int.Parse(miTabla.Rows[i]["ID_UNIDADMEDIDA"].ToString());
                        
                        listaMateriaPrima.Add(MateriaPrima);
                    }

                    return listaMateriaPrima;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<MateriaPrima> PERlistarMateriaPrimaPorCodigo(string consulta, MateriaPrima materiaPrima, out string error) // metodo para listar Materia por codigo
        {
            try
            {
                error = "";
                string query = "";
                if (consulta == "Codigo")
                {
                    query = "select * from USUARIO where MATERIAPRIMA = '" + materiaPrima.Codigo + "'";
                }

                ConexionBD concexion = new ConexionBD();
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<MateriaPrima> listaMateria = new List<MateriaPrima>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        MateriaPrima TipoMateria = new MateriaPrima();

                        TipoMateria.Codigo = miTabla.Rows[i]["CODIGO_MATERIA"].ToString();
                        TipoMateria.Nombre = miTabla.Rows[i]["NOMBRE_MATERIA"].ToString();
                        TipoMateria.Descripcion = miTabla.Rows[i]["DESCRIPCION_MATERIA"].ToString();
                        TipoMateria.Cantidad = int.Parse(miTabla.Rows[i]["CANTIDAD_MATERIA"].ToString());
                        TipoMateria.Stock = int.Parse(miTabla.Rows[i]["STOCK_MATERIA"].ToString());
                        TipoMateria.Costo = int.Parse(miTabla.Rows[i]["COSTO_MATERIA"].ToString());
                        TipoMateria.UnidadMedida = int.Parse(miTabla.Rows[i]["ID_UNIDADMEDIDA"].ToString());

                        listaMateria.Add(TipoMateria);
                    }

                    return listaMateria;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool InsertarMateria(MateriaPrima materia, out string error) // metodo para insertar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();


                SqlParameter[] listaParametros = new SqlParameter[7];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = materia.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre";
                parametro2.Value = materia.Nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = materia.Descripcion;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.VarChar;
                parametro4.ParameterName = "@cantidad";
                parametro4.Value = materia.Cantidad;

                listaParametros[3] = parametro4;
             
                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.VarChar;
                parametro5.ParameterName = "@stock";
                parametro5.Value = materia.Stock;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.VarChar;
                parametro6.ParameterName = "@precioCompra";
                parametro6.Value = materia.Costo;

                listaParametros[5] = parametro6;

                SqlParameter parametro7 = new SqlParameter();
                parametro7.SqlDbType = SqlDbType.VarChar;
                parametro7.ParameterName = "@unidad";
                parametro7.Value = materia.UnidadMedida;

                listaParametros[6] = parametro7;


                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "insertarMateriaInsumos", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool ModificarMAteria(MateriaPrima materia, out string error) // metodo para modificar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[7];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = materia.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre";
                parametro2.Value = materia.Nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = materia.Descripcion;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.VarChar;
                parametro4.ParameterName = "@cantidad";
                parametro4.Value = materia.Cantidad;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.VarChar;
                parametro5.ParameterName = "@stock";
                parametro5.Value = materia.Stock;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.VarChar;
                parametro6.ParameterName = "@precioCompra";
                parametro6.Value = materia.Costo;

                listaParametros[5] = parametro6;

                SqlParameter parametro7 = new SqlParameter();
                parametro7.SqlDbType = SqlDbType.VarChar;
                parametro7.ParameterName = "@unidad";
                parametro7.Value = materia.UnidadMedida;

                listaParametros[6] = parametro7;



                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "actualizarMateriaInsumos", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool EliminarMateriaPrima(MateriaPrima materia, out string error) // metodo para eliminar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[1];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = materia.Codigo;

                listaParametros[0] = parametro1;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "EliminarMateriaPrima", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }
    }
}
