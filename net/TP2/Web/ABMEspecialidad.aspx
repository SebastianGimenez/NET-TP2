<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="ABMEspecialidad.aspx.cs" Inherits="Web.ABMEspecialidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:GridView ID="gv_Especialidades" runat="server" AutoGenerateSelectButton="True" DataKeyNames="idEspecialidad">
            <SelectedRowStyle BackColor="#999999" />
        </asp:GridView>
    </p>
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
        <asp:Button ID="btn_volver" runat="server" Text="Volver" OnClick="btn_volver_Click" Width="115px" />
    </p>
</asp:Content>
