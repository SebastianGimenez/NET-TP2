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
<asp:LinkButton ID="LinkButton1" runat="server" href="/indexAlumno.aspx">Volver</asp:LinkButton>    </p>
    <br />
    <br />
    <br />
</asp:Content>
