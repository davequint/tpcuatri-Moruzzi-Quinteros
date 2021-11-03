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
    public partial class ListarProductos : System.Web.UI.Page
    {
        private List<Producto> listaProducto;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoServicio productoServicio = new ProductoServicio();
            listaProducto = productoServicio.listar();
            dgvProductos.DataSource = listaProducto;
            dgvProductos.DataBind();
        }
    }
}