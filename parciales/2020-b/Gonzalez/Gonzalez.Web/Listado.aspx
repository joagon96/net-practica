<%@ Page Title="Alumnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Gonzalez.Web.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField AccessibleHeaderText="Dni" DataField="Dni" HeaderText="Dni" />
            <asp:BoundField AccessibleHeaderText="ApellidoNombre" DataField="ApellidoNombre" HeaderText="ApellidoNombre" />
            <asp:BoundField AccessibleHeaderText="Email" DataField="Email" HeaderText="Email" />
            <asp:BoundField AccessibleHeaderText="FechaNacimiento" DataField="FechaNacimiento" HeaderText="FechaNacimiento" />
            <asp:BoundField AccessibleHeaderText="NotaPromedio" DataField="NotaPromedio" HeaderText="NotaPromedio" />
        </Columns>
    </asp:GridView>
</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:LinkButton ID="ConsultarLinkButton" runat="server" PostBackUrl="~/Alumno.aspx">Consultar</asp:LinkButton>
</asp:Panel>
</asp:Content>
