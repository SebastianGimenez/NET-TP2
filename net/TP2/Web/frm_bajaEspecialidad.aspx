<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_bajaEspecialidad.aspx.cs" Inherits="Web.frm_bajaEspecialidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre Especialidad:<asp:DropDownList ID="ddl_Especialidades" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btn_baja" runat="server" OnClick="btn_baja_Click" Text="Dar de baja" />
    <asp:Button ID="btn_volver" runat="server" OnClick="btn_volver_Click" Text="Volver" />
    <br />
</asp:Content>
