<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_puntuacionAlumno.aspx.cs" Inherits="Web.frm_puntuacionAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_alumnos" runat="server" AutoGenerateSelectButton="True" DataKeyNames="idPersona">
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#999999" />
    </asp:GridView>
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
    <br />
    <asp:Button ID="btn_puntuar" runat="server" OnClick="Button1_Click" Text="Puntuar" />
    <br />
<asp:LinkButton ID="LinkButton1" runat="server" href="/indexDocente.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
