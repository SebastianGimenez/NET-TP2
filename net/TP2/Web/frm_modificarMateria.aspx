<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_modificarMateria.aspx.cs" Inherits="Web.frm_modificarMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_nombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server" required="required"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_descripcion" runat="server" Text="Descripcion:"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_descripcion" TextMode="multiline" Columns="20" Rows="8" runat="server" required="required"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_hsSemanales" runat="server" Text="Horas Semanales:"></asp:Label>
    <asp:TextBox ID="txt_hsSemanales" runat="server" required="required"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_hsTotales" runat="server" Text="Horas Totales:"></asp:Label>
    <asp:TextBox ID="txt_hsTotales" runat="server" required="required"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_plan" runat="server" Text="Plan:"></asp:Label>
    <asp:DropDownList ID="ddl_planes" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btn_agregar" runat="server" OnClick="btn_agregar_Click" Text="Agregar" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMMateria.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
