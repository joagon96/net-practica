<%@ Page Title="Alta" Language="C#" MasterPageFile="~/MasterBase.Master" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="Gonzalez.Web.Alta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblNombreApellido" runat="server" Text="NombreApellido: "></asp:Label>
        <asp:TextBox ID="txtNombreApellido" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldNombreApelldio" runat="server" ErrorMessage="Requerido" ForeColor="Red" ControlToValidate="txtNombreApellido"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblDni" runat="server" Text="Dni: "></asp:Label>
        <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldDni" runat="server" ErrorMessage="Requerido" ForeColor="Red" ControlToValidate="txtDni"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldEmail" runat="server" ErrorMessage="Requerido" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblFechaNac" runat="server" Text="FechaNacimiento: "></asp:Label>
        <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="lblNota" runat="server" Text="NotaPromedio: "></asp:Label>
        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldNota" runat="server" ErrorMessage="Requerido" ForeColor="Red" ControlToValidate="txtNota"></asp:RequiredFieldValidator>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:LinkButton ID="lbtnCancelar" runat="server" CausesValidation="False" OnClick="lbtnCancelar_Click">Cancelar</asp:LinkButton>
        <asp:LinkButton ID="lbtnAceptar" runat="server" OnClick="lbtnAceptar_Click">Aceptar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
