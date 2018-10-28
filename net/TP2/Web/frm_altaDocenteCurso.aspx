<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_altaDocenteCurso.aspx.cs" Inherits="Web.frm_altaDocenteCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Curso"></asp:Label>
    <asp:TextBox ID="txt_curso" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Docente"></asp:Label>
    <asp:DropDownList ID="ddl_Docentes" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_agregar" runat="server" OnClick="btn_agregar_Click" Text="Agregar" />
    <asp:LinkButton ID="LinkButton1" runat="server" href="/ABMDocenteCurso.aspx">Volver</asp:LinkButton>    </p>

    <br />
    <br />
</asp:Content>
