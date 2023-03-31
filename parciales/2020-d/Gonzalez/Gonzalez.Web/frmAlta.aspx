<%@ Page Title="Alta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAlta.aspx.cs" Inherits="Gonzalez.Web.frmAlta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="lblID" runat="server" Text="ID Docente"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorID" runat="server" ControlToValidate="txtID" ErrorMessage="ID Docente Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblCuil" runat="server" Text="Cuil"></asp:Label>
        <asp:TextBox ID="txtCuil" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorCuil" runat="server" ControlToValidate="txtCuil" ErrorMessage="Cuil Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblApeNom" runat="server" Text="Apellido Nombre"></asp:Label>
        <asp:TextBox ID="txtApeNom" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorApeNom" runat="server" ControlToValidate="txtApeNom" ErrorMessage="Apellido Nombre Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblFechaIngreso" runat="server" Text="Fecha Ingreso"></asp:Label>
        <asp:Calendar ID="calFechaIngreso" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="lblSalario" runat="server" Text="Salario"></asp:Label>
        <asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorSalario" runat="server" ControlToValidate="txtSalario" ErrorMessage="Salario Requerido" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:LinkButton ID="linkBtnAceptar" runat="server" OnClick="linkBtnAceptar_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="linkBtnCancelar" runat="server" CausesValidation="False" OnClick="linkBtnCancelar_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
