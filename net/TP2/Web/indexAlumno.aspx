<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="indexAlumno.aspx.cs" Inherits="Web.indexAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem Text="Inscribirse a una Materia" Value="Inscribirse a una Materia" NavigateUrl="~/frm_inscripcionAlumnoMateria.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Ver mis notas" Value="Ver mis notas" NavigateUrl="~/frm_cursosAlumno.aspx"></asp:MenuItem>
        </Items>
    </asp:Menu>
</asp:Content>
