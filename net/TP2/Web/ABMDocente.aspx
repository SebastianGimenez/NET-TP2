﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="ABMDocente.aspx.cs" Inherits="Web.ABMDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:GridView ID="grv_Docentes" runat="server" Width="611px" AutoGenerateSelectButton="True" DataKeyNames="IdPersona">
            <SelectedRowStyle BackColor="#CCCCCC" />
        </asp:GridView>
        <br />
        <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" Width="139px" />
    </p>
    <p>
        <asp:Button ID="btnBaja" runat="server" Text="Baja" Width="138px" OnClick="btnBaja_Click" />
    </p>
    <p>
        <asp:Button ID="btnModificacion" runat="server" Text="Modificacion" Width="138px" OnClick="btnModificacion_Click" />
    </p>
    <p>

    </p>
        <asp:LinkButton ID="LinkButton1" runat="server" href="/indexAdmin.aspx">Volver</asp:LinkButton>
    
</asp:Content>
