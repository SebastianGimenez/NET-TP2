<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_modificarCurso.aspx.cs" Inherits="Web.frm_modificarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_cupo" runat="server" Text="Cupo"></asp:Label>
    <asp:TextBox ID="txt_cupo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_comision" runat="server" Text="Comision"></asp:Label>
    <asp:DropDownList ID="ddl_comisiones" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lbl_materia" runat="server" Text="Materia"></asp:Label>
    <asp:DropDownList ID="ddl_materias" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_agregar" runat="server" OnClick="btn_agregar_Click" Text="Agregar" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMCurso.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
