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
       
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProducto.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarProductos.aspx");
        }

        protected void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarProducto.aspx");
        }

        protected void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarProducto.aspx");
        }
    }
}