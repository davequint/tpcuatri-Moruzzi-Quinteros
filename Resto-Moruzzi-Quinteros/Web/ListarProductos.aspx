<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="Web.ListarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Lista de Productos disponibles</h2>
    <br />
    <asp:GridView ID="dgvProductos" runat="server"></asp:GridView>
    <br />
    <a href="Contact.aspx">Volver</a>

</asp:Content>
