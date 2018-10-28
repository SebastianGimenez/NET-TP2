<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_altaComision.aspx.cs" Inherits="Web.frm_altaComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre:<asp:TextBox ID="txt_nombre" runat="server" required="required"></asp:TextBox>
    <br />
    <br />Aula:<asp:TextBox ID="txt_aula" runat="server" required="required"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btn_agregar" runat="server" Text="Agregar" OnClick="btn_agregar_Click" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMComision.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
