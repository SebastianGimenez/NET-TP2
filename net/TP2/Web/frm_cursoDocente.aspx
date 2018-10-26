<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_cursoDocente.aspx.cs" Inherits="Web.frm_cursoDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_cursos" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="btn_volver" runat="server" OnClick="btn_volver_Click" Text="Volver" />
    <br />
</asp:Content>
