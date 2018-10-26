<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="indexDocente.aspx.cs" Inherits="Web.indexDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem NavigateUrl="~/frm_cursoDocente.aspx" Text="Mis cursos" Value="Mis cursos"></asp:MenuItem>
            <asp:MenuItem Text="Puntuar Alumno" Value="Puntuar Alumno" NavigateUrl="~/frm_puntuacionAlumno.aspx"></asp:MenuItem>
        </Items>
    </asp:Menu>
</asp:Content>
