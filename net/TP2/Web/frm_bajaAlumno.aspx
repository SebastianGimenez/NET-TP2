<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_bajaAlumno.aspx.cs" Inherits="Web.frm_bajaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lbl_legajo" runat="server" Text="Legajo:"></asp:Label>
        <asp:DropDownList ID="ddl_legajos" runat="server" AutoPostBack="True" >
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btn_Guardar" runat="server" OnClick="btn_Guardar_Click" Text="Dar de baja" />
        <asp:Button ID="btn_volver" runat="server" OnClick="btn_volver_Click" Text="Volver" />
    </p>
</asp:Content>
