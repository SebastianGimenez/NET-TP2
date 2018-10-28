<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="ABMComision.aspx.cs" Inherits="Web.ABMComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_comisiones" runat="server" AutoGenerateSelectButton="True" DataKeyNames="idComision" style="margin-top: 0px">
        <SelectedRowStyle BackColor="#999999" />
    </asp:GridView>
    <p>
        <asp:Button ID="btn_Alta" runat="server"  Text="Alta " OnClick="btn_Alta_Click" Width="115px" />
    </p>
    <p>
        <asp:Button ID="btn_modificar" runat="server" OnClick="btn_modificar_Click" Text="Modificar " Width="115px" />
    </p>
    <p>
        <asp:Button ID="btn_baja" runat="server"  Text="Baja" OnClick="btn_baja_Click" Width="114px" />
    </p>
    <p>
<asp:LinkButton ID="LinkButton1" runat="server" href="/indexAdmin.aspx">Volver</asp:LinkButton>    </p>
</asp:Content>
