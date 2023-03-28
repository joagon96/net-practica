<%@ Page Title="Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Gonzalez.Web.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="formPanel" runat="server">
        <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre Usuario: "></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
        <asp:Button ID="buscarButton" runat="server" OnClick="buscarButton_Click" Text="Buscar" />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="lblTipoUsuario" runat="server" Text="Tipo Usuario: "></asp:Label>
        <asp:TextBox ID="txtTipoUsuario" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="lblUltimoIngreso" runat="server" Text="Ultimo Ingreso: "></asp:Label>
        <asp:TextBox ID="txtUltimoIngreso" runat="server" ReadOnly="True"></asp:TextBox>
    </asp:Panel>
    <br />
</asp:Content>
