<%@ Page Title="Alumno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="Gonzalez.Web.Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Dni" runat="server" Text="Dni: "></asp:Label>
        <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <br />
        <asp:Label ID="ApeNom" runat="server" Text="Apellido y Nombre: "></asp:Label>
        <asp:TextBox ID="txtApeNom" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Email" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Edad" runat="server" Text="Edad: "></asp:Label>
        <asp:TextBox ID="txtEdad" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="NotaPromedio" runat="server" Text="Nota Promedio: "></asp:Label>
        <asp:TextBox ID="txtNotaPromedio" runat="server" ReadOnly="True"></asp:TextBox>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:LinkButton ID="listadoLinkButton" runat="server" PostBackUrl="~/Listado.aspx">Listado</asp:LinkButton>
    </asp:Panel>
</asp:Content>
