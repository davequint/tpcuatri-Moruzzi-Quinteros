<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="Web.AgregarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <h2>Agregar nuevo Producto</h2>
    <br />
    <div>
        <!-->
        Este lo ideal seria que en vez de un TextBox sea un ComboBox, para 
        poder seleccionar un tipo valido y que no pinche el programa.
        El control ComboBox no esta, es de Winform, Habria que buscar un 
        control equivalente al Combo box.
        <!-->
        <asp:Label ID="lblIdTipoProduco" runat="server" Text="Tipo de Producto"></asp:Label>
        <asp:TextBox ID="txbIdTipoProducto" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

    </div>
    <div>
        <asp:Label ID="lblStock" runat="server" Text="Stock"></asp:Label>
        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    </div>
    <br />
    <!-->
       El boton aceptar, en principio, no hace nada. Falta Agregarle la funcionalidad
       a la funcion agregar() de ProductoServicio.
    <!-->
    <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
    <a href="../../Contact.aspx">Cancelar</a>
        

</asp:Content>
