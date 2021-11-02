<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
  
    <h2><%: Title %></h2> 
    <br />
    <asp:Button Text="Listar" OnClick="btnAceptar_Click" runat="server" />
    <asp:GridView ID="dgvProductos" runat="server"></asp:GridView>
</asp:Content>
