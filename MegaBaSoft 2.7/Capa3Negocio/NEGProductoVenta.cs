using Capa1Entidades;
using Capa2Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3Negocio
{
    public class NEGProductoVenta
    {
        public List<ProductoVenta> NEGlistarProductoVenta(out string error)
        {
            error = "";
            try
            {
                PERProductoVenta accProductoVenta = new PERProductoVenta();
                return accProductoVenta.PERlistarProductoVenta(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public List<ProductoVenta> NEGlistarProductoPorCodigo(string Consulta, ProductoVenta producto, out string msjValida) // metodo para listar terreno por el codigo
        {
            msjValida = "";

            try
            {
                if (Consulta.Equals("Codigo"))
                {
                    PERProductoVenta accActividad = new PERProductoVenta();

                    return accActividad.PERlistarProductoPorCodigo("Codigo", producto, out msjValida);
                }
                else
                {
                    msjValida = "No has seleccionado ningún tipo de consulta";
                    return null;
                }
            }
            catch (Exception ex)
            {
                msjValida += "/n" + ex.Message;
                return null;
            }
        }

        public void Registrarproducto(ProductoVenta producto, out string msjValida) // metodo para agregar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(producto.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERProductoVenta accProducto = new PERProductoVenta();

                bool exito = accProducto.Insertarproducto(producto, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de ingreso del Terreno nombre " + producto.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void modificarProducto(ProductoVenta producto, out string msjValida) // metodo para modificar producto desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(producto.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto.Nombre))
            {
                msjValida += "El campo Nombre viene vacio" + "\n";
            }

          
            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERProductoVenta accTerreno = new PERProductoVenta();

                bool exito = accTerreno.ModificarProducto(producto, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de modificar producto nombre " + producto.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }

        public void eliminarProducto(ProductoVenta producto, out string msjValida) // metodo para eliminar terreno desde la persistencia
        {
            msjValida = "";


            if (String.IsNullOrEmpty(producto.Codigo))
            {
                msjValida = "El campo Codigo viene vacio" + "\n";
            }

            //Validacion de terreno existente

            if (msjValida.Equals(""))
            {
                PERProductoVenta accProducto = new PERProductoVenta();

                bool exito = accProducto.EliminarProducto(producto, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de eliminar de producto nombre " + producto.Nombre + "\n" +
                    "\n" + "- " + msjValida;
                }
            }
        }
    }   
}
