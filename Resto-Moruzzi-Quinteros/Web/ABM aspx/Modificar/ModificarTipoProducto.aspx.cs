using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;


namespace Web.ABM_aspx.Modificar
{
    public partial class ModificarTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            TipoDeProductoServicio tipoServicio = new TipoDeProductoServicio();
            try
            {
                if (!IsPostBack)
                {
                    ddlTipos.DataSource = tipoServicio.listarConDDL();
                    ddlTipos.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Contact.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            /*
             * Falta corregir el drowDownlist para poder probar si modifica o no.
             * Comente la funcionalidad para evitar romper algo haciendo click en aceptar.
             * 
            TipoDeProducto tipo = new TipoDeProducto();
            TipoDeProductoServicio servicio = new TipoDeProductoServicio();
            try
            {
                tipo.Descripcion = txtNombre.Text;
                tipo.IdTipoProducto = ddlTipos.SelectedIndex;

                servicio.modificar(tipo);

            }
            catch (Exception ex)
            {

                throw ex;
            }*/
        }

        protected void ddlTipos_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }
        protected void ddlTipos_TextChanged(object sender, EventArgs e)
        {    
        }
    }
}