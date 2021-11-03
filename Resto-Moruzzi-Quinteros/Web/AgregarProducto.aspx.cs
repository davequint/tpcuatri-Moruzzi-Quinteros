using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;

namespace Web
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoServicio productoServicio = new ProductoServicio();

            producto.IdTipoProducto =  int.Parse(txbIdTipoProducto.Text);
            producto.Precio = decimal.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);
            producto.Estado = true;
            producto.DescripcionPlato = txtDescripcion.Text;

            //Falta desarrollar la funcion agregar()
            productoServicio.agregar();
        }
    }
}