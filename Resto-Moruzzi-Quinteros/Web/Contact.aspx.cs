using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;
using Presentacion;

namespace Web
{
    public partial class Contact : Page
    {
        private List<Producto> listaProducto;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click(object sender, EventArgs e)
        {

            Producto producto = new Producto();
            ProductoServicio productoServicio = new ProductoServicio();

            
            listaProducto = productoServicio.listar();
            dgvProductos.DataSource = listaProducto;
            dgvProductos.DataBind();
        }
    }
}