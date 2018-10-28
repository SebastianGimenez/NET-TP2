<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_bajaMateria.aspx.cs" Inherits="Web.frm_bajaMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ddl_materias" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btn_baja" runat="server" OnClick="btn_baja_Click" Text="Baja" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMMateria.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
