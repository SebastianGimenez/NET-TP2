<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_cursosAlumno.aspx.cs" Inherits="Web.frm_cursosAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_cursos" runat="server" AutoGenerateSelectButton="True" DataKeyNames="idCurso">
        <SelectedRowStyle BackColor="#999999" />
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="btn_baja" runat="server" OnClick="btn_baja_Click" Text="Baja" />
    <br />
    <asp:Button ID="btn_Volver" runat="server" OnClick="btn_Volver_Click" Text="Volver" />
    <br />
    <br />
    <br />
</asp:Content>
