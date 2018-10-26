<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_bajaDocenteCurso.aspx.cs" Inherits="Web.frm_bajaDocenteCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Curso"></asp:Label>
    <asp:TextBox ID="txt_curso" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Docente"></asp:Label>
    <asp:TextBox ID="txt_docente" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_agregar" runat="server" OnClick="btn_agregar_Click" Text="Dar de Baja" />
    <asp:Button ID="btn_volver" runat="server" OnClick="btn_volver_Click" Text="Volver" />
</asp:Content>
