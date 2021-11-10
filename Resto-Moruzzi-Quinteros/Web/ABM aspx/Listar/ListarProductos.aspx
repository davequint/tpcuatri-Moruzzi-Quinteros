<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="Web.ListarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Lista de Productos disponibles</h2>
    <br />
    <div style="display:flex">
        <div style="padding-right:40px">   
        <asp:GridView ID="dgvProductos" runat="server"></asp:GridView> 
        </div>
        <div>
        <asp:GridView ID="dgvTipoDeProducto" runat="server"></asp:GridView>
        </div>
    </div>
    <br />
    <asp:Button Text="Volver" ID="btnVolver" runat="server" OnClick="btnVolver_Click" />
    
</asp:Content>
