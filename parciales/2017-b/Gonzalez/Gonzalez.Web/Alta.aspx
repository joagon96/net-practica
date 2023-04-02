<%@ Page Title="Alta" Language="C#" MasterPageFile="~/MasterBase.Master" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="Gonzalez.Web.Alta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre Usuario: "></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldNombreUsuario" runat="server" ControlToValidate="txtNombreUsuario" ErrorMessage="nombre usuario requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="vldClave" runat="server" ControlToValidate="txtClave" ErrorMessage="Clave Requerida"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblTipoUsuario" runat="server" Text="Tipo Usuario: "></asp:Label>
        <asp:DropDownList ID="DropDownList" runat="server">
            <asp:ListItem Value="1">Administrador</asp:ListItem>
            <asp:ListItem Value="2">Supervisor</asp:ListItem>
            <asp:ListItem Value="3">Invitado</asp:ListItem>
        </asp:DropDownList>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:LinkButton ID="lBtnAceptar" runat="server" OnClick="lBtnAceptar_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="lBtnCancelar" runat="server" OnClick="lBtnCancelar_Click" CausesValidation="False">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
