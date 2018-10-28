<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_inscripcionAlumnoMateria.aspx.cs" Inherits="Web.frm_inscripcionAlumnoMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_cursos" runat="server" AutoGenerateSelectButton="True" DataKeyNames="idCurso">
        <SelectedRowStyle BackColor="#999999" />
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="btn_inscribir" runat="server" OnClick="btn_inscribir_Click" Text="Inscribirse" />
    <asp:LinkButton ID="LinkButton1" runat="server" href="/indexAlumno.aspx">Volver</asp:LinkButton>    </p>

    <br />
    <br />
</asp:Content>
