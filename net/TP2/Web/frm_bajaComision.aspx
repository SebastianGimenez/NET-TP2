<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_bajaComision.aspx.cs" Inherits="Web.frm_bajaComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Nombre Comision:<asp:DropDownList ID="ddl_Comisiones" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btn_baja" runat="server" OnClick="btn_baja_Click" Text="Dar de baja" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMComision.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
