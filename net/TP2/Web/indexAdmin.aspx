<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="indexAdmin.aspx.cs" Inherits="Web.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem Text="Carga" Value="Carga">
                <asp:MenuItem NavigateUrl="~/ABMAlumno.aspx" Text="ABM Alumnos" Value="ABM Alumnos"></asp:MenuItem>
                <asp:MenuItem Text="ABM Docentes" Value="ABM Docentes" NavigateUrl="~/ABMDocente.aspx"></asp:MenuItem>
                <asp:MenuItem Text="ABM Especialidad" Value="ABM Especialidad" NavigateUrl="~/ABMEspecialidad.aspx"></asp:MenuItem>
                <asp:MenuItem Text="ABM Plan" Value="ABM Plan" NavigateUrl="~/ABMPlan.aspx"></asp:MenuItem>
                <asp:MenuItem Text="ABM Materia" Value="ABM Materia" NavigateUrl="~/ABMMateria.aspx"></asp:MenuItem>
                <asp:MenuItem Text="ABM Comision" Value="ABM Comision" NavigateUrl="~/ABMComision.aspx"></asp:MenuItem>
                <asp:MenuItem Text="ABM Curso" Value="ABM Curso" NavigateUrl="~/ABMCurso.aspx"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/ABMDocenteCurso.aspx" Text="Agregar Docente a Curso" Value="Agregar Docente a Curso"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Alumno" Value="Alumno"></asp:MenuItem>
            <asp:MenuItem Text="Docente" Value="Docente"></asp:MenuItem>
        </Items>
    </asp:Menu>
</asp:Content>
