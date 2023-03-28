<%@ Page Title="Listado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Gonzalez.Web.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField AccessibleHeaderText="NombreUsuario" DataField="NombreUsuario" HeaderText="NombreUsuario" />
            <asp:BoundField AccessibleHeaderText="Email" DataField="Email" HeaderText="Email" />
            <asp:BoundField AccessibleHeaderText="TipoUsuario" DataField="TipoUsuario" HeaderText="TipoUsuario" />
            <asp:BoundField AccessibleHeaderText="UltimoIngreso" DataField="UltimoIngreso" HeaderText="UltimoIngreso" />
        </Columns>
    </asp:GridView>
</asp:Content>
