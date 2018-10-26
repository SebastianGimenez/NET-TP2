<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="loguin.aspx.cs" Inherits="Web.loguin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label>
    <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_contraseña" runat="server" Text="Contraseña"></asp:Label>
    <asp:TextBox ID="txt_Contra" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_ingresar" runat="server" OnClick="btn_ingresar_Click" Text="Ingresar" />
    <br />
</asp:Content>
