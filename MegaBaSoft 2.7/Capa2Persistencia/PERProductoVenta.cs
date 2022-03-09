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
    public class PERProductoVenta
    {

        public List<ProductoVenta> PERlistarProductoVenta(out string error)
        {
            try
            {
                error = "";
                ConexionBD concexion = new ConexionBD();
                string query = "select * from PRODUCTOVENTA";
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<ProductoVenta> listaProductoVenta = new List<ProductoVenta>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        ProductoVenta ProductoVenta = new ProductoVenta();

                        ProductoVenta.Id = int.Parse(miTabla.Rows[i]["ID_PRODUCTO"].ToString());
                        ProductoVenta.Codigo = miTabla.Rows[i]["CODIGO_PRODUCTOVENTA"].ToString();
                        ProductoVenta.Nombre = miTabla.Rows[i]["NOMBRE_PRODUCTO"].ToString();

                        listaProductoVenta.Add(ProductoVenta);
                    }

                    return listaProductoVenta;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<ProductoVenta> PERlistarProductoPorCodigo(string consulta, ProductoVenta producto, out string error) // metodo para listar Terreno
        {
            try
            {
                error = "";
                string query = "";
                if (consulta == "Codigo")
                {
                    query = "select * from PRODUCTOVENTA where CODIGO_PRODUCTOVENTA = '" + producto.Codigo + "'";
                }

                ConexionBD concexion = new ConexionBD();
                DataTable miTabla = concexion.selecData(query, out error);

                if (miTabla != null)
                {
                    List<ProductoVenta> listaProducto = new List<ProductoVenta>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        ProductoVenta TipoProducto = new ProductoVenta();

                        TipoProducto.Id = int.Parse(miTabla.Rows[i]["ID_PRODUCTO"].ToString());
                        TipoProducto.Codigo = miTabla.Rows[i]["CODIGO_PRODUCTOVENTA"].ToString();
                        TipoProducto.Nombre = miTabla.Rows[i]["NOMBRE_PRODUCTO"].ToString();


                        listaProducto.Add(TipoProducto);
                    }

                    return listaProducto;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool Insertarproducto(ProductoVenta producto, out string error) // metodo para insertar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[2];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = producto.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre_Producto";
                parametro2.Value = producto.Nombre;

                listaParametros[1] = parametro2;



                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "insertarProductoVenta", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool ModificarProducto(ProductoVenta producto, out string error) // metodo para modificar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[2];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = producto.Codigo;

                listaParametros[0] = parametro1;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre_Producto";
                parametro2.Value = producto.Nombre;

                listaParametros[1] = parametro2;



                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "actualizarProductoVenta", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public bool EliminarProducto(ProductoVenta producto, out string error) // metodo para eliminar Terreno
        {
            try
            {
                error = "";
                ConexionBD llamarConexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[1];

                SqlParameter parametro1 = new SqlParameter();
                parametro1.SqlDbType = SqlDbType.VarChar;
                parametro1.ParameterName = "@codigo";
                parametro1.Value = producto.Codigo;

                listaParametros[0] = parametro1;

                return llamarConexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "EliminarProducto", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

    }   
}
