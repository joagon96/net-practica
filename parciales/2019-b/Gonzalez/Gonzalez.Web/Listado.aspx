<%@ Page Title="Listado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Gonzalez.Web.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField AccessibleHeaderText="Apellido" DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField AccessibleHeaderText="Nombre" DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField AccessibleHeaderText="Email" DataField="Email" HeaderText="Email" />
            <asp:BoundField AccessibleHeaderText="FechaNacimiento" DataField="FechaNacimiento" HeaderText="FechaNacimiento" />
            <asp:BoundField AccessibleHeaderText="TipoPersona" DataField="TipoPersona" HeaderText="TipoPersona" />
        </Columns>
    </asp:GridView>
</asp:Panel>
</asp:Content>
