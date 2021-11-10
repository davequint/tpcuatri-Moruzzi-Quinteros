<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="Web.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>NUEVO USUARIO</h2>
    </div>

    <div>
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="lblFechaNac" runat="server" Text="Fecha de Nacimiento"></asp:Label>
        <asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
    </div>
    <br />
    <div>
        <h2>LISTAR</h2>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    

</asp:Content>
