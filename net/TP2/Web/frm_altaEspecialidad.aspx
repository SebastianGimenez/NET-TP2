<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_altaEspecialidad.aspx.cs" Inherits="Web.frm_altaEspecialidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre:<asp:TextBox ID="txt_nombre" runat="server" required="required"></asp:TextBox>
    <br />
    <br />
    Descripcion:<br />
<asp:TextBox id="txt_descripcion" TextMode="multiline" Columns="20" Rows="8" runat="server" required="required"/>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_agregar" runat="server" Text="Agregar" OnClick="btn_agregar_Click" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMEspecialidad.aspx">Volver</asp:LinkButton>    </p>
    <br />
    <br />
</asp:Content>
