<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_cursoDocente.aspx.cs" Inherits="Web.frm_cursoDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_cursos" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" href="/indexDocente.aspx">Volver</asp:LinkButton>    </p>

    <br />
</asp:Content>
