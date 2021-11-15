﻿using System;
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
            DatosPersonales newData = new DatosPersonales();
            Usuario newUser = new Usuario();
            DatosPersonalesServicio datosPersonalesServicio = new DatosPersonalesServicio();
            UsuarioServicio usuarioServicio = new UsuarioServicio();

            newData.NombreUsuario = txtUsuario.Text;
            newData.Nombre = txtNombre.Text;
            newData.Apellido = txtApellido.Text;
            newData.FechaNac = DateTime.Parse(txtFechaNac.Text);
            newData.FechaIngreso = DateTime.Now;

            string aux = txtUsuario.Text;

            newUser.NombreUsuario = aux;
            newUser.Contrasena = txtContrasena.Text;
            if (ddlTipo.SelectedValue.Contains("Gerente"))
            {
                newUser.Tipo = 1;
            }
            else if(ddlTipo.SelectedValue.Contains("Mesero")){ newUser.Tipo = 2; }

            datosPersonalesServicio.agregar(newData);
            usuarioServicio.agregar(newUser);
            Response.Redirect("GerentePanel.aspx");
        }
    }
}