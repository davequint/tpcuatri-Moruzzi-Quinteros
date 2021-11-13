﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class ProductoServicio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Pr.Codigo, Pr.IdTipoProducto, Pr.Precio, Pr.Stock, Pr.DescripcionPlato FROM Producto as Pr where Estado = 1");
                datos.ejecutarLectura();
                

                while(datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (int)datos.Lector["Codigo"];
                    aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.DescripcionPlato = (string)datos.Lector["DescripcionPlato"];

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Producto newProducto)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("insert into Producto(IdTipoProducto, Precio, Stock, Estado, DescripcionPlato) values(@IdTipoProducto, @Precio, @Stock, @Estado, @DescripcionPlato)");
                accesoDatos.setearParametro("@IdTipoProducto",newProducto.IdTipoProducto);
                accesoDatos.setearParametro("@Precio", newProducto.Precio);
                accesoDatos.setearParametro("@Stock",newProducto.Stock);
                accesoDatos.setearParametro("@Estado",newProducto.Estado);
                accesoDatos.setearParametro("@DescripcionPlato",newProducto.DescripcionPlato);           
                accesoDatos.ejecutarAccion();    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void modificar(Producto productoModificado)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("update Producto set IdTipoProducto = @IdTipoProducto, Precio = @Precio, Stock = @Stock, Estado=@Estado, DescripcionPlato=@DescripcionPlato where Codigo=@Codigo");
                accesoDatos.setearParametro("@IdTipoProducto", productoModificado.IdTipoProducto);
                accesoDatos.setearParametro("@Precio",productoModificado.Precio);
                accesoDatos.setearParametro("@Stock",productoModificado.Stock);
                accesoDatos.setearParametro("@Estado",productoModificado.Estado);
                accesoDatos.setearParametro("@DescripcionPlato",productoModificado.DescripcionPlato);
                accesoDatos.setearParametro("@Codigo",productoModificado.Codigo);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }

        public void Eliminar(int codigoEliminado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Producto SET Estado = 0 where Codigo = @Codigo");
                datos.setearParametro("@Codigo", codigoEliminado);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
