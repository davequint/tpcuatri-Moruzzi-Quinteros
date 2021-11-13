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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            DatosPersonales newUser = new DatosPersonales();
            DatosPersonalesServicio datosPersonalesServicio = new DatosPersonalesServicio();

            newUser.NombreUsuario = txtUsuario.Text;
            newUser.Nombre = txtNombre.Text;
            newUser.Apellido = txtApellido.Text;
            newUser.FechaNac = DateTime.Parse(txtFechaNac.Text);
            newUser.FechaIngreso = DateTime.Now;

            datosPersonalesServicio.agregar(newUser);
        }
    }
}