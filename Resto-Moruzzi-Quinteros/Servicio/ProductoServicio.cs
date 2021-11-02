using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    class ProductoServicio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Pr.Codigo,Pr.IdTipoProducto,Pr.Precio,Pr.Stock,Pr.Estado,Pr.DescripcionPlato FROM Producto as Pr");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (int)datos.Lector["Codigo"];
                    aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Estado = (bool)datos.Lector["Estado"];
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
    }
}
