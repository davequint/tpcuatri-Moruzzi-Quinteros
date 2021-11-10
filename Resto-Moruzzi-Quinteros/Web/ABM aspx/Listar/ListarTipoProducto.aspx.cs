using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;

namespace Web.ABM_aspx.Listar
{
    public partial class ListarTipoProducto : System.Web.UI.Page
    {
        private List<TipoDeProducto> listaTipoDeProductos;
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoDeProductoServicio tipoDeProductoServicio = new TipoDeProductoServicio();
            listaTipoDeProductos = tipoDeProductoServicio.listar();
            dgvTipoDeProducto.DataSource = listaTipoDeProductos;
            dgvTipoDeProducto.DataBind();
        }
    }
}