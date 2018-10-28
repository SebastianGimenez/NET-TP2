<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="ABMDocenteCurso.aspx.cs" Inherits="Web.ABMDocenteCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_docentes" runat="server" AutoGenerateSelectButton="True" DataKeyNames="idPersona">
        <SelectedRowStyle BackColor="#999999" />
    </asp:GridView>
    <br />
    <br />
    <asp:DropDownList ID="ddl_Cursos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Cursos_SelectedIndexChanged1">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_Comision" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_Materia" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="btn_alta" runat="server" OnClick="btn_alta_Click" Text="Alta" Width="116px" />
    <br />
    <asp:Button ID="btn_baja" runat="server" OnClick="btn_baja_Click" Text="Baja" Width="116px" />
    <br />
<asp:LinkButton ID="LinkButton1" runat="server" href="/indexAdmin.aspx">Volver</asp:LinkButton></asp:Content>
