<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
  
    <h2><%: Title %></h2> 
    <br />
    <asp:Button ID="btnListarProducto"  Text="Listar"  OnClick="btnListar_Click"  runat="server" />
    <asp:Button ID="btnAgregarProducto" Text="Agregar" OnClick="btnAgregar_Click" runat="server" />
    <asp:Button ID="btnModificarProducto" Text="Modificar" OnClick="btnModificarProducto_Click" runat="server" />
    <asp:Button ID="btnEliminarProducto" Text="Eliminar" OnClick="btnEliminarProducto_Click" runat="server" />
</asp:Content>
