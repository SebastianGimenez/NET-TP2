﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_modificarDocente.aspx.cs" Inherits="Web.frm_modificarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p id="lblNombre">
        <br />Nombre:<asp:TextBox ID="txtNombre" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Apellido:<asp:TextBox ID="txtApellido" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Dni:<asp:TextBox ID="txtDNI" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Legajo:<asp:TextBox ID="txtLegajo" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Telefono:<asp:TextBox ID="txtTelefono" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Mail:<asp:TextBox ID="txtMail" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Usuario:<asp:TextBox ID="txtUsuario" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Contraseña:<asp:TextBox ID="txtContraseña" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" style="height: 26px" />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click"/>
    </p>
</asp:Content>
