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
    <asp:Button ID="btn_volver" runat="server" OnClick="btn_volver_Click" Text="Volver" />
    <br />
    <br />
</asp:Content>
