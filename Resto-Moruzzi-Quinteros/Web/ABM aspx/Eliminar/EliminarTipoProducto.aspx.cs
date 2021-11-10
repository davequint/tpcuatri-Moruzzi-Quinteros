using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio;
using Dominio;


namespace Web.ABM_aspx.Eliminar
{
    public partial class EliminarTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoDeProductoServicio tipoServicio = new TipoDeProductoServicio();

            if (!IsPostBack)
            {
                ddlTipo.DataSource = tipoServicio.listarConDDL();
                ddlTipo.DataBind();
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
           /* Falta corregir el drowDownlist para poder probar si elimina o no.
            * Comente la funcionalidad para evitar romper algo haciendo click en aceptar.

            TipoDeProducto tipo = new TipoDeProducto();
            TipoDeProductoServicio servicio = new TipoDeProductoServicio();
            try
            {
                tipo.IdTipoProducto = ddlTipo.SelectedIndex;

                servicio.eliminar(tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           */
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Contact.aspx");
        }
    }
}